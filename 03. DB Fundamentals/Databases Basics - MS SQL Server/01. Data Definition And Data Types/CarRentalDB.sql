--14. Car Rental Database.
CREATE DATABASE CarRental

GO

USE CarRental

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName nvarchar(50) NOT NULL,
	DailyRate int,
	WeeklyRate int,
	MonthlyRate int NOT NULL,
	WeekendRate int
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Platenumber nvarchar(50) NOT NULL UNIQUE,
	Model nvarchar(255) NOT NULL,
	CarYear int NOT NULL,
	CategoryId nvarchar(255),
	Doors int,
	Picture ntext,
	Condition nvarchar(50) NOT NULL,
	Available INT NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Title nvarchar(255) NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	DriverLicenceNumber int NOT NULL UNIQUE,
	FullName nvarchar(255) NOT NULL,
	Address nvarchar(255),
	City nvarchar(255) NOT NULL,
	ZIPCode nvarchar(255),
	Notes nvarchar(255)
)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT NOT NULL UNIQUE,
	CustomerId INT NOT NULL UNIQUE,
	CarId INT NOT NULL,
	TankLevel INT,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT,
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied nvarchar(50),
	TaxRate nvarchar(50),
	OrderStatus nvarchar(255),
	Notes nvarchar(255)
)

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES
('Category1', 5, 3, 345, 2),
('Category2', 2, 2, 578, 5),
('Category3', 7, 5, 123, 2);

INSERT INTO Cars(Platenumber,Model,CarYear,CategoryId,Doors,Picture,Condition,Available)
VALUES
('1', 'Mercedes', 2018, NULL,4,NULL,'New', 1),
('2', 'Toyota', 2018, NULL,4,NULL,'New', 3),
('3', 'Audi', 2018, NULL,4,NULL,'New', 4);

INSERT INTO Employees(FirstName,LastName,Title,Notes)
VALUES
('Ivan', 'Ivanov', 'Manager', NULL),
('Pesho', 'Petrov', 'Salesman', NULL),
('Ivana', 'Ivanova', 'Receptionist', NULL);

INSERT INTO Customers(DriverLicenceNumber, FullName, Address,City,ZIPCode,Notes)
VALUES
(123,'Ivan Ivanov Ivanov', NULL, 'Sofia', NULL, NULL),
(322,'Pesho Peshov Petrov', NULL, 'Plovdiv', NULL, NULL),
(111,'Simona Simeonova Simienova', NULL, 'Varna', NULL, NULL);

INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId,TankLevel,KilometrageStart,KilometrageEnd,TotalKilometrage,StartDate,EndDate,TotalDays,RateApplied,TaxRate,OrderStatus,Notes)
VALUES
(1, 11, 1, NULL, 1111111, 434, 1231356, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, 22, 2, NULL, 222222, 53535, 85646, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(3, 33, 3, NULL, 33333, 46536, 315436, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
