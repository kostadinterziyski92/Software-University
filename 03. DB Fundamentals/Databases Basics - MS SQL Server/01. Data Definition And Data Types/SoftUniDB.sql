--17. Create SoftUni Database.
CREATE DATABASE SoftUni1

GO

USE SoftUni1

CREATE TABLE Towns
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)

CREATE TABLE Addresses
(
	Id INT IDENTITY PRIMARY KEY,
	AddressText NVARCHAR(200),
	TownId INT,
	CONSTRAINT FK_Addresses_Towns FOREIGN KEY (TownId) REFERENCES Towns(Id)
)

CREATE TABLE Departments
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50)
)

CREATE TABLE Employees
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(50),
	MiddleName NVARCHAR(50),
	LastName NVARCHAR(50),
	JobTitle VARCHAR(50),
	DepartmentId INT,
	HireDate DATE,
	Salary DECIMAL,
	AddressId INT,
	CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
	CONSTRAINT FK_Employees_Addresses FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
)

INSERT INTO Employees(FirstName, MiddleName, LastName,JobTitle,DepartmentId,HireDate,Salary,AddressId)
VALUES
('Ivan','Ivanov','Ivanov', '.NET DEVELOPER', 'Software Development', '01/02/2013', 3500, NULL),
('Petar','Petrov','Petrov', 'Senior Engineer', 'Engineering', '02/03/2004', 4000, NULL),
('Maria','Petrova','Ivanova', 'Intern', 'Quality Assurance', '28/08/2016', 525.25, NULL),
('Georgi','Terziev','Ivanov', 'CEO', 'Sales', '09/12/2007', 3000, NULL),
('Peter','Pan','Pan', 'Intern', 'Marketing', '28/08/2016', 599.88, NULL);

--18. Basic Select All Fields.
SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

--19. Basic Select All Fields and Order Them.
SELECT * FROM Towns
ORDER BY Name

SELECT * FROM Departments
ORDER BY Name

SELECT * FROM Employees
ORDER BY Salary DESC

--20. Basic Select Some Fields.
SELECT Name FROM Towns ORDER BY Name

SELECT Name FROM Departments ORDER BY Name

SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC

--21. Increase Employees Salary.
UPDATE Employees
SET Salary += Salary * 0.1

SELECT Salary FROM Employees

--22. Decrease Tax Rate.
UPDATE Payments
SET TaxRate-=TaxRate*3/100
SELECT TaxRate FROM Payments

--23. Delete All Records.
TRUNCATE TABLE Occupancies