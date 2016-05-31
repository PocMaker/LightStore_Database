CREATE TABLE [Product].[Product]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Code] VARCHAR(255) NOT NULL,
    [Label] VARCHAR(255) NOT NULL,
    [Unity] varchar(255),
    [Weight] decimal(12, 3),
    [Tare] decimal(12, 3),
    [GTIN] varchar(255),
    [ModifiedDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [Application] VARCHAR(255) NOT NULL DEFAULT APP_NAME(),
    CONSTRAINT [CK_Product_Unity] CHECK (Product.ufnCheckUnityValue(Unity) = 1)
)

GO

CREATE UNIQUE INDEX [UX_Product-Code] ON [Product].[Product] ([Code])

GO
