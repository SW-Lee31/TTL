create table member(
member_name varchar2(20),
member_digit varchar2(20),
member_address varchar2(50),
member_date date default sysdate,
member_gender char(6),
member_client_digit varchar2(20),
member_order_serial varchar2(20)
);

insert into member(member_name, member_digit, member_address,
member_date, member_gender, member_client_digit) values('Ä¥°©»ê', '010-1234-1234',
'´ë±¸½Ã ¼ö¼º±¸ ¸¸ÃÌµ¿-123', sysdate - 3, 'Male', 'aa - 00001');