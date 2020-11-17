CREATE TABLE [rorys.col].[TicketStatus]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [TicketTypeId] BIGINT NOT NULL

	CONSTRAINT [FK_TicketStatus_ToTicketType] FOREIGN KEY ([TicketTypeId]) REFERENCES [rorys.col].[TicketType]([Id])
)
