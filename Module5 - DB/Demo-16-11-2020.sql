CREATE DATABASE DemoDb;

USE DemoDb;

DROP TABLE Countries;

CREATE TABLE Countries
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Name NVARCHAR(30) ,
    Population INT ,
    CONSTRAINT Check_Name
		CHECK(length(Name)>3),
    CONSTRAINT CheckPopulation
		CHECK(Population>100000) 
) ;

INSERT INTO Countries(Name,Population)
VALUES ('Germany',100);


CREATE TABLE Towns
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Name NVARCHAR(30) CHECK(length(Name)>3),
    CoutryId INT NOT NULL,
    FOREIGN KEY (CoutryId)
    REFERENCES Countries(Id)
);

