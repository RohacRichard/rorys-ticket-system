CREATE TABLE [rorys.link].[LnkRoleToUser]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] BIGINT NOT NULL, 
    [RoleId] BIGINT NOT NULL

	CONSTRAINT [FK_LnkRoleToUser_LinkToRole] FOREIGN KEY ([RoleId]) REFERENCES [rorys.col].[Role]([Id])
	CONSTRAINT [FK_LnkRoleToUser_LinkToUser] FOREIGN KEY ([UserId]) REFERENCES [rorys].[User]([Id])
)
