---<summary>
---Check if provided login and clear password match
---</summary>
---<param name="@p_login" ref="Administration.Operator.Login"/>
---<param name="@p_password">Clear password to check</param>
---<exception cref="SqlException">Severity 16
---     State 10 : Login and password does not match (login unfound)
---     State 11 : Login and password does not match (password do not match)
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Administration].[uspLoginOperator]
    @p_login varchar(255),
    @p_password varchar(255)
AS
BEGIN;
    BEGIN TRY;
        
        DECLARE @Id int,
                @Salt varchar(255),
                @Password varbinary(255);
        
        SELECT @Id = Ope.Id, @Salt = Ope.Salt, @Password = Ope.Password
        FROM Administration.Operator Ope
        WHERE Ope.Login = @p_login;
        
        IF (@@ROWCOUNT != 1) RAISERROR('Login and password does not match', 16, 10);

        DECLARE @control varbinary(255) = HASHBYTES('SHA2_256', @Salt + @p_password);

        IF (@Password IS NOT NULL OR ISNULL(@p_password, '') != '')
            IF (@control != ISNULL(@Password, 0)) RAISERROR('Login and password does not match', 16, 11);;

        EXEC Administration.uspGetOperator @p_id = @Id;

        RETURN @@ROWCOUNT;

    END TRY
    BEGIN CATCH;
        DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE(),
                @ErrorSeverity int = ERROR_SEVERITY(),
                @ErrorState int = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);

        RETURN 0; -- indicate failure
    END CATCH;
END;