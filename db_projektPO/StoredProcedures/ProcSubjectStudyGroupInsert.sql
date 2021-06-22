CREATE PROCEDURE [dbo].[ProcSubjectStudyGroupInsert]
	@StudyGroupID int ,
	@SubjectID int
AS
	Insert INTO SubjectStudyGroup (StudyGroupID, SubjectID)
	Values (@StudyGroupID, @SubjectID)
