CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [FirstName] NCHAR(100) NULL, 
    [LastName] NCHAR(100) NULL, 
    [PartyCode] NCHAR(10) NULL, 
    [PersonalEmail] NCHAR(250) NULL, 
    [Phone] NCHAR(9) NULL, 
    [WorkEmail] NCHAR(250) NULL, 
    [WorkingTime] DECIMAL(2) NULL, 
    [PhdStudent] BIT NULL, 
    [PersonalPhone] NCHAR(9) NULL
)
