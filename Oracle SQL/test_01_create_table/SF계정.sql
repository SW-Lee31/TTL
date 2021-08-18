create table customer(
customer_name varchar2(20),
age number(5),
gender char(6),
reg_date date default sysdate
);

insert into customer (customer_name, age, gender, reg_date) values('È«±æµ¿', 20, 'M', sysdate);

select * from customer;

insert into customer (customer_name, age, gender, reg_date) values('Ä¥°©»ê', 27, 'F', sysdate - 1);

select * from customer;

insert into customer (customer_name, age, gender, reg_date) values('È²°©»ê', 30, 'M', sysdate - 10);
insert into customer (customer_name, age) values('°­Ã¶Áß', '45');
insert into customer values('ÇüÃ¶Æ÷', 33, 'F', sysdate);

select * from customer;