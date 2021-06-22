CREATE PROCEDURE [dbo].[ProcEmployeeExists]
@PartyCode NVARCHAR(10),
@Id INT
AS 
SELECT 
E.FirstName, 
E.LastName,
E.Id
FROM Employee E
WHERE E.PartyCode = @PartyCode
AND @Id != E.Id
