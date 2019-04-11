-- Database for Eshopping inft3050 Assignment
-- Created by Michael Wilson
-- c3114828
-- 12/8/18

use master
go

IF EXIST(select * from sys.databases where name='SodaPop')
DROP DATABASE SodaPop
go

CREATE DATABASE SodaPop
go

USE SodaPop
go


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
	ProductBrand	NVARCHAR(50),
	ProductImage	VARBINARY (max),
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
	OrderNumber		INT,
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


--CREATE TABLE OrderDetails (
--	OrderDetailsID	INT PRIMARY KEY,
--	OrderDate		
--	OrderProductName
--	OrderProductQuantity
--	OrderProductPrice

--	CONSTRAINT fk_OrderID FOREIGN KEY (OrderID) REFERENCES Order(OrderID),
--	CONSTRAINT fk_ProductID FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
--)

--     DBConn = ConfigurationManager.ConnectionStrings["SodaPopConnectionString"].ConnectionString;






-- Test Values
INSERT INTO Customer(EmailAddress, Password, FirstName, LastName)
VALUES ('wichaelmilson@uon.edu.au', 'password1', 'Michael', 'Wilson'),
('oliver@uon.edu.au', 'password2', 'Oliver', 'Dog'),
('michael@uon.edu.au', 'password3', 'Michael', 'Wilson')
go


INSERT INTO Category(CategoryID,CategoryName)
VALUES (1, 'Electronics'), (3,'Clothing'),(2,'Sports')
go


  SET IDENTITY_INSERT Product ON
  INSERT INTO Product(ProductID, Name, Description, Quantity, Price, ProductBrand, CategoryID)
  VALUES (123, 'LCD 32 Inch TV', 'LCD Smart TV 32inch, 30mm Depth, 140cm height', 20, 2000.00, 'Samsung', 1),
		 (023, 'OLED 40 Inch TV', 'OLED Display 4k Resoltuons, 25mm depth, 150cm height', 4, 5500.00, 'LG', 1),
		 (101, 'Blue Shirt Large', 'Large Blue Button up shirt', 34, 25.00, 'Basic Apparel',3 ),
		 (010, 'Basketball', 'size 7 basketball spalding', 14, 99.99, 'Spalding', 2)
  go

INSERT INTO (Customer)