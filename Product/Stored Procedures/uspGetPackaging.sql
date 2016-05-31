---<summary>
---Select a packaging from database thanks to parameters
---</summary>
---<param name="@p_id" ref="Product.Packaging.Id">Filter if provided</param>
---<param name="@p_productId" ref="Product.Packaging.ProductId">Filter if provided</param>
---<exception cref="SqlException">Severity 16
---     State 10 : At least one parameter is requiered
---</exception>
CREATE PROCEDURE [Product].[uspGetPackaging]
    @p_id int = NULL,
    @p_productId int = NULL
AS
BEGIN;
    BEGIN TRANSACTION;

    BEGIN TRY;
        IF (ISNULL(@p_id, -1) = -1 AND ISNULL(@p_productId, -1) = -1) RAISERROR('At least one parameter is requiered', 16, 10) WITH LOG;
        

        SELECT Pac.Id, Pac.Unity, Pac.Quantity, Pac.GTIN, Pac.FromId, Pac.ProductId,
               Pac.ModifiedDate
        FROM Product.Packaging Pac
        WHERE Pac.Id = ISNULL(@p_id, Pac.Id)
          AND Pac.ProductId = ISNULL(@p_productId, Pac.ProductId);

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