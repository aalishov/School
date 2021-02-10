-- Problem 4.	Самообръщаша се връзка

CREATE DATABASE SelfReference;

USE SelfReference;

DROP TABLE Teachers;

CREATE TABLE Teachers
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Manager_id INT
)AUTO_INCREMENT=101;

INSERT INTO Teachers (Name, Manager_id)
VALUES
('John',null),
('Maya',	106),
('Silvia',	106),
('Ted',	105),
('Mark',	101),
('Greta',	101);

ALTER TABLE Teachers
ADD CONSTRAINT FK_id_manager_id
    FOREIGN KEY (Manager_id)
    REFERENCES Teachers(Id);