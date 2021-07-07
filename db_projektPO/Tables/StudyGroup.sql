CREATE TABLE [dbo].[StudyGroup]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[ShortName] NVARCHAR(10) NULL, 
    [Year] INT NULL, 
    [Semester] NVARCHAR(2) NULL, 
    [NumberOfStudents] INT NULL, 
    [StudyForm] NVARCHAR(2) NULL, 
    [StudyType] NVARCHAR(3) NULL, 
    [Language] NVARCHAR(2) NULL, 
    [Name] NVARCHAR(100) NULL
)
