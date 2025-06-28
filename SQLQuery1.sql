CREATE DATABASE CarPaymentApp;
USE CarPaymentApp;

Create Table Users (
	Id INT Primary Key IDENTITY,
	Username NVARCHAR(50) NOT NULL UNIQUE,
	Password NVARCHAR(255) NOT NULL
);

Insert into Users (Username, Password) VALUES ('testUser', 'password123');
Select * from Users;

Create table Transactions (
	Id Int Primary KEY Identity,
	UserId Int Foreign KEY References Users(Id),
	CarPrice Decimal(18, 2),
	DownPayment Decimal(18, 2),
	InterestRate Decimal(5, 2),
	LoanTerm Int,
	MonthlyPayment Decimal(18, 2),
	DateCreated Datetime Default GetDate()
);
SELECT * FROM Transactions;
DELETE FROM Transactions WHERE Id = 5;
