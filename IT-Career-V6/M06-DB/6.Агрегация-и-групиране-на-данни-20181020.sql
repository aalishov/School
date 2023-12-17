use gringotts;
-- 1
select count(*) as Count from wizzard_deposits;

-- 2
SELECT    
	magic_wand_size AS 'longest_magic_wand'
FROM
    wizzard_deposits
ORDER BY magic_wand_size DESC
LIMIT 1; 

-- Problem 1.	Най-дългата магическа пръчка по депозитна група
SELECT 
    deposit_group, MAX(magic_wand_size) AS 'longest_magic_wand'
FROM
    wizzard_deposits
GROUP BY deposit_group
ORDER BY longest_magic_wand ASC;

select deposit_group
from wizzard_deposits
group by deposit_group 
order by avg(magic_wand_size) asc
limit 1;

select deposit_group, sum(deposit_amount) as total_sum
from wizzard_deposits
group by deposit_group 
order by total_sum asc;

select deposit_group, sum(deposit_amount) as 'total_sum' from wizzard_deposits
where magic_wand_creator = 'Ollivander family'
group by deposit_group
order by deposit_group asc;

select deposit_group,magic_wand_creator, min(deposit_charge) as min_deposit_charge
from wizzard_deposits
group by magic_wand_creator,deposit_group
order by magic_wand_creator,deposit_group asc;

SELECT 
	CASE
		WHEN age between 0 and 10 then '[0-10]'
        WHEN age between 11 and 20 then '[11-20]'
        WHEN age between 21 and 30 then '[21-30]'
        WHEN age between 31 and 40 then '[31-40]'
        WHEN age between 41 and 50 then '[41-50]'
        WHEN age between 51 and 60 then '[51-60]'
        ELSE '[61+]'
    END AS age_group, COUNT(*) AS wizard_count
FROM wizzard_deposits
GROUP BY age_group
ORDER BY wizard_count;

-- Problem 3.	Първа буква
SELECT LEFT(first_name,1) AS first_letter
FROM wizzard_deposits
GROUP BY first_letter
ORDER BY first_letter;

-- Problem 4.	Средна лихва 
SELECT deposit_group, is_deposit_expired, AVG(deposit_interest)
FROM wizzard_deposits
WHERE deposit_start_date>'1985-01-01'
GROUP BY deposit_group, is_deposit_expired
ORDER BY deposit_group DESC, is_deposit_expired ASC