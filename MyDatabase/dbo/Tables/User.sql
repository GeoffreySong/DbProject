CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Person_Id] INT NOT NULL,
    [LoginId] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [RowStatus] TINYINT NOT NULL, 
    [UpdatedBy] INT NOT NULL, 
    [UpdatedDate] DATETIME2(7) NOT NULL, 
    CONSTRAINT [FK_User_Person] FOREIGN KEY ([Person_Id]) REFERENCES [Person]([Id])
)

GO
