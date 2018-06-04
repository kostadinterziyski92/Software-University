--15. Create Hotel Database.
CREATE DATABASE Hotel

GO

USE Hotel

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50),
	Title nvarchar(50) NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	PhoneNumber INT,
	EmergencyName nvarchar(255),
	EmergencyNumber INT NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE RoomStatus
(
	RoomType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE RoomTypes
(
	RoomType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)


CREATE TABLE BedTypes
(
	BedType nvarchar(50) PRIMARY KEY NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY IDENTITY(1,1),
	RoomType nvarchar(50) NOT NULL,
	BedType nvarchar(50) NOT NULL,
	Rate nvarchar(50),
	RoomStatus nvarchar(50),
	Notes nvarchar(255)
)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT UNIQUE NOT NULL,
	PaymentDate date,
	AccountNumber INT NOT NULL,
	FirstDateOccupied date,
	LastDateOccupied date,
	TotalDays INT NOT NULL,
	AmountCharged INT NOT NULL,
	TaxRate INT,
	TaxAmount INT,
	PaymentTotal INT NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT UNIQUE NOT NULL,
	DateOccupied date,
	AccountNumber INT NOT NULL,
	RoomNumber INT NOT NULL,
	RateApplied INT,
	PhoneCharge INT,
	Notes nvarchar(255)
)

INSERT INTO Employees(FirstName, LastName, Title, Notes)
VALUES
('Ivan', 'Ivanov', 'Manager', NULL),
('Georgi', 'Georgiev', 'Reception', NULL),
('Dimitur', 'Dimitrov', 'Cook', NULL);

INSERT INTO Customers(FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES
('Ivan', 'Petrov', NULL, NULL, 111, NULL),
('Ivan', 'Ivanov', NULL, NULL, 222, NULL),
('Ivan', 'Ivanov', NULL, NULL, 333, NULL);

INSERT INTO RoomStatus(RoomType, Notes)
VALUES
('Free', NULL),
('Reserved', NULL),
('Currently not available', NULL);

INSERT INTO RoomTypes(RoomType,Notes)
VALUES
('Big', NULL),
('Medium', NULL),
('Small', NULL);

INSERT INTO BedTypes(BedType,Notes)
VALUES
('Big', NULL),
('Medium', NULL),
('Small', NULL);

INSERT INTO Rooms(RoomType, BedType, Rate,RoomStatus,Notes)
VALUES
('Big', 'Big', NULL, 'Available', NULL),
('Medium', 'Medium', NULL, 'Not available', NULL),
('Small', 'Small', NULL, 'Available', NULL);

INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,FirstDateOccupied,LastDateOccupied,TotalDays,AmountCharged,TaxRate,TaxAmount,PaymentTotal,Notes)
VALUES
(111, NULL, 1111, NULL,NULL, 1, 1000, 0, 4256, 1000, NULL),
(222, NULL, 2222, NULL,NULL, 2, 1000, 0, 4554, 1000, NULL),
(333, NULL, 3333, NULL,NULL, 3, 1000, 0, 2313, 1000, NULL);

INSERT INTO Occupancies(EmployeeId,DateOccupied,AccountNumber,RoomNumber,RateApplied,PhoneCharge,Notes)
VALUES
(111, NULL, 1, 11, NULL,NULL,NULL),
(222, NULL, 2, 11, NULL,NULL,NULL),
(333, NULL, 3, 22, NULL,NULL,NULL);