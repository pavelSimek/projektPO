CREATE PROCEDURE [dbo].[ProcSubjectStudyGroup]
	@StudyGroupId INT = NULL,
	@SubjectId INT = NULL
AS
	SELECT 
	StudyGroupID, SubjectID 
	FROM SubjectStudyGroup
	WHERE (@StudyGroupId IS NULL OR StudyGroupID = @StudyGroupId) 
	AND (@SubjectId IS NULL OR SubjectID = @SubjectId)
