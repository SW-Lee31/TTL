create table customer(
customer_name varchar2(20),
age number(5),
gender char(6),
reg_date date default sysdate
);

insert into customer (customer_name, age, gender, reg_date) values('ȫ�浿', 20, 'M', sysdate);

select * from customer;

insert into customer (customer_name, age, gender, reg_date) values('ĥ����', 27, 'F', sysdate - 1);

select * from customer;

insert into customer (customer_name, age, gender, reg_date) values('Ȳ����', 30, 'M', sysdate - 10);
insert into customer (customer_name, age) values('��ö��', '45');
insert into customer values('��ö��', 33, 'F', sysdate);

select * from customer;