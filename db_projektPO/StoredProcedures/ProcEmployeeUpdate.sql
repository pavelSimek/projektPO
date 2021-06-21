CREATE PROCEDURE [dbo].[ProcEmployeeUpdate]
	@Id INT,
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@PartyCode nvarchar(10),
	@PersonalEmail nvarchar(250),
	@Phone nvarchar(9),
    @WorkEmail nvarchar(250) NULL, 
	@PersonalPhone nvarchar(9),
    @WorkingTime DECIMAL(10,2) NULL, 
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
	PersonalPhone = @PersonalPhone
	WHERE Id = @Id