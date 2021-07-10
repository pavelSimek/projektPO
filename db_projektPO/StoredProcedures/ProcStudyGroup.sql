CREATE PROCEDURE [dbo].[ProcStudyGroup]
@Id INT
AS
	SELECT * FROM StudyGroup
	WHERE Id = @Id
