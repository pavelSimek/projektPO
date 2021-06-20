CREATE PROCEDURE [dbo].[ProcEmployeeInsert]
	@FirstName nchar(100),
	@LastName nchar(100),
	@PartyCode nchar(10),
	@PersonalEmail nchar(250),
	@Phone nchar(9),
	@PersonalPhone nchar(9),
    @WorkEmail NCHAR(250) NULL, 
    @WorkingTime DECIMAL(2) NULL, 
    @PhdStudent BIT NULL,
	@Id INT

AS
	INSERT INTO Employee (FirstName, LastName, PartyCode, PersonalEmail, Phone, WorkEmail, WorkingTime, PhdStudent, PersonalPhone)
	VALUES(
	@FirstName,
	@LastName,
	@PartyCode, 
	@PersonalEmail,
	@Phone,
    @WorkEmail, 
    @WorkingTime, 
    @PhdStudent,
	@PersonalPhone)
