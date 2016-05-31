---<summary>
---Insert a new packaging for a specific product in database
---</summary>
---<param name="@p_productId" ref="Product.Packaging.ProductId"/>
---<param name="@p_unity" ref="Product.Packaging.Unity"/>
---<param name="@p_quantity" ref="Product.Packaging.Quantity"/>
---<param name="@p_fromId" ref="Product.Packaging.FromId"/>
---<param name="@p_gtin" ref="Product.Packaging.GTIN"/>
---<exception cref="SqlException">Severity 16
---     <para>State 10 : GTIN already exists (in products)</para>
---     <para>State 11 : GTIN already exists (in packagings)</para>
---     <para>State 12 : Quantity cannot be negative</para>
---     <para>State 255 : Error while creating product</para>
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Product].[uspCreatePackaging]
    @p_productId int,
    @p_unity varchar(255),
    @p_quantity int,
    @p_fromId int = NULL,
    @p_gtin varchar(255) = NULL
AS
BEGIN;
    DECLARE @Rc int,
            @Id int;

    BEGIN TRANSACTION;

    BEGIN TRY;
        IF (ISNULL(@p_gtin, '') != '')
        BEGIN;
            IF (EXISTS(SELECT TOP 1 1 FROM Product.Product WHERE GTIN = @p_gtin)) RAISERROR('GTIN already exists', 16, 10) WITH LOG;
            IF (EXISTS(SELECT TOP 1 1 FROM Product.Packaging WHERE GTIN = @p_gtin)) RAISERROR('GTIN already exists', 16, 11) WITH LOG;
        END;
        IF(@p_quantity <= 0) RAISERROR('Quantity cannot be negative', 16, 12) WITH LOG;

        --Create operator
        INSERT INTO Product.Packaging(ProductId, Unity, Quantity, GTIN, FromId)
        VALUES(@p_productId, @p_unity, @p_quantity, @p_gtin, @p_fromId);

        SELECT @Rc = @@ROWCOUNT, @Id = @@IDENTITY;

        IF (@Rc != 1) RAISERROR('Error while creating packaging', 16, 255) WITH LOG;

        EXEC Product.uspGetPackaging @p_id = @Id;

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