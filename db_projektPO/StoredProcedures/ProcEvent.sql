CREATE PROCEDURE [dbo].[ProcEvent]
	@EventId INT
AS
	SELECT * FROM Event WHERE Id = @EventId;
