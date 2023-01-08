USE BSC;

-- 01.Потребители
SELECT id, username 
FROM users
ORDER BY id;

-- 02. Късметлийски числа
SELECT *
FROM repositories_contributors
WHERE repository_id=contributor_id
ORDER BY repository_id;

-- 03.    Проблеми и потребители
SELECT i.id, CONCAT(username,' : ',title) AS issue_assignee 
FROM users AS u
JOIN issues AS i ON i.assignee_id=u.id
ORDER BY i.id DESC;

-- 04.Файлове без директории
SELECT id, name, CONCAT(size,'KB') AS size
FROM files
WHERE id NOT IN 
	(
		SELECT DISTINCT parent_id FROM files 
        WHERE parent_id IS NOT NULL
    )
ORDER BY id;

-- 05.Активни хранилища
SELECT r.id, name, COUNT(*) AS issues
FROM repositories AS r 
JOIN issues as i ON i.repository_id=r.id
GROUP BY r.id, r.name
ORDER BY issues DESC, r.id ASC
LIMIT 5;

-- 06.    Хранилището с най-много участници
SELECT repository_id,
	(SELECT name FROM repositories WHERE id=rc.repository_id) as name,
    (SELECT COUNT(*) FROM commits 
		WHERE repository_id=rc.repository_id
        GROUP BY repository_id
	) AS commits,
	COUNT(*) AS contributors
FROM repositories_contributors AS rc
GROUP BY repository_id
ORDER BY contributors DESC, repository_id
LIMIT 1;

-- 07.    Хранилища и потребители
SELECT r.id, r.name, (SELECT COUNT(DISTINCT contributor_id) FROM commits WHERE repository_id=r.id) AS users
FROM repositories AS r
LEFT JOIN commits AS c ON c.repository_id=r.id
GROUP BY  name,r.id
ORDER BY users DESC, r.id ASC;
