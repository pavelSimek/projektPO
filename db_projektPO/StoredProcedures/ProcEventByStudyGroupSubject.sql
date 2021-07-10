CREATE PROCEDURE [dbo].[ProcEventByStudyGroupSubject]
	@StudyGroupId int,
	@SubjectId int
	AS
SELECT * FROM Event
WHERE (@StudyGroupId IS NULL OR StudyGroupId = @StudyGroupId)
 AND (@SubjectId IS NULL OR SubjectId = @SubjectId)