CREATE PROCEDURE [dbo].[ProcEventUpdate]
	@Name nvarchar(100),
	@EmployeeId INT,
	@SubjectId INT,
	@NumberOfStudents INT,
	@ScheduleEventType nvarchar(50),
    @Language nvarchar(2), 
    @Hours INT, 
    @Weeks INT,
	@Id INT
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
		Language = @Language
	WHERE Id = @Id