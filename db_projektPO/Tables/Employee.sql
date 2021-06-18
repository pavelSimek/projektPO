CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(100) NULL, 
    [LastName] NCHAR(100) NULL, 
    [PartyCode] NCHAR(10) NULL, 
    [Email] NCHAR(250) NULL, 
    [Phone] NCHAR(9) NULL
)
