CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [FirstName] NVARCHAR(100) NULL, 
    [LastName] NVARCHAR(100) NULL, 
    [PartyCode] NVARCHAR(10) NULL, 
    [PersonalEmail] NVARCHAR(250) NULL, 
    [Phone] NVARCHAR(9) NULL, 
    [WorkEmail] NVARCHAR(250) NULL, 
    [WorkingTime] DECIMAL(10, 2) NULL, 
    [PhdStudent] BIT NULL, 
    [PersonalPhone] NVARCHAR(9) NULL
)
