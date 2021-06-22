CREATE PROCEDURE [dbo].[ProcEventDelete]
	@Id INT
AS
	DELETE FROM Event
	WHERE Id = @Id
