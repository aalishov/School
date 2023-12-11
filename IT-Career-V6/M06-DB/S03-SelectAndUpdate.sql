-- Part I. Заявки към БД SoftUni
USE softuni;

-- Задача 1. Намерете цялата информация за отделите
SELECT 
    *
FROM
    departments;

-- Задача 2. Намерете всички имена на отдели
SELECT 
    name
FROM
    departments;

-- Задача 3. Намерете заплатата на всеки служител
SELECT 
    first_name, last_name, salary
FROM
    employees;

-- Задача 4. Намерете пълното име на всеки служител
SELECT first_name,middle_name,last_name
FROM employees;

-- Задача 5. Намерете имейл адреса на всеки служител
SELECT 
    CONCAT(first_name,
            '.',
            last_name,
            '@softuni.bg') AS 'full_email_address'
FROM
    employees;

-- Задача 6. Намерете всички различни работни заплати
SELECT DISTINCT
    salary
FROM
    employees
ORDER BY salary;

-- Задача 7. Намерете цялата информация за служители
SELECT 
    *
FROM
    employees
WHERE
    job_title = 'Sales Representative';

-- Задача 8. Намерете имената на всички служители със заплата в диапазон
SELECT 
    first_name, last_name, job_title
FROM
    employees
WHERE
    salary BETWEEN 20000 AND 30000;

-- Задача 9. Намерете имената на всички служители
SELECT 
    CONCAT_WS(' ', first_name, middle_name, last_name) AS 'Full Name'
FROM
    employees
WHERE
    salary IN (25000 , 14000, 12500, 23600);
    
-- Задача 10. Намерете всички служители без мениджър
SELECT 
    first_name, last_name
FROM
    employees
WHERE
    manager_id IS NULL;
    
-- Задача 11. Намерете всички служители със заплата повече от 50000
SELECT 
    first_name, last_name, salary
FROM
    employees
WHERE
    salary > 50000
ORDER BY salary DESC;

-- Задача 12. Намете 5 най-добре платени служителя
SELECT 
    first_name, last_name
FROM
    employees
ORDER BY salary DESC
LIMIT 5;

-- Задача 14. Различни длъжности
SELECT DISTINCT
    job_title
FROM
    employees
ORDER BY job_title ASC;

-- Задача 15. Намерете първите 10 започнати проекти
SELECT 
    *
FROM
    projects
ORDER BY start_date ASC , name ASC
LIMIT 10;

-- Задача 16. Последните 7 наети служители
SELECT 
    first_name, last_name, hire_date
FROM
    employees
ORDER BY hire_date DESC
LIMIT 7;

-- Задача 17. Увеличаване на заплати
SELECT 
    salary * 1.12
FROM
    employees
WHERE
    department_id IN (SELECT 
            department_id
        FROM
            departments
        WHERE
            name IN ('Engineering' , 'Tool Design',
                'Marketing',
                'Information Services'))
ORDER BY salary;

UPDATE employees 
SET 
    salary = salary * 1.12
WHERE
    department_id IN (SELECT 
            department_id
        FROM
            departments
        WHERE
            name IN ('Engineering' , 'Tool Design',
                'Marketing',
                'Information Services'));
                
SELECT salary FROM employees;

-- Part II – Заявки към БД Geography
USE geography;
-- Задача 1. Всички планински върхове
SELECT 
    peak_name
FROM
    peaks
ORDER BY peak_name;
-- Задача 2. Най-големи по население страни
SELECT 
    country_code, population
FROM
    countries
WHERE
    continent_code = 'EU'
ORDER BY population DESC , country_name ASC;

-- Задача 3. Страни и валута  (Euro / Not Euro)
SELECT 
    country_name,
    country_code,
    CASE
        WHEN currency_code = 'EUR' THEN 'Euro'
        ELSE 'Not euro'
    END AS 'currency'
FROM
    countries
ORDER BY country_name;