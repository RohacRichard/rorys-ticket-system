CREATE TABLE [rorys.link].[LnkRoleToUser]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] BIGINT NOT NULL, 
    [RoleId] BIGINT NOT NULL

	CONSTRAINT [FK_LnkRoleToUser_LinkToRole] FOREIGN KEY ([RoleId]) REFERENCES [rorys.col].[Role]([Id])
	CONSTRAINT [FK_LnkRoleToUser_LinkToPerson] FOREIGN KEY ([PersonId]) REFERENCES [rorys].[Person]([Id])
)
