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

USE Gallery;
GO

CREATE TABLE Customer (
    customer_id int PRIMARY KEY IDENTITY(1,1) ,
    name varchar(60),
    street varchar(120),
    phone varchar(60)
);
GO

CREATE TABLE [Transaction] (
    transaction_id int PRIMARY KEY IDENTITY(1,1) ,
    buyer_id int, 
    date datetime,
	sale_price decimal
);
GO



INSERT INTO Customer ( name, street, phone) VALUES ('John', ' 123 Main.', '614-555-1212');
GO

INSERT INTO [Transaction] (buyer_id, date, sale_price) VALUES (1, '2022-10-17', 5.00);
GO



ALTER TABLE [Transaction]
ADD FOREIGN KEY (buyer_id) REFERENCES Customer(customer_id);

