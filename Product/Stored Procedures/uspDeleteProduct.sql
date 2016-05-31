---<summary>
---Delete an existing product from database
---</summary>
---<param name="@p_productId" ref="Product.Product.Id"/>
---<exception cref="SqlException">Severity 16
---     State 255 : Error while deleting product
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Product].[uspDeleteProduct]
    @p_productId int
AS
BEGIN;
    BEGIN TRANSACTION;

    BEGIN TRY;

        DELETE Pac
        FROM Product.Packaging Pac
            INNER JOIN  Product.Product Pro ON Pro.Id = Pac.ProductId
        WHERE Pro.Id = @p_productId;

        DELETE FROM Product.Product WHERE Id = @p_productId;

        IF (@@ROWCOUNT != 1) RAISERROR('Error while deleting product', 16, 255) WITH LOG;

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