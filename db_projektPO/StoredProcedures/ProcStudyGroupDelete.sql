CREATE PROCEDURE [dbo].[ProcStudyGroupDelete]
@Id INT
AS
DELETE FROM StudyGroup 
WHERE Id = @Id

DELETE FROM Event
WHERE StudyGroupId = @Id