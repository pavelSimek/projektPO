CREATE PROCEDURE [dbo].[ProcStudyGroupBySubject]
	@SubjectId INT
AS
	SELECT * From StudyGroup S 
	JOIN SubjectStudyGroup STG ON S.Id = STG.StudyGroupID 
	WHERE STG.SubjectID = @SubjectId

