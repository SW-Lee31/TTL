insert into stock values ( 'aa' || to_char(seq_id.nextval), 34, 'puma_shirt');
insert into stock (stock_id, stock_name, stock_amount) values ('pt' || to_char(seq_id.nextval), 'puma_shorts', 40);
insert into stock values ('ua' || to_char(seq_id.nextval), 31, 'underarmour_shirt');

select * from stock where stock_id like 'ua%';

select stock_name  as 상품명,
stock_amount as  재고량 from stock
where stock_id like 'p%' or stock_id like 'a%';

select * from stock 
where stock_amount < 40
order by stock_amount desc;