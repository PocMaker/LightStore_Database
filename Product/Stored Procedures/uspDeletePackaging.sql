---<summary>
---Delete an/several existing packaging(s) from database for a specific product
---</summary>
---<param name="@p_productId" ref="Product.Product.Id"/>
---<param name="@p_id" ref="Product.Packaging.Id"/>
---<exception cref="SqlException">Severity 16
---     <para>State 255 : Error while deleting packaging</para>
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Product].[uspDeletePackaging]
	@p_productId int,
	@p_id int = NULL
AS
BEGIN;
	BEGIN TRANSACTION;

    BEGIN TRY;

        DELETE
        FROM Product.Packaging
        WHERE ProductId = @p_productId
		  AND Id = ISNULL(@p_id, Id);

        IF (@@ROWCOUNT < 1) RAISERROR('Error while deleting packaging', 16, 255) WITH LOG;

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