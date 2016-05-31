---<summary>
---Insert a new product in database
---</summary>
---<param name="@p_code" ref="Product.Product.Code"/>
---<param name="@p_label" ref="Product.Product.Label"/>
---<param name="@p_unity" ref="Product.Product.Unity"/>
---<param name="@p_weight" ref="Product.Product.Weight"/>
---<param name="@p_tare" ref="Product.Product.Tare"/>
---<param name="@p_gtin" ref="Product.Product.GTIN"/>
---<exception cref="SqlException">Severity 16
---     State 10 : Code cannot be EMPTY
---     State 11 : Label cannot be EMPTY
---     State 12 : Code already exists
---     State 13 : GTIN already exists (in products)
---     State 14 : GTIN already exists (in packagings)
---     State 255 : Error while creating product
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Product].[uspCreateProduct]
    @p_code varchar(255),
    @p_label varchar(255),
    @p_unity varchar(255) = NULL,
    @p_weight decimal(12, 3) = NULL,
    @p_tare decimal(12, 3) = NULL,
    @p_gtin varchar(255) = NULL
AS
BEGIN;
    DECLARE @Rc int,
            @Id int;

    BEGIN TRANSACTION;

    BEGIN TRY;
        IF (RTRIM(LTRIM(ISNULL(@p_code, ''))) = '') RAISERROR('Code cannot be EMPTY', 16, 10) WITH LOG;
        IF (RTRIM(LTRIM(ISNULL(@p_label, ''))) = '') RAISERROR('Label cannot be EMPTY', 16, 11) WITH LOG;
        IF (EXISTS(SELECT TOP 1 1 FROM Product.Product WHERE Code = @p_code)) RAISERROR('Code already exists', 16, 12) WITH LOG;
        IF (ISNULL(@p_gtin, '') != '')
        BEGIN;
            IF (EXISTS(SELECT TOP 1 1 FROM Product.Product WHERE GTIN = @p_gtin)) RAISERROR('GTIN already exists', 16, 13) WITH LOG;
            IF (EXISTS(SELECT TOP 1 1 FROM Product.Packaging WHERE GTIN = @p_gtin)) RAISERROR('GTIN already exists', 16, 14) WITH LOG;
        END;

        --Create operator
        INSERT INTO Product.Product(Code, Label, Unity, Weight, Tare, GTIN)
        VALUES(@p_code, @p_label, @p_unity, @p_weight, @p_tare, @p_gtin);

        SELECT @Rc = @@ROWCOUNT, @Id = @@IDENTITY;

        IF (@Rc != 1) RAISERROR('Error while creating product', 16, 255) WITH LOG;

        EXEC Product.uspGetProduct @p_id = @Id;

        COMMIT TRANSACTION;

        RETURN 1;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE(),
                @ErrorSeverity int = ERROR_SEVERITY(),
                @ErrorState int = ERROR_STATE();

        ROLLBACK TRANSACTION;

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);

        RETURN 0; -- indicate failure
    END CATCH;
END;