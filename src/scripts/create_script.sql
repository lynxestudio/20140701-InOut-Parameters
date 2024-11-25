create table products
(
	id serial not null
	,product_code varchar(16) primary key unique
	,product_name varchar(128) not null
	,created timestamp null default now()
);