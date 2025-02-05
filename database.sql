
-- Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(30) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Address1 VARCHAR(100),
    PayPerHour DECIMAL(5,2) NOT NULL
);

-- Supervisors Table
CREATE TABLE Supervisors (
    SupervisorID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(30) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Address1 VARCHAR(100),
    AnnualSalary DECIMAL(10,2) NOT NULL
);

-- Managers Table
CREATE TABLE Managers (
    ManagerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(30) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Address1 VARCHAR(100),
    AnnualSalary DECIMAL(10,2) NOT NULL,
    MaxExpenseAmount DECIMAL(10,2) NOT NULL
);
