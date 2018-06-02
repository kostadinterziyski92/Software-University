--01. Create Database.
CREATE DATABASE Minions

--02. Create Tables.
CREATE TABLE Minions(
Id INT PRIMARY KEY,
Name NVARCHAR(50),
AGE INT
)

CREATE TABLE Towns(
Id INT PRIMARY KEY,
Name NVARCHAR(50)
)

--03. Alter Minions Table.
ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD CONSTRAINT FK_Minions_Towns 
FOREIGN KEY (TownId) REFERENCES Towns(Id)

--04. Insert Records in Both Tables.
INSERT INTO Minions
VALUES 
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

INSERT INTO Towns
VALUES 
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna');

--05. Truncate Table Minions.
TRUNCATE TABLE Minions

--06. Drop All Tables.
DROP TABLE Minions
DROP TABLE Towns

--07. Create Table People.
CREATE TABLE People(
Id INT IDENTITY PRIMARY KEY,
Name NVARCHAR(200) NOT NULL,
Picture varbinary CHECK(DATALENGTH(Picture)<900*1024),
Height decimal(10, 2),
Weight decimal(10,2),
Gender varchar(1) NOT NULL Check(Gender ='m' OR Gender ='f'),
Birthdate int NOT NULL,
Biography nvarchar(255)
)

INSERT INTO People (Name, Picture, Height, Weight, Gender, Birthdate, Biography)
VALUES 
('Ivana',NULL, 2,522, 'f', 23, 'I like cats!'),
('Peter',NULL, NULL,3.6, 'm', 24, NULL),
('Mihaela',NULL, NULL,7.8, 'f', 30, NULL),
('Georgi',NULL, NULL,20.22, 'm', 34, NULL),
('Rumen',NULL, NULL,31.01, 'm', 20, NULL);

--08. Create Table Users.
CREATE TABLE Users(
Id int IDENTITY(1,1) UNIQUE,
Username nvarchar(30) UNIQUE NOT NULL,
Password nvarchar(26) NOT NULL,
ProfilePicture varbinary CHECK(DATALENGTH(ProfilePicture)<900*1024),
LastLoginTime date,
IsDeleted nvarchar(5) NOT NULL CHECK(IsDeleted='true' or isDeleted='false') 
)

INSERT INTO Users(Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES 
('Kostadin', '1234', 26, NULL, 'true'),
('Ivan', '14567', 21, NULL, 'true'),
('Maria', '1143', 27, NULL, 'false'),
('Katerina', '18678', 22, NULL, 'true'),
('Georgi', '1436576', 21, NULL, 'false');

--09. Change Primary Key.
ALTER TABLE Users
DROP CONSTRAINT PK_Id

ALTER TABLE Users
ADD CONSTRAINT PK_Id_Username PRIMARY KEY(Id, Username)

--10. Add Check Constraint.
ALTER TABLE Users
ADD CHECK(LEN(Username) > 2)  

--11. Set Default Value of a Field.
ALTER TABLE Users
ADD CONSTRAINT DF_Users_LastLoginTime DEFAULT CURRENT_TIMESTAMP

--12. Set Unique Field.
ALTER TABLE Users
DROP CONSTRAINT PK_Id_Username

ALTER TABLE Users
ADD CONSTRAINT PK_Id PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT UC_Username UNIQUE(Username)






