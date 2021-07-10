CREATE PROCEDURE [dbo].[ProcSubject]
	@Id INT
AS
SELECT * FROM Subject
WHERE Id = @Id
