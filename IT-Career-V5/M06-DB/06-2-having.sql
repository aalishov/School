USE gringotts;

-- Problem 1.	Депозитни суми за семейство Ollivander
SELECT deposit_group,SUM(deposit_amount) AS total_sum 
FROM wizzard_deposits
WHERE magic_wand_creator LIKE 'Ollivander%'
GROUP BY deposit_group
ORDER BY deposit_group;

-- Problem 2.	Филтър на депозити
SELECT deposit_group,SUM(deposit_amount) AS total_sum 
FROM wizzard_deposits
WHERE magic_wand_creator LIKE 'Ollivander%'
GROUP BY deposit_group
HAVING total_sum<150000
ORDER BY deposit_group