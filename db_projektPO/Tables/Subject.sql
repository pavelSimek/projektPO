CREATE TABLE [dbo].[Subject]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [ShortName] NVARCHAR(10) NULL, 
    [Name] NVARCHAR(50) NULL, 
    [LectureHours] INT NULL, 
    [ExerciseHours] INT NULL, 
    [SeminarHours] INT NULL, 
    [EndType] NVARCHAR(5) NULL, 
    [Language] NVARCHAR(5) NULL, 
    [ClassSize] INT NULL, 
    [Credits] INT NULL, 
    [GuaranteeingInstitute] INT NULL, 
    [GuarantorName] NVARCHAR(200) NULL, 
    [Weeks] NCHAR(10) NULL
)
