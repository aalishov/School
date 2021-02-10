USE employee;

CREATE TABLE people
(
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(30) NOT NULL UNIQUE,
    Password VARCHAR(26) NOT NULL,
    Profile_picture BLOB(900),  
    Last_login_time DATETIME,
    Is_deleted BOOL
);

INSERT INTO people (Username,Password,Is_deleted)
VALUES
	('ivan1','123456',0),
    ('ivan2','123456',0),
    ('ivan3','123456',0),
    ('ivan5','123456',0),
    ('ivan4','123456',0);
    
SELECT * FROM people;