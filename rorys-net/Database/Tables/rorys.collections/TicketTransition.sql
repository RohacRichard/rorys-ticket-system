CREATE TABLE [rorys.col].[TicketTransition]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [StatusFromId] BIGINT NOT NULL, 
    [StatusToId] BIGINT NOT NULL, 
    [TicketTypeId] BIGINT NOT NULL

	CONSTRAINT [FK_StatusFrom_ToTicketStatus] FOREIGN KEY ([StatusFromId]) REFERENCES [rorys.col].[TicketStatus]([Id])
	CONSTRAINT [FK_StatusTo_ToTicketStatus] FOREIGN KEY ([StatusToId]) REFERENCES [rorys.col].[TicketStatus]([Id])
	CONSTRAINT [FK_TicketTransition_ToTicketType] FOREIGN KEY ([TicketTypeId]) REFERENCES [rorys.col].[TicketType]([Id])
)
