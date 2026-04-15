CREATE DATABASE Company;
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    JobTitle VARCHAR(50),
    Salary DECIMAL(10, 2),
    Department VARCHAR(50)
);
INSERT INTO Employees VALUES 
(1, 'isko', 'Memmedov', 'isi@company.az', '0505502555', '2020-03-10', 'Developer', 2500, 'IT'),
(2, 'ibi', 'samandarov', 'ibi@gmail.com', '0559874443', '2021-03-15', 'HR Specialist', 1800, 'HR'),
(3, 'Nazario', 'Ronaldo', 'nazario@company.az', '0777761223', '2022-03-20', 'System Admin', 10000, 'IT'),
(4, 'Günel', 'memmedov', 'gunel@company.az', '0505505050', '2000-01-30', 'Accountant', 3330, 'Finance'),
(5, 'Reşad', 'Daqli', 'reshad@mail.ru', '055433366', '1982-06-12', 'Sales Agent', 1400, 'Sales');
SELECT * FROM Employees;
SELECT * FROM Employees WHERE Salary > 2000;
SELECT * FROM Employees WHERE Department = 'IT';
SELECT * FROM Employees ORDER BY Salary DESC;
select FirstName ,Salary From Employees;
SELECT * FROM Employees WHERE HireDate > '2020-01-01';
SELECT * FROM Employees WHERE Email LIKE '%company.az%';
SELECT MAX(Salary) FROM Employees;
SELECT MIN(Salary) FROM Employees;
SELECT AVG(Salary) FROM Employees;
SELECT COUNT(*) FROM Employees;
SELECT SUM(Salary) FROM Employees;
SELECT Department, COUNT(*) FROM Employees GROUP BY Department;
SELECT Department, AVG(Salary) FROM Employees GROUP BY Department;
SELECT Department, MAX(Salary) FROM Employees GROUP BY Department;
UPDATE Employees SET Salary = 2800 WHERE EmployeeID = 1;
UPDATE Employees SET Salary = Salary * 1.10 WHERE Department = 'IT';
Insert into Employees values
(6, 'leyla', 'hesenova', 'leyla@mail.ru', '055433366', '1982-06-12', 'Sales Agent', 1400, 'Sales')
UPDATE Employees SET JobTitle = 'HR Meneceri' WHERE FirstName = 'Leyla' AND LastName = 'Həsənova';
SELECT * FROM Employees WHERE FirstName LIKE '%a%';
SELECT * FROM Employees WHERE Salary BETWEEN 2000 AND 2500;
SELECT * FROM Employees WHERE Department IN ('Finance', 'IT');
