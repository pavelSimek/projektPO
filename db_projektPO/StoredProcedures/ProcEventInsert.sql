CREATE PROCEDURE [dbo].[ProcEventInsert]
	@Name nvarchar(100),
	@EmployeeId INT = NULL,
	@SubjectId INT = NULL,
	@NumberOfStudents INT,
	@ScheduleEventType nvarchar(50),
    @Language nvarchar(5), 
    @Hours INT, 
    @Weeks INT,
	@Id INT,
	@Active BIT,
	@StudyGroupId INT = NULL
AS
	INSERT INTO Event(Name, EmployeeId, SubjectId, NumberOfStudents, ScheduleEventType, Hours, Weeks, Language, Active, StudyGroupId)
	VALUES(
	@Name,
	@EmployeeId,
	@SubjectId,
	@NumberOfStudents,
	@ScheduleEventType,
    @Hours, 
    @Weeks,
	@Language,
	@Active,
	@StudyGroupId)