USE master;
GO
ALTER DATABASE emdm SET SINGLE_USER WITH ROLLBACK IMMEDIATE
drop database emdm
create database emdm

USE emdm;
GO

IF (NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'power')) 
BEGIN
    EXEC ('CREATE SCHEMA [power] AUTHORIZATION [dbo]')
END

CREATE TABLE [power].[ISO]
(
	[ISOId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NOT NULL
);

CREATE TABLE [power].[SettlementPointType]
(
	[SettlementPointTypeId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NOT NULL
);

CREATE TABLE [power].[SettlementPoint]
(
	[SettlementPointId] INT NOT NULL PRIMARY KEY, 
	[SettlementPointTypeId] INT FOREIGN KEY REFERENCES [power].[SettlementPointType](SettlementPointTypeId),
    [ISOId] INT FOREIGN KEY REFERENCES [power].[ISO](ISOId),
    [Name] VARCHAR(MAX) NOT NULL
);