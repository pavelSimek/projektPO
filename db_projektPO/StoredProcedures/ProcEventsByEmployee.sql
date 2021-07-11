CREATE PROCEDURE [dbo].[ProcEventsByEmployee]
	@EmployeeId INT
AS
	SELECT * FROM Event WHERE EmployeeId = @EmployeeId
