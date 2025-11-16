-- 1. Create the Database (Run this command first)
CREATE DATABASE LibraryStockDB;
GO

-- 2. Use the newly created database
USE LibraryStockDB;
GO

-- 3. Create the Users Table for Authentication [cite: 154]
-- Password should ideally be hashed in a real-world app.
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(50) NOT NULL -- e.g., 'Librarian', 'Admin'
);

-- 4. Create the Books Table 
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Publisher NVARCHAR(100) NULL,
    Category NVARCHAR(50) NULL, -- e.g., Computer Science, Literature, Engineering [cite: 137]
    ISBN NVARCHAR(50) UNIQUE NULL,
    Quantity INT NOT NULL, -- Number of copies available [cite: 137]
    Price DECIMAL(10, 2) NOT NULL,
    RackNo NVARCHAR(20) NULL, -- Physical location [cite: 137]
    DateAdded DATE NOT NULL
);

-- 5. Insert Sample User Data (2 Users)
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

