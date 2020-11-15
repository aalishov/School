CREATE DATABASE OneToMany;

USE OneToMany;

CREATE TABLE manufacturers
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL,
    established_on DATE
);

CREATE TABLE models
(
	id INT NOT NULL PRIMARY KEY  AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL,
    manufacturers_id INT NOT NULL,
    CONSTRAINT FK_models_manufacturers
    FOREIGN KEY (manufacturers_id)
    REFERENCES manufacturers(id)
) AUTO_INCREMENT=100;

INSERT INTO manufacturers(name,established_on)
VALUES
	('BMW ', 01/03/1916),
    ('Tesla', 01/01/2003),
    ('Lada', 01/05/1966);
    
INSERT INTO models(name,manufacturers_id)
VALUES
	('X1', 1),
    ('i6', 1),
    ('Model S', 2),
    ('Model X', 2),
    ('Model 3', 2),
    ('Model Nova', 3);

SELECT * FROM models;
