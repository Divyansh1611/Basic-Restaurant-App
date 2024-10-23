-- Database Creation
create database RestaurantDb;

-- use Database
use RestaurantDb;


-- Create Tables 

CREATE TABLE Master.Customer (
 Id INT IDENTITY (1,1) PRIMARY KEY,
 CustomerName VARCHAR(255) NOT NULL
);

CREATE TABLE Master.Item (
 ItemId INT IDENTITY(1,1) PRIMARY KEY ,
 ItemName varchar(50) NOT NULL,
 ItemPrice decimal(18,2) NOT NULL
);

CREATE TABLE Master.Payment (
	PaymentTypeid INT IDENTITY(1,1) PRIMARY KEY,
	PaymentTypeName Varchar(50) NOT NULL
);

-- Dummy Data Insertion into Tables


--INTO CUSTOMER TABLE
INSERT INTO Master.Customer(CustomerName) values('Customer A');
INSERT INTO Master.Customer(CustomerName) values('Customer B');
INSERT INTO Master.Customer(CustomerName) values('Customer C');
INSERT INTO Master.Customer(CustomerName) values('Customer D');
INSERT INTO Master.Customer(CustomerName) values('Customer E');

-- INTO ITEM TABLE
INSERT INTO Master.Item(ItemName, ItemPrice) values('Apple', 50.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('Orange', 70.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('Pizza', 450.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('Burger', 150.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('Noodles', 80.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('Rice', 50.00);
INSERT INTO Master.Item(ItemName, ItemPrice) values('French Fries', 60.00);

-- INTO PAYMENT TABLE

INSERT INTO Master.Payment(PaymentTypeName) values('Cash');
INSERT INTO Master.Payment(PaymentTypeName) values('Credit');