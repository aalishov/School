USE Gringotts;

-- Problem 1.	Най-дългата магическа пръчка по депозитна група
SELECT deposit_group, MAX(magic_wand_size) as longest_magic_wand
FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY longest_magic_wand DESC, deposit_group

-- Problem 2.	Най-малката депозитна група с най-малката магическа пръчка
SELECT deposit_group
FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY AVG(magic_wand_size) ASC
LIMIT 1;

-- Problem 3.	Сума от депозити
SELECT deposit_group, SUM(deposit_amount) as total_sum
FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY total_sum ASC


