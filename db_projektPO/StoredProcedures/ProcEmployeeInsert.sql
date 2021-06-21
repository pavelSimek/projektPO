CREATE PROCEDURE [dbo].[ProcEmployeeInsert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@PartyCode nvarchar(10),
	@PersonalEmail nvarchar(250),
	@Phone nvarchar(9),
	@PersonalPhone nvarchar(9),
    @WorkEmail nvarchar(250) NULL, 
    @WorkingTime DECIMAL(10,2) NULL, 
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
