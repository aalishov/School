USE Soft_uni;

-- Problem 2.	Намерете цялата информация за отделите
SElect * from Departments;
-- Problem 3
Select Distinct name from Departments;
-- Problem 4
Select  first_name,last_name,salary from Employees;
-- Problem 5
Select  first_name, middle_name,last_name from Employees;
-- Problem 6
select concat(first_name,'.',last_name,'@softuni.bg') as full_email_address 
 from Employees;
 -- Problem 7
 select distinct salary 
 from Employees
 order by salary asc;
 -- Problem 8
 select * from employees 
 where job_title = 'Sales Representative';
 -- Problem 9
 select first_name,last_name,job_title from employees
 where salary between 20000 and 30000;
 -- Problem 10
 Select concat_ws(' ',first_name,middle_name,last_name) as 'full_name' 
 from Employees;
 -- Problem 11
 Select * from employees 
 where employee_id not in (Select distinct manager_id from employees where manager_id is not null);
 
SELECT first_Name,last_Name
FROM employees
WHERE manager_id IS NULL;
-- Problem 12
Select first_name, last_name, salary from Employees
where salary >50000;
-- Problem 13
Select first_name, last_name
from employees
 order by (salary) desc
 Limit 5;
 -- Problem 14
 Select first_name, last_name from Employees
 where department_id <> 4;
 -- Problem 15
 Select distinct job_title from employees order by(job_title) asc;
 -- Problem 16
 Select * from Projects  order By(start_date) asc
 Limit 10;
-- Problem 17
Select first_name, last_name, hire_date 
from employees 
order by hire_date desc
limit 7;
-- Problem 18
Update employees
Set salary = salary*1.12
where department_id in (select department_id from departments
where name in ('Engineering','Tool Design','Marketing','Information Services'));

Select * from employees 
where department_id in (select department_id from departments
where name in ('Engineering','Tool Design','Marketing','Information Services'))
order by salary;
 
 
