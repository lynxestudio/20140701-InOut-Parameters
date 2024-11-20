create table products
(
	id serial not null
	,product_code varchar(16) primary key unique
	,product_name varchar(128) not null
	,blocked boolean default 'f'
	,created timestamp null default now()
	,modified timestamp null default now()
);