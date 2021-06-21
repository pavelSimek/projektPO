CREATE PROCEDURE [dbo].[ProcSubjectUpdate]
	@Id INT,
	@ShortName nvarchar(10),
	@Name nvarchar(50),
	@LectureHours INT,
	@ExerciseHours INT,
	@SeminarHours INT,
	@EndType nvarchar(5),
    @Language nvarchar(5), 
    @ClassSize INT, 
    @Credits INT,
	@GuaranteeingInstitute INT,
	@GuarantorName nvarchar(200),
	@Weeks INT

AS
	UPDATE Subject
	SET 
	ShortName = @ShortName,
	Name = @Name,
	LectureHours = @LectureHours,
	ExerciseHours = @ExerciseHours,
	SeminarHours = @SeminarHours,
	EndType = @EndType,
	Language = @Language,
	ClassSize = @ClassSize,
	Credits=@Credits,
	GuaranteeingInstitute = @GuaranteeingInstitute,
	GuarantorName=@GuarantorName,
	Weeks=@Weeks
	WHERE Id = @Id