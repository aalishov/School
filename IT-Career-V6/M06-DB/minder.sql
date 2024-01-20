CREATE DATABASE minder;

USE minder;

SET default_storage_engine=InnoDB;

CREATE TABLE characteristics
(
	characteristic_id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL
);

CREATE TABLE users
(
	user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    birthdate DATE NOT NULL,
    gender ENUM('m','f') NOT NULL,
    bio TEXT,
    latitude DOUBLE NOT NULL,
    longitude DOUBLE NOT NULL,
    profile_picture VARCHAR(50)
);


CREATE TABLE characteristics_users
(
	characteristic_id INT,
    user_id INT,
    value VARCHAR(255) NOT NULL,
    CONSTRAINT pk_characteristics_users
		PRIMARY KEY (characteristic_id, user_id),
	CONSTRAINT fk_characteristics_users_characteristics
		FOREIGN KEY (characteristic_id)
        REFERENCES characteristics(characteristic_id),
	CONSTRAINT fk_characteristics_users_users
		FOREIGN KEY (user_id)
        REFERENCES users(user_id)
);

CREATE TABLE connections
(
	connection_id INT PRIMARY KEY AUTO_INCREMENT,
    from_user_id INT NOT NULL,
    to_user_id INT NOT NULL,
    accepted TINYINT(1) NOT NULL DEFAULT 0,
    CONSTRAINT fk_connections_users_from
		FOREIGN KEY (from_user_id)
        REFERENCES users(user_id),
	CONSTRAINT fk_connections_users_to
		FOREIGN KEY (to_user_id)
        REFERENCES users(user_id)
);

CREATE TABLE likes
(
	liked_by_user_id INT,
    liked_user_id INT,
    CONSTRAINT pk_likes
		PRIMARY KEY (liked_by_user_id, liked_user_id),
	CONSTRAINT fk_likes_liked_by
		FOREIGN KEY (liked_by_user_id)
        REFERENCES users(user_id),
	CONSTRAINT fk_likes_liked_user
		FOREIGN KEY (liked_user_id)
        REFERENCES users(user_id)
);


-- Заявка 1: Характеристики
SELECT title 
FROM characteristics
ORDER BY title
LIMIT 5;

-- Заявка 2: Всички връзки инициирани от потребител 481
SELECT from_user_id, to_user_id, accepted
FROM connections
WHERE from_user_id=481 AND accepted=1
ORDER BY to_user_id DESC;

-- Заявка 3: Изведете потребителските имена на тримата най-харесвани потребители
SELECT (SELECT username FROM users WHERE user_id = l.liked_user_id) AS 'username'
FROM likes AS l
GROUP BY liked_user_id
ORDER BY COUNT(*) DESC, liked_user_id DESC
LIMIT 3;

SELECT username 
FROM users AS u
JOIN likes AS l ON l.liked_user_id=u.user_id
GROUP BY username, l.liked_user_id
ORDER BY COUNT(*) DESC, l.liked_user_id DESC
LIMIT 3;

-- Заявка 4: Никой не ме харесва тъжен
SELECT user_id, username, first_name, last_name FROM users
WHERE user_id NOT IN (SELECT DISTINCT liked_user_id FROM likes)
ORDER BY first_name, last_name
LIMIT 10;

-- Заявка 5: Синеоки момичета родени през 90-те
SELECT u.username FROM users AS u
JOIN characteristics_users AS cu ON cu.user_id=u.user_id
JOIN characteristics AS c ON c.characteristic_id=cu.characteristic_id
WHERE c.title='Eye color' AND cu.value='blue' AND gender='f' 
		AND u.birthdate>='1990-01-01' AND u.birthdate<='1999-12-31'
ORDER BY u.username DESC;

-- Заявка 6: Каква е средната височина на потребителите?
SELECT ROUND(AVG(value),2) AS 'average_height'
FROM 
characteristics_users
WHERE characteristic_id=1;

-- Заявка 7: Какъв цвят на очите имат харесваните и харесаните?
  
SELECT uf.username AS 'liked_by', ut.username 'liked',
	cuf.value AS 'liked_by_eye_color',
    cut.value AS 'liked_eye_color'
FROM connections AS c
JOIN users AS uf ON uf.user_id=c.from_user_id
JOIN users AS ut ON ut.user_id=c.to_user_id
JOIN characteristics_users AS cuf ON cuf.user_id= c.from_user_id
JOIN characteristics_users AS cut ON cut.user_id= c.to_user_id
WHERE cuf.characteristic_id=3 AND cut.characteristic_id=3
ORDER BY uf.username, ut.username
LIMIT 5;

