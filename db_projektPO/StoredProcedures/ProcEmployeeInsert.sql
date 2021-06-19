CREATE PROCEDURE [dbo].[ProcEmployeeInsert]
	@FirstName nchar(100),
	@LastName nchar(100),
	@PartyCode nchar(10),
	@PersonalEmail nchar(250),
	@Phone nchar(9),
    @WorkEmail NCHAR(250) NULL, 
    @WorkingTime DECIMAL(2) NULL, 
    @WorkingPoints INT NULL, 
    @WorkingPointsEN INT NULL, 
    @PhdStudent BIT NULL
AS
	INSERT INTO Employee (FirstName, LastName, PartyCode, PersonalEmail, Phone, WorkEmail, WorkingTime, WorkingPoints, WorkingPointsEN, PhdStudent)
	VALUES(
	@FirstName,
	@LastName,
	@PartyCode, 
	@PersonalEmail,
	@Phone,
    @WorkEmail, 
    @WorkingTime, 
    @WorkingPoints, 
    @WorkingPointsEN, 
    @PhdStudent
	)
