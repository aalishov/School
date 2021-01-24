use soft_uni;
-- Problem 1.	Вмъкване на данни
insert into departments (name, manager_id)
values ('Engineering',15);

insert into employees (first_name,middle_name,last_name , job_title,department_id,hire_date,salary)
values ('Petar','Petrov','Petrov','Senior Engineer',
	(
		select department_id from departments
		where name='Engineering'
		limit 1
    ),
    now(),4000); 
    
-- Problem 4.	Увеличете заплатата на работника
select * from employees;

update employees
	set salary=salary*1.1
where employee_id;
