CREATE TABLE [Product].[Packaging]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Unity] VARCHAR(255) NOT NULL,
    [Quantity] INT NOT NULL,
    [FromId] INT NULL,
    [GTIN] VARCHAR(255) NULL,
    [ProductId] INT NOT NULL,
    [ModifiedDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [Application] VARCHAR(255) NOT NULL DEFAULT APP_NAME(),
    CONSTRAINT [FK_Packaging_Packaging] FOREIGN KEY ([FromId]) REFERENCES [Product].[Packaging]([Id]),
    CONSTRAINT [FK_Packaging_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product].[Product]([Id]),
    CONSTRAINT [CK_Packaging_Unity] CHECK (Product.ufnCheckUnityValue(Unity) = 1)
)
