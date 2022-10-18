USE master;
GO

IF DB_ID('Gallery') IS NOT NULL
BEGIN
	ALTER DATABASE Gallery SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE Gallery;
END
GO

CREATE DATABASE Gallery;
GO

USE Gallery
GO

CREATE TABLE Customer (
    customer_iD int PRIMARY KEY IDENTITY(1,1) ,
    name varchar(60),
    street varchar(20),
    phone varchar(60)
);
GO

INSERT INTO Customer(name, street, phone) VALUES('Omar', '123 Main', '513-555-3421');
GO
