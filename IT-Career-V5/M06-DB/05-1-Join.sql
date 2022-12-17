USE Soft_uni;

-- Problem 1.	Адрес на служител
SELECT  employee_id,job_title,e.address_id,address_text
FROM employees AS e
JOIN addresses AS a ON a.address_id = e.address_id
ORDER BY address_id
LIMIT 5;


-- Problem 2.	Служител по 
SELECT employee_id,first_name, last_name, name AS 'Department_name'
FROM Employees AS e
JOIN Departments AS d ON d.department_id=e.department_id
WHERE name = 'Sales'
ORDER BY employee_id DESC;

-- Problem 3.	Служебни отдели
SELECT employee_id,first_name,last_name,name 
FROM Employees as e
JOIN Departments AS d ON d.department_id=e.department_id
WHERE Salary>15000
ORDER BY d.department_id DESC
LIMIT 5;


-- Problem 4	Служители без проект
SELECT e.employee_id,first_name
FROM employees AS e
WHERE employee_id not in 
	(SELECT  distinct employee_id from employees_projects)
ORDER BY e.employee_id desc
LIMIT 3;

-- Problem 5.	Мениджър на служителите
SELECT e.employee_id, e.first_name, e.last_name, m.first_name as 'manager_name'
FROM employees AS e
JOIN employees AS m ON e.manager_id=m.employee_id
WHERE m.employee_id=3 OR m.employee_id=7
ORDER BY e.first_name ASC;

-- Problem 6.	Минимална заплата
SELECT salary, name FROM Employees as e
JOIN Departments as d ON d.department_id=e.department_id
ORDER BY  Salary ASC
LIMIT 1;

USE Geography;
-- Problem 7.	Държави без планини
SELECT country_name FROM Countries
WHERE country_code NOT IN (SELECT DISTINCT country_code FROM mountains_countries)


