--01. Find Names of All Employees by First Name.
SELECT FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'Sa%'

--02. Find Names of All employees by Last Name.
SELECT FirstName, LastName
FROM Employees
WHERE LastName LIKE '%ei%'

--03. Find First Names of All Employees.
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3, 10) AND YEAR(HireDate) BETWEEN 1995 AND 2006

--04. Find All Employees Except Engineers.
SELECT FirstName, LastName 
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'

--05. Find Towns with Name Lenght.
SELECT Name
FROM Towns
WHERE LEN(Name) = 5 OR LEN(Name) = 6
ORDER BY Name

--06. Find Towns Starting With.
SELECT TownID, Name 
FROM Towns
WHERE Name LIKE 'M%' OR Name LIKE 'K%' OR Name LIKE 'B%' OR Name LIKE'E%'
ORDER BY Name

--07. Find Towns Not Starting With.
SELECT TownID, Name FROM Towns
WHERE Name NOT LIKE 'R%' AND Name NOT LIKE 'B%' AND Name NOT LIKE 'D%'
ORDER BY Name

--08. Create View Employees Hired After 2000 Year.
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
FROM Employees
WHERE HireDate > '2001'

--09. Length of Last Name.
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

--10. Countries Holding 'A' 3 or More Times.
SELECT CountryName, IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

--11. Mix of Peak and River Names.
SELECT PeakName, RiverName, 
LOWER(PeakName + RIGHT(RiverName, LEN(RiverName) -1 )) AS 'Mix' 
FROM Rivers, Peaks
WHERE RIGHT(PeakName,1) = LEFT(RiverName,1)
ORDER BY Mix

--12. Games from 2011 and 2012 year.
SELECT TOP(50) Name, FORMAT(Start,'yyyy-MM-dd') AS Start 
FROM Games
WHERE YEAR(Start) BETWEEN 2011 AND 2012
ORDER BY Start, Name

--13. User Email Providers.
SELECT Username, RIGHT(Email, LEN(Email) - CHARINDEX('@',Email)) AS 'Email Provider' 
FROM Users
ORDER BY [Email Provider], Username

--14. Get Users with IPAdress Like Pattern
SELECT Username, IpAddress FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username

--15. Show All Games with Duration and Part of the Day.
SELECT G.Name AS Game,
CASE 
WHEN DATEPART(HOUR,G.Start) BETWEEN 0 AND 11 THEN 'Morning'
WHEN DATEPART(HOUR,G.Start) BETWEEN 12 AND 17 THEN 'Afternoon'
WHEN DATEPART(HOUR,G.Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
WHEN G.Duration <=3 THEN 'Extra Short'
WHEN G.Duration Between 4 AND 6 THEN 'Short'
WHEN G.Duration >6 THEN 'Long'
ELSE 'Extra Long'
END as [Duration]
FROM Games as G
ORDER BY G.Name, [Duration], [Part of the Day]

--16. Orders Table
SELECT ProductName, OrderDate,
DATEADD(DAY, 3, OrderDate) AS [Pay Due],
DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
FROM Orders