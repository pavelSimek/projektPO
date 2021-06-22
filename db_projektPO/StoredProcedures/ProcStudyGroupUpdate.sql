CREATE PROCEDURE [dbo].[ProcStudyGroupUpdate]
	@ShortName nvarchar(10),
	@Year INT,
	@Semester NVARCHAR(2),
    @Language nvarchar(2), 
    @NumberOfStudents INT, 
	@StudyType nvarchar(3),
	@StudyForm nvarchar(2),
	@Id INT
AS
	UPDATE StudyGroup
	SET 
	ShortName = @ShortName, 
	Year = @Year, 
	Semester = @Semester, 
	NumberOfStudents = @NumberOfStudents, 
	StudyForm = @StudyForm, 
	StudyType = @StudyType, 
	Language = @Language
	WHERE Id = @Id