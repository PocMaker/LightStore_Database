---<summary>
---Insert a new operator in database
---</summary>
---<param name="@p_firstName" ref="Administration.Operator.FirstName"/>
---<param name="@p_lastName" ref="Administration.Operator.LastName"/>
---<param name="@p_login" ref="Administration.Operator.Login"/>
---<param name="@p_email" ref="Administration.Operator.Email"/>
---<exception cref="SqlException">Severity 16
---     State 10 : Firstname cannot be EMPTY
---     State 11 : Lastname cannot be EMPTY
---     State 12 : Login cannot be EMPTY
---     State 13 : Login already exists
---     State 255 : Error while creating operator
---</exception>     
---<return>1 if success, 0 otherwise</return>
CREATE PROCEDURE [Administration].[uspCreateOperator]
    @p_firstName varchar(255),
    @p_lastName varchar(255),
    @p_login varchar(255),
    @p_email varchar(255) = NULL
AS
BEGIN;
    DECLARE @Rc int,
            @Id int;

    BEGIN TRANSACTION;

    BEGIN TRY;
        IF (RTRIM(LTRIM(ISNULL(@p_firstName, ''))) = '') RAISERROR('FirstName cannot be EMPTY', 16, 10) WITH LOG;
        IF (RTRIM(LTRIM(ISNULL(@p_lastName, ''))) = '') RAISERROR('LastName cannot be EMPTY', 16, 11) WITH LOG;
        IF (RTRIM(LTRIM(ISNULL(@p_login, ''))) = '') RAISERROR('Login cannot be EMPTY', 16, 12) WITH LOG;
        IF (EXISTS(SELECT TOP 1 1 FROM Administration.Operator WHERE Login = @p_login)) RAISERROR('Login already exists', 16, 13) WITH LOG;

        -- Generate the salt
        DECLARE @LCV tinyint = 1,
                @CTime datetime = GETDATE(),
                @Seed int;

        SET @Seed = (DATEPART(hh, @Ctime) * 10000000) + (DATEPART(n, @CTime) * 100000) + (DATEPART(s, @CTime) * 1000) + DATEPART(ms, @CTime);
            
        DECLARE @Salt varchar(25) = CHAR(ROUND((RAND(@Seed) * 94.0) + 32, 3));

        WHILE (@LCV < 25)
        BEGIN;
            SET @Salt = @Salt + CHAR(ROUND((RAND() * 94.0) + 32, 3));
            SET @LCV = @LCV + 1;
        END;

        --Create operator
        INSERT INTO Administration.Operator(FirstName, LastName, Login, Email, Salt)
        VALUES(@p_firstname, @p_lastname, @p_login, @p_email, @Salt);

        SELECT @Rc = @@ROWCOUNT, @Id = @@IDENTITY;

        IF (@Rc != 1) RAISERROR('Error while create operator', 16, 255) WITH LOG;

        EXEC Administration.uspGetOperator @p_id = @Id;

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
