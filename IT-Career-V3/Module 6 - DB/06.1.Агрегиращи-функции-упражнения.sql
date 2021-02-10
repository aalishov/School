use `gringotts`;

-- Problem 1.	Брой на записите
select count(id) as 'Count' from wizzard_deposits;

-- Problem 2.	Най-дългата магическа пръчка
select max(magic_wand_size) from wizzard_deposits;

-- Съма на депозитите по група
select deposit_group as 'Name', sum(deposit_amount) as 'Group total amount'
from wizzard_deposits
group by deposit_group;

select max(age), min(age), last_name
from wizzard_deposits
group by deposit_group;