-- Упражнения: Връзки между таблици и JOIN клауза
USE softuni;

-- Задача 1. Адрес на служител
SELECT e.employee_id,e.job_title,e.address_id,a.address_text 
FROM employees AS e
JOIN addresses AS a ON a.address_id=e.address_id
LIMIT 5;

-- Задача 2. Служител по продажбите
SELECT e.employee_id,e.first_name,e.last_name,d.name as 'department_name' 
FROM employees AS e
JOIN departments AS d ON d.department_id=e.department_id
WHERE d.name='Sales'
ORDER BY e.employee_id DESC;

-- Задача 3. Служебни отдели
SELECT e.employee_id,e.first_name,salary,d.name as 'department_name' 
FROM employees AS e
JOIN departments AS d ON d.department_id=e.department_id
WHERE salary>15000
ORDER BY d.department_id DESC
LIMIT 5;

-- Задача 4. Служители без проект
SELECT employee_id, first_name 
FROM employees 
WHERE employee_id NOT IN 
		(SELECT DISTINCT employee_id FROM employees_projects ORDER BY employee_id)
ORDER BY employee_id DESC
LIMIT 3;

SELECT e.employee_id, first_name  
FROM employees as e
LEFT JOIN employees_projects as ep ON ep.employee_id=e.employee_id
WHERE project_id IS NULL
ORDER BY e.employee_id DESC
LIMIT 3;

-- Задача 5. Мениджър на служителите
SELECT e.employee_id,e.first_name,m.employee_id AS 'manager_id',m.first_name AS 'manager_name'
FROM employees AS e
JOIN employees AS m ON m.employee_id=e.manager_id
WHERE m.employee_id=3 OR m.employee_id=7
ORDER BY e.first_name;

-- Задача 6. Минимална заплата
SELECT salary,d.name 
FROM employees AS e
JOIN departments AS d ON d.department_id=e.department_id
ORDER BY salary ASC LIMIT 1;

-- Задача 7. Държави без планини
USE geography;
SELECT country_name FROM countries AS c
LEFT JOIN mountains_countries AS mc ON mc.country_code=c.country_code
WHERE mountain_id IS NULL;


