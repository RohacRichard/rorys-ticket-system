CREATE TABLE [rorys].[Organization]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ActiveStatus] BIT NOT NULL, 
    [Name] NVARCHAR(255) NOT NULL, 
    [ParentId] BIGINT NOT NULL

	CONSTRAINT [FK_ChildOrg_ToParentOrg] FOREIGN KEY ([ParentId]) REFERENCES [rorys].[Organization]([Id])
)
