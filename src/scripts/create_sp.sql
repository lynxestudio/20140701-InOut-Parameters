create or replace function usp_insertproduct(p_code varchar
,p_name varchar
,out p_id int
,out p_created timestamp)
as $$
begin
	p_id := nextval('products_id_seq');
	p_created := now();
	insert into products(id,product_code
	,product_name
	,created)
	values(p_id,p_code
	,p_name
	,p_created);
	EXCEPTION
	WHEN connection_failure THEN
	RAISE EXCEPTION 'Connection Lost';
	WHEN connection_exception THEN
	RAISE EXCEPTION 'Server failure';
	WHEN others THEN
	RAISE EXCEPTION 'Please consult with your administrator.';
end;
$$ language 'plpgsql';