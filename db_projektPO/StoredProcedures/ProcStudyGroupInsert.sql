CREATE PROCEDURE [dbo].[ProcStudyGroupInsert]
	@ShortName nvarchar(10),
	@Year INT,
	@Semester NVARCHAR(2),
    @Language nvarchar(2), 
    @NumberOfStudents INT, 
	@StudyType nvarchar(3),
	@StudyForm nvarchar(2),
	@Id INT
AS
	INSERT INTO StudyGroup(ShortName, Year, Semester, NumberOfStudents, StudyForm, StudyType, Language)
	VALUES(
	@ShortName,
	@Year,
	@Semester,
	@NumberOfStudents,
	@StudyForm,
	@StudyType,
    @Language)
