USE Geography;

-- Problem 1.	Държави с реки
SELECT country_name, river_name 
FROM Countries AS c
LEFT JOIN Countries_rivers AS cr ON cr.country_code=c.country_code
LEFT JOIN Rivers as r ON r.id=cr.river_id
WHERE c.continent_code = 
	(
		SELECT continent_code FROM Continents
		WHERE continent_name='Africa'
	)
ORDER BY country_name ASC LIMIT 5;

-- Problem 2.	* Държави без планини
SELECT country_name FROM Countries
WHERE country_code NOT IN (SELECT DISTINCT country_code FROM mountains_countries);

SELECT country_name 
FROM Countries AS c
LEFT JOIN mountains_countries AS mc ON mc.country_code=c.country_code
WHERE mountain_id IS NULL;

-- Problem 3.	Планините в България
SELECT *
FROM Mountains AS m
LEFT JOIN Peaks AS p ON p.mountain_id=m.id
WHERE m.id IN 
	(
		SELECT mountain_id FROM mountains_countries
		WHERE country_code='BG'
	)
    AND  (p.id = 
			(
				SELECT id FROM Peaks
				WHERE mountain_id=m.Id
				ORDER BY Elevation DESC LIMIT 1
			)
		OR p.id IS NULL
    )
ORDER BY elevation DESC;

USE Soft_uni;
-- Problem 4.	Служители без проект
SELECT e.employee_id, first_name, last_name
FROM Employees AS e
LEFT JOIN Employees_projects AS ep ON ep.employee_id=e.employee_id
WHERE project_id IS NULL
ORDER BY first_name ASC, last_name ASC
LIMIT 3;
