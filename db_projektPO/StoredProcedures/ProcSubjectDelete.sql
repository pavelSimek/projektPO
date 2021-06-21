CREATE PROCEDURE [dbo].[ProcSubjectDelete]
	@Id INT
AS
	DELETE FROM Subject
	WHERE Id = @Id