CREATE PROCEDURE [dbo].[ProcSubjectStudyGroupDelete]
	@StudyGroupID int ,
	@SubjectID int
AS
	DELETE FROM SubjectStudyGroup
	WHERE StudyGroupID = @StudyGroupID AND SubjectID = @SubjectID