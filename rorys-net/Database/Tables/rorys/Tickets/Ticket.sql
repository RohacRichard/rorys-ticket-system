CREATE TABLE [rorys].[Ticket]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [GenReference] VARCHAR(255) NOT NULL, 
    [TicketTypeId] BIGINT NOT NULL, 
    [OrgId] BIGINT NOT NULL, 
    [CallerId] BIGINT NOT NULL, 
    [SolverTeamId] BIGINT NULL, 
    [SolverId] BIGINT NULL, 
    [StatusId] BIGINT NOT NULL, 
    [Title] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [ResolveDate] DATETIME NULL, 
    [CloseDate] DATETIME NULL, 
    [TicketLog] NVARCHAR(MAX) NOT NULL, 
    [ResolutionId] BIGINT NULL, 
    [ResolutionDescription] NVARCHAR(MAX) NULL

	CONSTRAINT [FK_Ticket_ToOrganization] FOREIGN KEY ([OrgId]) REFERENCES [rorys].[Organization]([Id])
	CONSTRAINT [FK_Ticket_ToTicketType] FOREIGN KEY ([TicketTypeId]) REFERENCES [rorys.col].[TicketType]([Id])
	CONSTRAINT [FK_Ticket_ToPerson_Caller] FOREIGN KEY ([CallerId]) REFERENCES [rorys].[Person]([Id])
	CONSTRAINT [FK_Ticket_ToTeam] FOREIGN KEY ([SolverTeamId]) REFERENCES [rorys].[Team]([Id])
	CONSTRAINT [FK_Ticket_ToPerson_Solver] FOREIGN KEY ([SolverId]) REFERENCES [rorys].[Person]([Id])
	CONSTRAINT [FK_Ticket_ToStatus] FOREIGN KEY ([StatusId]) REFERENCES [rorys.col].[TicketStatus]([Id])
	CONSTRAINT [FK_Ticket_ToResolution] FOREIGN KEY ([ResolutionId]) REFERENCES [rorys.col].[Resolution]([Id])
)
