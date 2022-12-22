Create database Scooters;
Use scooters;

Create table cities
(
	city_id int primary key auto_increment,
    name varchar(30) not null
);

Create table users
(
	user_id int primary key auto_increment,
    username varchar(50) unique not null,
    password varchar(255) not null,
    first_name varchar(255) not null,
    last_name varchar(255),
    balance decimal(15,2) not null,
    city_id int not null,
    register_date datetime not null,
	constraint fk_users_cities
		foreign key (city_id)
		references cities(city_id)
);

Create table scooters
(
	scooter_id int primary key auto_increment,
    model varchar(255) not null,
    gps_position varchar(255) not null,
    is_taken tinyint
);

Create table rents
(
	rent_id int primary key auto_increment,
    user_id int not null,
    scooter_id int not null,
    start_date datetime not null,
    end_date datetime,
    is_completed tinyint,
	constraint fk_rents_users
		foreign key (user_id)
        references users(user_id),
	constraint fk_rents_scooters
		foreign key (scooter_id)
        references scooters(scooter_id)
);

select name from cities
order by name
limit 5;

select username,register_date from users
where balance = 0
order by register_date desc, first_name;

Select user_id as id, username,balance from users
where city_id = (Select city_id from cities where name = 'Varna')
order by balance desc
limit 1;

-- Заявка 4: Потребители без наеми
Select username, balance from users
where user_id not in (Select user_id from rents)
order by balance desc, username asc
limit 5;

-- Заявка 4: Потребители без наеми 2 начин

Select username,balance from users as u
Left Join rents as r on r.user_id= u.user_id
where r.user_id is null
order by balance desc, username asc
limit 5;

-- Заявка 5: Наеми по градовете

Select Count(*) as total_rents,c.name from rents as r
join users as u on u.user_id= r.user_id
join cities as c on c.city_id = u.city_id
group by c.name
order by total_rents desc,rent_id desc
limit 10;

-- Заявка 6: Най-много наеми
Select Count(*) as total_rents,username from users as u
JOin rents as r on r.user_id= u.user_id
Group by username
order by total_rents desc,username asc
limit 5 ;

-- Заявка 7: Колко тротинетки не са върнати в Пловдив?

Select Count(*) as not_returned from rents
where user_id in 
(
	Select user_id from users where city_id=
		(
		Select city_id from cities where name = 'Plovdiv'
        )
	)
AND
(
	is_completed = 0
);



