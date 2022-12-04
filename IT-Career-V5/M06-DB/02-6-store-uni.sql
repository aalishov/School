-- Problem 1.	База данни за онлайн магазин
CREATE DATABASE OnlineStore;

USE OnlineStore;

CREATE TABLE Cities
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

CREATE TABLE Customers
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(70) NOT NULL,
    birthday datetime,
    city_id INT NOT NULL,
    CONSTRAINT fk_customers_cities
		FOREIGN KEY (city_id)
        REFERENCES Cities(id)
);

CREATE TABLE Orders
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    customer_id INT NOT NULL,
    CONSTRAINT fk_orders_customers
		FOREIGN KEY (customer_id)
        REFERENCES Customers(id)
);

CREATE TABLE Item_types
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(60) NOT NULL
);

CREATE TABLE Items
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL,
    item_type_id INT,
    CONSTRAINT fk_items_item_type
		FOREIGN KEY (item_type_id)
        REFERENCES Item_types(id)
);

CREATE TABLE orders_items
(
	order_id INT,
    item_id INT,
    CONSTRAINT pk_orders_items
		PRIMARY KEY (order_id, item_id),
    CONSTRAINT fk_orders_items_orders
		FOREIGN KEY (order_id)
        REFERENCES Orders(Id),
	CONSTRAINT fk_orders_items_items
		FOREIGN KEY (item_id)
        REFERENCES Items(Id)
);


-- Problem 2.	Университетска база данни
CREATE DATABASE Uni;

USE Uni;

CREATE TABLE Subjects
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

CREATE TABLE Majors
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name NVARCHAR(50) NOT NULL
);

CREATE TABLE Students
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    number NVARCHAR(12) NOT NULL,
    name NVARCHAR(50) NOT NULL,
    major_id INT NOT NULL,
    CONSTRAINT fk_students_majors
		FOREIGN KEY (major_id)
        REFERENCES Majors(id)
);

CREATE TABLE Payments
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    date DATETIME NOT NULL,
    amount DECIMAL(8,2) NOT NULL,
    student_id INT NOT NULL,
    CONSTRAINT fk_payments_students
		FOREIGN KEY (student_id)
        REFERENCES Students (id)
);

CREATE TABLE Agenda
(
	student_id INT,
    subject_id INT, 
	CONSTRAINT pk_agenda
		PRIMARY KEY (student_id,subject_id),
	CONSTRAINT fk_agenda_subject
		FOREIGN KEY (subject_id)
        REFERENCES Subjects(id),
	CONSTRAINT fk_agenda_student
		FOREIGN KEY (student_id)
        REFERENCES Students(id)
);