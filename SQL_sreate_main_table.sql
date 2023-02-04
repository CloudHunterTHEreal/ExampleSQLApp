CREATE TABLE examples(
	lastname varchar(150) NOT NULL,
	firstname varchar(150),
	middlename varchar(150),
	birthday DATE NOT NULL,
	sex varchar(1) NOT NULL,
	id int NOT NULL,
	payment_mode varchar(15),
	fault_tests int,
	comment varchar(250),
	PRIMARY KEY (id)
);