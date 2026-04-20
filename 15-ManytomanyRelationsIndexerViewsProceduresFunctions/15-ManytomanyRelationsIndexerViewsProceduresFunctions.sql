CREATE DATABASE CompanyMM;
USE CompanyMM;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY ,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Email VARCHAR(100) UNIQUE NOT NULL,
    CONSTRAINT chk_BirthDate CHECK (BirthDate < '2010-01-01') 
);
CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY ,
    ProjectName VARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE,
    CONSTRAINT chk_Dates CHECK (EndDate IS NULL OR EndDate >= StartDate) 
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE DEFAULT (CURRENT_DATE),
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE,
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID) ON DELETE CASCADE
);
-- İşçilər
INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Ali', 'Aliyev', '1990-05-15', 'ali@company.com'),
('Leyla', 'Mammadova', '1992-08-20', 'leyla@company.com'),
('Anar', 'Hasanov', '1985-11-10', 'anar@company.com'),
('Aysel', 'Rzayeva', '1995-02-25', 'aysel@company.com'),
('Vugar', 'Qasimov', '1988-12-30', 'vugar@company.com');

-- Layihələr
INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('AI Integration', '2024-01-01', '2024-12-31'),
('Mobile App', '2024-03-01', NULL),
('Cyber Security', '2024-02-15', '2025-02-15');

INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate) VALUES
(1, 1, '2024-01-05'), (1, 2, '2024-03-10'), (1, 3, '2024-04-01')
(2, 1, '2024-01-05'), (2, 2, '2024-03-12'),                     
(3, 3, '2024-02-20');  

SELECT * FROM Employees;


SELECT * FROM Projects;


SELECT e.FirstName, e.LastName, p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectName;

SELECT e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID
HAVING ProjectCount > 2;
CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID, 
    CONCAT(e.FirstName, ' ', e.LastName) AS FullName, 
    p.ProjectID, 
    p.ProjectName, 
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;

