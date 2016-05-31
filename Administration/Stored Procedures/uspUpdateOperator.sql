---<summary>
---Insert a new operator in database
---</summary>
---<param name="@p_id" ref="Administration.Operator.Id"/>
---<param name="@p_firstName" ref="Administration.Operator.FirstName"/>
---<param name="@p_lastName" ref="Administration.Operator.LastName"/>
---<param name="@p_email" ref="Administration.Operator.Email"/>
---<param name="@p_password">Clear password to replace the actual one</param>
---<exception cref="SqlException">Severity 16
---     State 10 : Firstname cannot be EMPTY
---     State 11 : Lastname cannot be EMPTY
---     State 12 : Operator <paramref name="@p_id"/> does no longer exist
---     State 255 : Error while updating operator
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Administration].[uspUpdateOperator]
    @p_id int,
    @p_firstName varchar(255) = NULL,
    @p_lastName varchar(255) = NULL,
    @p_email varchar(255) = NULL,
    @p_password varchar(255) = NULL
AS
BEGIN;
    BEGIN TRANSACTION;

    BEGIN TRY;
        IF (RTRIM(LTRIM(@p_firstName)) = '') RAISERROR('FirstName cannot be EMPTY', 16, 10) WITH LOG;
        IF (RTRIM(LTRIM(@p_lastName)) = '') RAISERROR('LastName cannot be EMPTY', 16, 11) WITH LOG;
        IF (NOT EXISTS(SELECT TOP 1 1 FROM Administration.Operator WHERE Id = @p_id))
        BEGIN;
            DECLARE @error varchar(255) = 'Operator "' + CAST(@p_id AS varchar) + '" does no longer exist';
            RAISERROR(@error, 16, 12) WITH LOG;
        END;

        UPDATE Administration.Operator
            SET FirstName = ISNULL(@p_firstName, FirstName),
                LastName = ISNULL(@p_lastName, LastName),
                Email = CASE WHEN @p_email IS NULL THEN Email
                             WHEN @p_email = '' THEN NULL 
                             ELSE @p_email
                        END,
                Password = CASE WHEN @p_password IS NULL THEN Password
                                WHEN @p_password = '' THEN NULL 
                                ELSE HASHBYTES('SHA2_256', Salt + @p_password)
                            END,
                ModifiedDate = GETDATE()
        WHERE Id = @p_id;

        IF (@@ROWCOUNT != 1) RAISERROR('Error while updating Operator', 16, 255) WITH LOG;

        EXEC Administration.uspGetOperator @p_id = @p_id;

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
