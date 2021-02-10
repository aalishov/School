-- Demo subquery
use soft_uni;
-- Служител с нйа-висока заплата
SELECT first_name, last_name, salary
FROM Employees
WHERE Salary = 
	(
		SELECT Salary FROM Employees 
        ORDER BY Salary DESC 
        LIMIT 1
	);
    
-- Първите 5 служители с нйа-висока заплата
SELECT first_name, last_name, salary
FROM Employees
WHERE Salary IN
	(
		SELECT Salary FROM Employees 
        ORDER BY Salary DESC 
	)
LIMIT 5;

-- Първите 5 служители с нaj-висока заплата на определена позиция
SELECT first_name, last_name, salary
FROM Employees
WHERE (Salary,job_title) IN
	(
		SELECT Salary, job_title FROM Employees 
        where job_title IN('Human Resources Manager','Production Technician')
        ORDER BY Salary DESC 
	)
LIMIT 5;

select * from employees;


-- Добавяне на колона в съществуваща таблица
alter table employees
add phone varchar(20) default '-';

select * from employees;

-- Изтриване на колона в съществуваща таблица
alter table employees
drop phone ;

select * from employees;