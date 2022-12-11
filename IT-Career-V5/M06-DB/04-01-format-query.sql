USE soft_uni;

-- Problem 1.	Намерете всички служители със заплата над 50000
SELECT first_name, last_name, salary 
FROM employees
WHERE salary>50000
ORDER BY salary DESC;

-- Problem 2.	 Намерете 5 най-добре платени служители.
SELECT first_name, last_name 
FROM employees
ORDER BY salary DESC
LIMIT 5;

-- Problem 3.	Сортирайте таблицата със служители
SELECT *
FROM employees
ORDER BY salary DESC, first_name ASC, last_name DESC, middle_name ASC;

-- Problem 4.	Намерете първите 10 започнати проекта
SELECT *
FROM projects
ORDER BY start_date ASC, name ASC
LIMIT 10;

-- Problem 5.	 Последните 7 наети служителя
SELECT first_name, last_name, hire_date
FROM employees
ORDER BY hire_date DESC
LIMIT 7;

USE Geography;
-- Problem 6.	Всички планински върхове
SELECT peak_name
FROM peaks
ORDER BY peak_name;

-- Problem 7.	 Най-големи държави по население
SELECT country_name, population 
FROM countries
WHERE continent_code= 
	(
		SELECT continent_code FROM Continents
		WHERE continent_name='Europe'
    )
ORDER BY population DESC, country_name ASC
LIMIT 30;

-- Problem 8.	 Държави и валути (Евро / Не евро)
SELECT country_name, country_code, 
	CASE 
		WHEN currency_code='EUR' THEN 'Euro' 
        ELSE 'Not Euro'  
	END AS Currency
FROM countries
ORDER BY country_name
