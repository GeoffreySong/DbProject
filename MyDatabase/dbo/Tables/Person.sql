CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [MidName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Suffix] VARBINARY(50) NULL, 
    [DateOfBirth] DATETIME2(0) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [PrimaryPhone] VARCHAR(20) NULL, 
    [RowStatus] TINYINT NOT NULL, 
    [UpdatedBy] INT NOT NULL, 
    [UpdatedDate] DATETIME2(0) NOT NULL    
)
