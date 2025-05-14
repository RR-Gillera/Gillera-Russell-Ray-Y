-- Create database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'RetailStoreDB')
BEGIN
    CREATE DATABASE RetailStoreDB;
END;
GO

USE RetailStoreDB;
GO

-- Create Products table
IF OBJECT_ID('Products', 'U') IS NULL
BEGIN
    CREATE TABLE Products (
        ProductID INT PRIMARY KEY IDENTITY(1,1),
        Name VARCHAR(100) NOT NULL,
        Price DECIMAL(10,2) NOT NULL,
        Quantity INT NOT NULL
    );
END;
GO
