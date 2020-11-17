CREATE TABLE [rorys.link].[LnkTeamToPerson]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamId] BIGINT NOT NULL, 
    [PersonId] BIGINT NOT NULL

	CONSTRAINT [FK_LnkTeamToPerson_LinkToTeam] FOREIGN KEY ([TeamId]) REFERENCES [rorys].[Team]([Id])
	CONSTRAINT [FK_LnkTeamToPerson_LinkToPerson] FOREIGN KEY ([PersonId]) REFERENCES [rorys].[Person]([Id])
)
