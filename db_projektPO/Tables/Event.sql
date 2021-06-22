CREATE TABLE [dbo].[Event]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(100) NULL, 
    [EmployeeId] INT NULL, 
    [SubjectId] INT NULL, 
    [NumberOfStudents] INT NULL, 
    [ScheduleEventType] NVARCHAR(50) NULL, 
    [Hours] INT NULL, 
    [Weeks] INT NULL,
    [Language] NVARCHAR(2) NULL
)
