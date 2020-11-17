CREATE TABLE [rorys].[Team]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ActiveStatus] BIT NOT NULL, 
    [Name] NVARCHAR(255) NOT NULL, 
    [OrgId] BIGINT NOT NULL

	CONSTRAINT [FK_Team_ToOrganization] FOREIGN KEY ([OrgId]) REFERENCES [rorys].[Organization]([Id])
)
