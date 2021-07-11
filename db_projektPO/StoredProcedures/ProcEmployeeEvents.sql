CREATE PROCEDURE [dbo].[ProcEmployeeEvents]
	@EmployeeId INT
AS
	SELECT ScheduleEventType, Hours, NumberOfStudents, Language, Active FROM Event
	WHERE EmployeeId= @EmployeeId
