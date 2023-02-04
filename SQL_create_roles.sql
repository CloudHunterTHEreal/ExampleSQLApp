CREATE TABLE roles(
	role_name varchar(50) NOT NULL PRIMARY KEY,
	role_description varchar(100)
);

INSERT INTO roles
VALUES 
('administrator', 'Администратор приложения'),
('guest', 'Гость');