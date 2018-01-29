CREATE DATABASE [Pirates of the eggs];

USE [Pirates of the eggs];

CREATE TABLE Gerechten(
GerechtID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
GerechtNaam varchar(50) NOT NULL,
GerechtPrijs money NOT NULL,
GerechtSoort int NOT NULL
);

CREATE TABLE Tafels(
TafelID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
TafelGebruik int NOT NULL
);

CREATE TABLE Orders(
ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
GerechtID int NOT NULL,
OrderID int NOT NULL,
TafelID int NOT NULL,
Betaald int NOT NULL
);

CREATE TABLE GerechtCategorie(
GerechtID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
SoortNaam varchar(50) NOT NULL
);

INSERT INTO GerechtCategorie
VALUES('Voorgerecht'),
('Soep'),
('Hoofdgerecht'),
('Dessert'),
('Drank');

INSERT INTO Gerechten
VALUES ('Stokbrood',0,1),
('Kipsalade',0,1),
('Hamrolletjes',0,1),
('Bruschetta',0,1),
('Garnalencocktail',0,1),
('Nachos',0,1),
('Groente',0,2),
('Tomaten',0,2),
('Kippen',0,2),
('Uien',0,2),
('Pompoen',0,2),
('Taco',0,3),
('Gyros',0,3),
('Frieten',0,3),
('Hamburger',0,3),
('Pizza',0,3),
('Spaghetti',0,3),
('Noodles',0,3),
('Wafels',0,4),
('Ijs',0,4),
('Cheesecake',0,4),
('Tiramisu',0,4),
('Croissant',0,4),
('Cola',0,5),
('Sinas',0,5),
('7Up',0,5),
('Bier',0,5),
('Witte wijn',0,5),
('Rode wijn',0,5);

INSERT INTO Tafels
VALUES (0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0),
(0);