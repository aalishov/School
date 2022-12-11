USE soft_uni;

-- Problem 1.	Най-ниско платени служители
SELECT first_name, last_name, salary 
FROM employees
WHERE salary = 
	(
		SELECT salary FROM employees
		ORDER BY salary LIMIT 1
    );

-- Problem 2.	Служители с близки до най-ниските заплати
SELECT first_name, last_name, salary 
FROM employees
WHERE salary <= 
	(
		SELECT salary FROM employees
		ORDER BY salary LIMIT 1
    ) * 1.1;


-- Problem 3.	Всички мениджъри
SELECT employee_id,first_name, last_name,job_title
FROM employees
WHERE employee_id IN
	(
		SELECT manager_id FROM departments
    )
ORDER BY first_name ASC, last_name ASC;

-- Problem 4.	Служителите от San Francisco

SELECT first_name, last_name FROM Employees
WHERE address_id IN 
	(
		SELECT address_id FROM addresses WHERE town_id = 
			(
				SELECT town_id FROM towns WHERE name = 'San Francisco'
			)
    );


