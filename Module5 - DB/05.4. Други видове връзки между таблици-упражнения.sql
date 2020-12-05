use geography;

-- 02. Игра с континенти
select c1.continent_name as "FROM", c2.continent_name as "TO"
from continents c1
cross join continents c2
order by c1.continent_name, c2.continent_name;

-- 03. Европейското по футбол
select c1.capital as Place, c1.country_name as "Player 1 (Host)", " " as 'Host',
				" " as 'Guest', c2.country_name as "Player 2 (Guest)"
from countries c1
cross join countries c2
where c1.continent_code = "EU" and c2.continent_code = "EU"
  and c1.country_code <> c2.country_code
order by rand();

-- Problem 4.	Най-висок връх и най-дълга река по държава
select c.country_name, max(p.elevation) as 'MaxPeakElevation', max(r.length) as 'MaxRiverLength' 
from countries as c
left join mountains_countries as mc on mc.country_code = c.country_code
left join peaks as p on p.mountain_id = mc.mountain_id
left join countries_rivers as cr on cr.country_code = c.country_code
left join rivers as r ON r.Id = cr.river_id
group by c.country_name
order by `MaxPeakElevation` desc, `MaxRiverLength` desc, c.country_name desc
limit 5;

-- Problem 5.	*Континенти и валути
select usages.continent_code, usages.currency_code, usages.usages FROM
(
select con.continent_code, cu.currency_code, COUNT(cu.currency_code) as usages from continents as con
inner join countries as c on c.continent_code = con.continent_code
inner join currencies as cu on cu.currency_code = c.currency_code
group by con.continent_code, cu.currency_code
) as usages
inner join
(select usages.continent_code, max(usages.usages) as maxUsage from 
	(
		SELECT con.continent_code, cu.currency_code, count(cu.currency_code) as usages from continents as con
		inner join countries as c on c.continent_code = con.continent_code
		inner join currencies as cu on cu.currency_code = c.currency_code
		group by con.continent_code, cu.currency_code
		having COUNT(cu.currency_code) > 1
	) as usages
group by usages.continent_code
) as max_usages on max_usages.continent_code = usages.continent_code and max_usages.maxUsage = usages.usages
group by usages.continent_code, usages.currency_code;