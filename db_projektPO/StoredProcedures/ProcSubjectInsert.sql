CREATE PROCEDURE [dbo].[ProcSubjectInsert]
	@ShortName nvarchar(10),
	@Name nvarchar(50),
	@LectureHours INT,
	@ExerciseHours INT,
	@SeminarHours INT,
	@EndType nvarchar(5),
    @Language nvarchar(5), 
    @ClassSize INT, 
    @Credits INT,
	@GuaranteeingInstitute nvarchar(10),
	@GuarantorName nvarchar(200),
	@Weeks INT,
	@Id INT
AS
	INSERT INTO Subject(ShortName, Name, LectureHours, ExerciseHours, SeminarHours, EndType, Language, ClassSize, Credits, GuaranteeingInstitute, GuarantorName, Weeks)
	VALUES(
	@ShortName,
	@Name,
	@LectureHours,
	@ExerciseHours,
	@SeminarHours,
	@EndType,
    @Language,
    @ClassSize, 
    @Credits,
	@GuaranteeingInstitute,
	@GuarantorName,
	@Weeks)
