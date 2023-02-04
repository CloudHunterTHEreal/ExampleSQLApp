CREATE TABLE examples(
	lastname varchar(5) NOT NULL,
	firstname varchar(5),
	middlename varchar(5),
	birthday DATE NOT NULL,
	sex varchar(1) NOT NULL,
	id int NOT NULL,
	payment_mode varchar(15),
	fault_tests int,
	comment varchar(250),
	PRIMARY KEY (id)
);