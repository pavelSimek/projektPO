CREATE PROCEDURE [dbo].[ProcSubjectStudyGroupDelete]
	@StudyGroupID int = NULL ,
	@SubjectID int = NULL
AS
	DELETE FROM SubjectStudyGroup
	WHERE (@StudyGroupID IS NULL OR StudyGroupID = @StudyGroupID)
	AND (@SubjectID IS NULL OR SubjectID = @SubjectID)