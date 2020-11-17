CREATE TABLE [rorys].[Incident]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketId] BIGINT NOT NULL, 
    [PossibleCyberIncident] BIT NOT NULL, 
    [PossibleGDPRIncident] BIT NOT NULL, 
    [AffectedSystemsCount] INT NOT NULL, 
    [AffectedUsersCount] INT NOT NULL

	CONSTRAINT [FK_Incident_ToTicket] FOREIGN KEY ([TicketId]) REFERENCES [rorys].[Ticket]([Id])
)
