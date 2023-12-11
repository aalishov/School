CREATE DATABASE online_store;

USE online_store;

CREATE TABLE Cities
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE Customers
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    birthday DATE,
    city_id INT NOT NULL,
    CONSTRAINT fk_customers_cities
		FOREIGN KEY (city_id)
        REFERENCES Cities (id)
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
    name VARCHAR(50) NOT NULL
);

CREATE TABLE Items
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    item_type INT NOT NULL,
    CONSTRAINT fk_items_item_types
		FOREIGN KEY (item_type)
        REFERENCES Item_types(id)
);

CREATE TABLE order_items
(
	order_id INT,
    item_id INT,
    CONSTRAINT pk_order_items
		PRIMARY KEY(order_id,item_id),
	CONSTRAINT fk_order_items_order
		FOREIGN KEY (order_id)
        REFERENCES Orders(id),
	CONSTRAINT fk_order_items_items
		FOREIGN KEY (item_id)
        REFERENCES Items(id)
);
