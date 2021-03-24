-- Создаем базу данных

IF DB_ID('Shop') IS NOT NULL
BEGIN
	USE master
    ALTER DATABASE Shop SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Shop;
END
GO

CREATE DATABASE Shop;
GO


-- Делаем созданную базу данных текущей

USE Shop
GO


-- Создаем таблицы

CREATE TABLE Clients
(
	Id bigint IDENTITY NOT NULL PRIMARY KEY,
	Name nvarchar(50),
	Surname nvarchar(50)
);
GO

CREATE TABLE Sellers
(
	Id bigint IDENTITY NOT NULL PRIMARY KEY,
	Name nvarchar(50),
	Surname nvarchar(50)
);
GO

CREATE TABLE Sales
(
	Id bigint IDENTITY NOT NULL PRIMARY KEY,
	ClientFk bigint,
	SellerFk bigint,
	Price money,
	Date nvarchar(10),

	FOREIGN KEY (ClientFk) REFERENCES Clients(Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	FOREIGN KEY (SellerFk) REFERENCES Sellers(Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);
GO


-- Заполняем таблицы

SET IDENTITY_INSERT Clients ON
INSERT INTO Clients (Id, Name, Surname) VALUES (1, N'Айзек', N'Азимов');
INSERT INTO Clients (Id, Name, Surname) VALUES (2, N'Стивен', N'Кинг');
INSERT INTO Clients (Id, Name, Surname) VALUES (3, N'Джордж', N'Мартин');
SET IDENTITY_INSERT Clients OFF
GO

SET IDENTITY_INSERT Sellers ON
INSERT INTO Sellers (Id, Name, Surname) VALUES (1, N'Максим', N'Дмитриев');
INSERT INTO Sellers (Id, Name, Surname) VALUES (2, N'Илья', N'Михов');
INSERT INTO Sellers (Id, Name, Surname) VALUES (3, N'Матвей', N'Горелик');
SET IDENTITY_INSERT Sellers OFF
GO

SET IDENTITY_INSERT Sales ON
INSERT INTO Sales (Id, ClientFk, SellerFk, Price, Date) VALUES (1, 1, 2, 500, '21-04-2020');
SET IDENTITY_INSERT Sales OFF
GO

-- Проверка

SELECT *
FROM Clients;
GO

SELECT *
FROM Sellers;
GO

SELECT *
FROM Sales;
GO

SELECT (A.Name + ' ' + A.Surname) AS Client, P.Name + P.Surname AS Seller, B.Price, B.Date
FROM Clients A, Sellers P, Sales B
WHERE B.ClientFk IS NOT NULL AND B.SellerFk IS NOT NULL
      AND A.Id = B.ClientFk AND P.Id = B.SellerFk;
GO
