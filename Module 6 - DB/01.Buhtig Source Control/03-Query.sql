use BuhtigSourceControl;

-- 01.Потребители
select id,username from users
order by id asc;

-- 02. Късметлийски числа
select repository_id,contributor_id from repositories_contributors
where repository_id=contributor_id
order by repository_id,contributor_id asc;

-- 03.    Проблеми и потребители
select i.id,concat(u.username,': ',i.title) as 'issue_assignee' 
from issues as i 
join users as u on u.id=i.assignee_id
order by i.id desc;
    
-- 04.Файлове без директории
select id,name,concat(size,'KB') as 'size' from files
where id not in (
	select distinct(parent_id) from files
	where parent_id is not null
);

-- 05.Активни хранилища
select r.id, r.name, count(repository_id) as 'issues' from repositories as r
join issues as i on i.repository_id=r.id
group  by repository_id
order by count(repository_id)  desc;

-- 06.    Хранилището с най-много участници
select r.id,r.name, count(cr.contributor_id) as 'contributors'  from repositories as r
join repositories_contributors as cr on cr.repository_id=r.id
group  by r.id
order by count(cr.contributor_id) desc;

-- 07.    Хранилища и потребители
select r.id,r.name, count(c.repository_id) as 'commits'  from repositories as r
join commits as  c on c.repository_id=r.id
group  by r.id
order by count(c.repository_id) desc;
