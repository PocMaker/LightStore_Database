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
