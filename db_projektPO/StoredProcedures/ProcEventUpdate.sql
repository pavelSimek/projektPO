CREATE PROCEDURE [dbo].[ProcEventUpdate]
	@Name nvarchar(100),
	@EmployeeId INT = NULL,
	@SubjectId INT = NULL,
	@NumberOfStudents INT,
	@ScheduleEventType nvarchar(50),
    @Language nvarchar(2), 
    @Hours INT, 
    @Weeks INT,
	@Id INT,
	@Active BIT,
	@StudyGroupId INT = NULL
AS
	UPDATE Event 
	SET 
		Name = @Name,
		EmployeeId = @EmployeeId,
		SubjectId = @SubjectId, 
		NumberOfStudents = @NumberOfStudents, 
		ScheduleEventType = @ScheduleEventType,  
		Hours = @Hours, 
		Weeks = @Weeks , 
		Language = @Language,
		Active = @Active,
		StudyGroupId = @StudyGroupId
	WHERE Id = @Id