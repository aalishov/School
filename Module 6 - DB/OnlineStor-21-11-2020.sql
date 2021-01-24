CREATE DATABASE store;

USE store;
 
CREATE TABLE item_types
(
	item_type_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL
);

CREATE TABLE items
(
	item_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY KEY,
	name VARCHAR(50) NOT NULL,
	item_type_id INT,
	CONSTRAINT FK_items_item_types
		FOREIGN KEY(item_type_id)
		REFERENCES item_types(item_type_id)
);

CREATE TABLE cities
(
	city_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL, 
    CONSTRAINT check_name
    CHECK(length(name)>2)
);

INSERT INTO cities(name)
VALUES ('Sifia'),
		('Varna');

CREATE TABLE customers
(
	customer_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	city_id INT,
	CONSTRAINT FK_customers_cities
		FOREIGN KEY (city_id)
		REFERENCES cities(city_id)
);

CREATE TABLE orders
(
	order_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	customer_id INT,
		CONSTRAINT FK_orders_order_items
			FOREIGN KEY (customer_id)
			REFERENCES customers(customer_id)
);

CREATE TABLE order_items
(
	order_id INT NOT NULL ,
	item_id INT,
	CONSTRAINT pk_order_items
		PRIMARY KEY(order_id,item_id),
	CONSTRAINT FK_order_id_orders
		FOREIGN KEY (order_id)
		REFERENCES orders(order_id),
	CONSTRAINT FK_item_id_items
		FOREIGN KEY (item_id)
		REFERENCES items(item_id)
);
 



 

