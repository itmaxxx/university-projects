IF DB_ID('Schedule') IS NOT NULL
BEGIN
	USE master
    ALTER DATABASE Schedule SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Schedule;
END
GO

CREATE DATABASE Schedule;
GO

USE Schedule
GO

CREATE TABLE Schedules
(
	Id bigint IDENTITY NOT NULL PRIMARY KEY,
	FullName nvarchar(20),
	StartDate date,
	EndDate date,
);
GO

CREATE TABLE WorkingDays
(
	Id bigint IDENTITY NOT NULL PRIMARY KEY,
	DayOfWeek int,
	ScheduleFk bigint,

	FOREIGN KEY (ScheduleFk) REFERENCES Schedules(Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
);
GO

SET IDENTITY_INSERT Schedules ON
INSERT INTO Schedules (Id, Fullname, StartDate, EndDate) VALUES (1, N'Стивен Кинг', '2020-12-20', '2020-12-31');
INSERT INTO Schedules (Id, Fullname, StartDate, EndDate) VALUES (2, N'Айзек Азимов', '2021-01-01', '2021-02-01');
INSERT INTO Schedules (Id, Fullname, StartDate, EndDate) VALUES (3, N'Джордж Мартин', '2021-02-09', '2021-03-01');
INSERT INTO Schedules (Id, Fullname, StartDate, EndDate) VALUES (4, N'Айзек Азимов', '2021-03-18', '2021-04-01');
INSERT INTO Schedules (Id, Fullname, StartDate, EndDate) VALUES (5, N'Джордж Мартин', '2021-04-18', '2021-05-26');
SET IDENTITY_INSERT Schedules OFF
GO

SET IDENTITY_INSERT WorkingDays ON
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (1, 1, 2);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (2, 2, 1);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (3, 3, 3);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (4, 4, 5);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (5, 5, 1);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (6, 6, 2);
INSERT INTO WorkingDays (Id, DayOfWeek, ScheduleFk) VALUES (7, 7, 4);
SET IDENTITY_INSERT WorkingDays OFF
GO

SELECT S.Fullname, S.StartDate, S.EndDate FROM Schedules S, WorkingDays W WHERE W.ScheduleFk = S.Id