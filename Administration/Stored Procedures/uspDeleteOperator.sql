CREATE PROCEDURE [Administration].[uspDeleteOperator]
    @p_id int
AS
BEGIN;
    BEGIN TRANSACTION;

    BEGIN TRY;
        DELETE Administration.Operator WHERE Id = @p_id;

        IF (@@ROWCOUNT != 1)
        BEGIN;
            DECLARE @error varchar(255) = 'Operator "' + CAST(@p_id AS varchar) + '" does no longer exist';
            RAISERROR(@error, 16, 255) WITH LOG;
        END;

        COMMIT TRANSACTION;

        RETURN 1;

    END TRY
    BEGIN CATCH;
        DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE(),
                @ErrorSeverity int = ERROR_SEVERITY(),
                @ErrorState int = ERROR_STATE();

        ROLLBACK TRANSACTION;

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);

        RETURN 0; -- indicate failure
    END CATCH;

END;