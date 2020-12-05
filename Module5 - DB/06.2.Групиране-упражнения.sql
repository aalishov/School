USE `gringotts`;

-- Problem 1.	Най-дългата магическа пръчка по депозитна група
select deposit_group, max(magic_wand_size) as 'longest_magic_wand'
from wizzard_deposits
group by deposit_group
order by max(magic_wand_size) desc, deposit_group;

-- Problem 2.	Най-малката депозитна група с най-малката магическа пръчка
select deposit_group
from wizzard_deposits
group by deposit_group
order by avg(magic_wand_size) asc
limit 2;