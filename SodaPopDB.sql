-- Database for SodaPop inft3050 Assignment
-- Created by Michael Wilson
-- c3114828
-- 12/04/2019

use master
go

IF EXIST(select * from sys.databases where name='SodaPop')
DROP DATABASE SodaPop
go

CREATE DATABASE SodaPop
go

USE SodaPop
go

CREATE USER Michael With Password 'password';

--table creation

CREATE TABLE Category (
	CategoryID		INT PRIMARY KEY,
	CategoryName	NVARCHAR(50) NOT NULL
	)

CREATE TABLE Product (
	ProductID		INT IDENTITY PRIMARY KEY,
	Name			NVARCHAR(50) NOT NULL,		
	Description		NVARCHAR(100) NOT NULL,
	Quantity		INT NOT NULL,
	Price       	DECIMAl(10,2),
	CategoryID		INT

	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
	)


	CREATE TABLE Customer (
	CustomerID		INT IDENTITY(100001,1) PRIMARY KEY,
	EmailAddress	NVARCHAR(100) NOT NULL,
	Password        NVARCHAR(30)  NOT NULL,
	FirstName		NVARCHAR(40),
	LastName		NVARCHAR(40)

	)

	CREATE TABLE Orders (
	OrderID			INT PRIMARY KEY,
	OrderDate		DATETIME,
	OrderQuantity	INT,
	OrderTotalPrice	DECIMAL(10,2),
	CustomerID		INT,
	ProductID		INT,

	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
	
	)

	CREATE TABLE Cart (

	CartID 			INT PRIMARY KEY,

	Quantity        INT,

	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
	
	)


--     DBConn = ConfigurationManager.ConnectionStrings["SodaPopConnectionString"].ConnectionString;






-- Test Values
INSERT INTO Customer(EmailAddress, Password, FirstName, LastName)
VALUES ('wichaelmilson@uon.edu.au', 'password1', 'Michael', 'Wilson'),
('wilson@uon.edu.au', 'password2', 'wilson', 'michael'),
('patrick@uon.edu.au', 'password3', 'patrcik', 'wilmich')
go


INSERT INTO Category(CategoryID,CategoryName)
VALUES (101, 'Cola'), (202,'Lemonade'),(303,'Creaming Soda')
go


INSERT INTO (Customer)