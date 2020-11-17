CREATE TABLE [rorys].[UserRequest]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY,
	[TicketId] BIGINT NOT NULL,
	[Priority] INT NOT NULL, 
    [Urgency] INT NOT NULL

	CONSTRAINT [FK_UserRequest_ToTicket] FOREIGN KEY ([TicketId]) REFERENCES [rorys].[Ticket]([Id]), 
    
)
