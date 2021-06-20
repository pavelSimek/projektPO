CREATE PROCEDURE [dbo].[ProcEmployeeUpdate]
	@Id INT,
	@FirstName nchar(100),
	@LastName nchar(100),
	@PartyCode nchar(10),
	@PersonalEmail nchar(250),
	@Phone nchar(9),
    @WorkEmail NCHAR(250) NULL, 
	@PersonalPhone NCHAR(9),
    @WorkingTime DECIMAL(2) NULL, 
    @PhdStudent BIT NULL
AS
	UPDATE Employee SET
	FirstName = @FirstName,
	LastName = @LastName,
	PartyCode = @PartyCode, 
	PersonalEmail = @PersonalEmail,
	Phone = @Phone,
    WorkEmail = @WorkEmail, 
    WorkingTime = @WorkingTime, 
    PhdStudent = @PhdStudent,
	PersonalPhone = @WorkingTime
	WHERE Id = @Id