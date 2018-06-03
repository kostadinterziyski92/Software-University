--01. Find All Information About Departments.
SELECT *
FROM Departments

--02. Find All Department Names.
SELECT Name
FROM Departments

--3. Find Salary of Each Employee.
SELECT FirstName, LastName, Salary
FROM Employees

--4. Find Full Name of Each Employee.
SELECT FirstName, MiddleName, LastName
FROM Employees

--5. Find Email Address of Each Employee.
SELECT FirstName + LastName + '@softuni.bg' AS [Full Email Address]
FROM Employees

--06. Find All Different Employee's Salaries.
SELECT DISTINCT Salary 
FROM Employees

--07. Find All Information About Employees.
SELECT * 
FROM Employees
WHERE JobTitle = 'Sales Representative'

--08. Find Names of All Employees by Salary in Range.
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

--09. Find Names of All Employees.
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name]
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

--10. Find All Employees Without Manager.
SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL

--11. Find All Employees with Salary more than 50000.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--12. Find 5 Best Paid Employess.
SELECT TOP(5) FirstName, LastName
FROM Employees
ORDER BY Salary DESC

--13. Find All Employees Except Marketing.
SELECT FirstName, LastName
FROM Employees
WHERE DepartmentID != 4

--14. Sort Employees Table.
SELECT *
FROM Employees
ORDER BY Salary DESC, FirstName, LastName DESC, MiddleName

--15. Create View Employees with Salaries
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName, LastName, Salary
FROM Employees

--16. Create View Employees with Job Titles.
CREATE VIEW V_EmployeesJobTitles AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle AS [Job Title]
FROM Employees

--17. Distinct Job Titles.
SELECT DISTINCT JobTitle
FROM Employees

--18. Find First 10 Started Projects.
SELECT TOP(10) *
FROM Projects
ORDER BY StartDate, Name

--19. Last 7 Hired Employess.
SELECT TOP(7) FirstName, LastName, HireDate
FROM Employees
ORDER BY HireDate DESC

--20. Increase Salaries.
UPDATE Employees
SET Salary= Salary * 1.12
WHERE DepartmentID IN (1,2,4,11)

--21. All Mountain Peaks
USE Geography
SELECT PeakName 
FROM Peaks
ORDER BY PeakName

--22. Biggest Countries by Population.
SELECT TOP (30) CountryName, Population 
FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY Population DESC, CountryName

--23. Countries and Currency (Euro/Not Euro)
SELECT CountryName, CountryCode, 
CASE CurrencyCode
	WHEN 'EUR' THEN 'Euro'
	ELSE 'Not Euro'
END AS Currency 
FROM Countries
ORDER BY CountryName

--24. All Diablo Characters
USE Diablo
SELECT Name 
FROM  Characters
ORDER BY Name

