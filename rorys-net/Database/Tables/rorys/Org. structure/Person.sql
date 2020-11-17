CREATE TABLE [rorys].[Person]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ActiveStatus] BIT NOT NULL, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Surname] NVARCHAR(255) NOT NULL, 
    [Email] NVARCHAR(255) NULL, 
    [MobilePhone] NVARCHAR(255) NULL, 
    [Function] NVARCHAR(255) NULL, 
    [Picture] VARBINARY(MAX) NULL
)
