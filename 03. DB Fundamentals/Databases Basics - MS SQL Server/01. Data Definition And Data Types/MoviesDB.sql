--13. Movies Database.
CREATE DATABASE Movies

GO

USE Movies

CREATE TABLE Directors
(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	DirectorName nvarchar(255) NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Genres
(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	GenreName nvarchar(255) NOT NULL,
	Notes nvarchar(255)
)

CREATE TABLE Categories
(
	Id int IDENTITY(1,1) NOT NULL  PRIMARY KEY,
	CategoryName nvarchar(255) NOT NULL,
	Notes nvarchar(255)
)


CREATE TABLE Movies
(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,	Title nvarchar(255) NOT NULL,
	DirectorID int UNIQUE,
	CopyrightYear date,
	Length decimal(10,2),
	GenreID int UNIQUE,
	CategoryID int,
	Rating int,
	Notes nvarchar(255)
)

INSERT INTO Directors(DirectorName, Notes)
VALUES
('Tarantino', NULL),
('Spielberg', NULL),
('Kubric', NULL),
('Bay', NULL),
('Scorecese', NULL);

INSERT INTO Genres(GenreName, Notes)
Values
('Action', NULL),
('Adventure', NULL),
('Thriller', NULL),
('Horror', NULL),
('Romance', NULL);

INSERT INTO Categories(CategoryName, Notes)
Values
('Category1', NULL),
('Category2', NULL),
('Category3', NULL),
('Category4', NULL),
('Category5', NULL);

INSERT INTO Movies(Title, DirectorID, CopyrightYear, Length, GenreID, CategoryID,Rating,Notes)
Values
('Movie1', 4235, NULL, NUll, 11, 2, 1, NULL),
('Movie2', 4546, NULL, NUll, 22, 2, 4, NULL),
('Movie3', 1112, NULL, NUll, 33, 3, 3, NULL),
('Movie4', 4444, NULL, NUll, 44, 4, 5, NULL),
('Movie5', 6788, NULL, NUll, 55, 1, 2, NULL);