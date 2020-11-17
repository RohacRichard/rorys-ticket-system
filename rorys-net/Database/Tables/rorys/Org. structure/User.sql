CREATE TABLE [rorys].[User]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ActiveStatus] BIT NOT NULL, 
    [PersonId] BIGINT NOT NULL, 
    [OrgId] BIGINT NOT NULL, 
    [Username] NVARCHAR(255) NOT NULL, 
    [Password] NVARCHAR(511) NOT NULL

	CONSTRAINT [FK_User_ToOrganization] FOREIGN KEY ([OrgId]) REFERENCES [rorys].[Organization]([Id])
	CONSTRAINT [FK_User_ToPerson] FOREIGN KEY ([PersonId]) REFERENCES [rorys].[Person]([Id])
)
