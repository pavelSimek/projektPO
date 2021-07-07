﻿CREATE PROCEDURE [dbo].[ProcEventInsert]
	@Name nvarchar(100),
	@EmployeeId INT,
	@SubjectId INT,
	@NumberOfStudents INT,
	@ScheduleEventType nvarchar(50),
    @Language nvarchar(5), 
    @Hours INT, 
    @Weeks INT,
	@Id INT,
	@Active BIT
AS
	INSERT INTO Event(Name, EmployeeId, SubjectId, NumberOfStudents, ScheduleEventType, Hours, Weeks, Language, Active)
	VALUES(
	@Name,
	@EmployeeId,
	@SubjectId,
	@NumberOfStudents,
	@ScheduleEventType,
    @Hours, 
    @Weeks,
	@Language,
	@Active)