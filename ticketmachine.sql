create database ticketmachine
CREATE TABLE destination (
  id varchar(50) PRIMARY KEY,
  name VARCHAR(255),
  cost varchar(10)
);

CREATE TABLE ticket (
  id_ticket varchar(50) PRIMARY KEY,
  cost varchar(10),
  payment VARCHAR(50),
  destination varchar(50),
);

INSERT INTO destination
VALUES ('1', 'Thailand', '200000'),
       ('2', 'America', '120000'),
       ('3', 'Australia', '300000'),
	   ('4', 'Korean', '250000');

--drop table ticket
--drop table destination
select * from ticket
