create database scooters ;
use scooters;   
CREATE TABLE cities (
    city_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL
);
CREATE TABLE users (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    balance DOUBLE(15,2) NOT NULL,
    city_id INT NOT NULL,
    CONSTRAINT users_cities FOREIGN KEY (city_id)
        REFERENCES cities (city_id),
    register_date DATETIME NOT NULL
);
CREATE TABLE scooters (
    scooter_id INT PRIMARY KEY AUTO_INCREMENT,
    model VARCHAR(255) NOT NULL,
    gps_position VARCHAR(255) NOT NULL,
    is_taken BOOLEAN
    -- Стойност по подразбиране false.
);
CREATE TABLE rents (
    rent_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    CONSTRAINT rents_users FOREIGN KEY (user_id)
        REFERENCES users (user_id),
    scooter_id INT NOT NULL,
    CONSTRAINT rents_scooters FOREIGN KEY (scooter_id)
        REFERENCES scooters (scooter_id),
    start_date DATETIME NOT NULL,
    end_date DATETIME,
    is_completed BOOLEAN
);


-- Заявка 1: Градове
SELECT 
    name
FROM
    cities
ORDER BY name ASC
LIMIT 5;

-- Заявка 2: Потребители с нулев баланс
SELECT 
    username, register_date
FROM
    users
WHERE
    balance = 0
ORDER BY register_date DESC , first_name ASC;


-- Заявка 3: Най-голям баланс на софийски потребители
SELECT 
    u.user_id, username, balance
FROM
    users AS u
        JOIN
    cities AS c ON c.city_id = u.city_id
WHERE
    c.name = 'Varna'
ORDER BY u.balance DESC
LIMIT 1; 

-- Заявка 4: Потребители без наеми
SELECT 
    username, balance
FROM
    users AS u
WHERE
    user_id NOT IN (SELECT DISTINCT
            user_id
        FROM
            rents)
ORDER BY balance DESC , username ASC
LIMIT 5;

-- Заявка 5: Наеми по градовете
SELECT 
    c.name, COUNT(*) AS 'total_rents'
FROM
    rents AS r
        JOIN
    users AS u ON u.user_id = r.user_id
        JOIN
    cities AS c ON c.city_id = u.city_id
GROUP BY c.name
ORDER BY COUNT(*) DESC
LIMIT 10;

-- Заявка 6: Най-много наеми
SELECT 
    u.username, COUNT(*)
FROM
    users AS u
        JOIN
    rents AS r ON r.user_id = u.user_id
GROUP BY u.username
ORDER BY COUNT(*) DESC , username
LIMIT 5;

-- Заявка 7: Колко тротинетки не са върнати в Пловдив?
SELECT 
    COUNT(*) AS 'not returned'
FROM
    rents AS r
        JOIN
    users AS u ON u.user_id = r.user_id
        JOIN
    cities AS c ON c.city_id = u.city_id
WHERE
    c.name = 'Plovdiv'
        AND r.is_completed = 0
