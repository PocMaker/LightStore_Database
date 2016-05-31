CREATE TABLE [Administration].[Operator]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [FirstName] VARCHAR(255) NOT NULL,
    [LastName] VARCHAR(255) NOT NULL,
    [Login] VARCHAR(255) NOT NULL,
    [Salt] varchar(255),
    [Password] VARBINARY(255) NULL,
    [Email] varchar(255), 
    [ModifiedDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Application] VARCHAR(255) NOT NULL DEFAULT APP_NAME()
);

GO

CREATE UNIQUE INDEX [UX_Operator_Login] ON [Administration].[Operator] ([Login]) ON MAIN_INDEX;

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Operator''s firstname',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'FirstName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Operator''s lastname',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'LastName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Operator''s login',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Login'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Random data used as an additional input to a one-way function that "hashes" a password',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Salt'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Hash password containing clear password and salt',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Password'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Main operator''s email',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Email'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Last complete time when record has been updated',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'ModifiedDate'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Last application name wich has been updated record',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Application'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Unique autoincremental Id to identify an operator',
    @level0type = N'SCHEMA',
    @level0name = N'Administration',
    @level1type = N'TABLE',
    @level1name = N'Operator',
    @level2type = N'COLUMN',
    @level2name = N'Id'