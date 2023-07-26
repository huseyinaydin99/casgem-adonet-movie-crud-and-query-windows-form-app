CREATE DATABASE CasgemDBMovie;
USE CasgemDBMovie;

CREATE TABLE Category(
CategoryId INT PRIMARY KEY IDENTITY(1,1),
CategoryName NVARCHAR(50),
CategoryStatus BIT
);

CREATE TABLE Movie(
MovieId INT PRIMARY KEY IDENTITY(1,1),
MovieName NVARCHAR(100),
MovieDuration TINYINT,
MovieIMBD DECIMAL(2,1),
MovieCategory INT
);