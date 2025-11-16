
CREATE DATABASE LibraryStockDB;
USE LibraryStockDB;

CREATE TABLE Users 
    (
    UserID INT PRIMARY KEY IDENTITY(1,1), Username NVARCHAR(50) NOT NULL UNIQUE,  Password NVARCHAR(50) NOT NULL, Role NVARCHAR(50) NOT NULL );

CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1), Title NVARCHAR(200) NOT NULL, Author NVARCHAR(100) NOT NULL, Publisher NVARCHAR(100) NULL,
    Category NVARCHAR(50) NULL, ISBN NVARCHAR(50) UNIQUE NULL, Quantity INT NOT NULL, Price DECIMAL(10, 2) NOT NULL, RackNo NVARCHAR(20) NULL, 
    DateAdded DATE NOT NULL );


INSERT INTO Users (Username, Password, Role) VALUES
('librarian1', 'pass123', 'Librarian'),
('admin', 'adminpass', 'Admin');

-- 6. Insert Sample Book Data
INSERT INTO Books (Title, Author, Publisher, Category, ISBN, Quantity, Price, RackNo, DateAdded) VALUES
('The C# Programming Guide', 'J. Smith', 'TechPress', 'Computer Science', '978-0123456789', 50, 45.99, 'A-201', '2025-10-15'),
('Advanced Algorithms', 'A. Doe', 'Algorithmic Inc.', 'Computer Science', '978-1112223334', 30, 75.50, 'A-205', '2025-09-01'),
('Literature Classics Vol. 1', 'Various', 'Global Books', 'Literature', '978-5556667778', 10, 20.00, 'B-102', '2025-11-10');


SELECT * FROM Users;


SELECT * FROM Books;


