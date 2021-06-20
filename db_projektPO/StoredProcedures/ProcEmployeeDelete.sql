CREATE PROCEDURE [dbo].[ProcEmployeeDelete]
	@Id INT
AS
	DELETE FROM Employee
	WHERE Id = @Id