CREATE DATABASE  apeam_db;
USE apeam_db;


CREATE TABLE sales(
	Id int IDENTITY(1,1) PRIMARY KEY  NOT NULL,
	customer varchar(255) NOT NULL,
	date_sale datetime NOT NULL,
	payment varchar(100) NULL,
	total_sale float NULL,
);

CREATE TABLE sale_details(
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	article varchar(255) NOT NULL,
	quantity float NOT NULL,
	unit_price float NOT NULL,
	sale_id int NULL,

	CONSTRAINT fk_sale FOREIGN KEY(sale_id) REFERENCES  sales(Id)
);

