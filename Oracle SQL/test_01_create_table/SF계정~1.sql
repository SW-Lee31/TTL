create table person(
person_name varchar2(20),
person_digit varchar2(20),
person_address varchar2(20),
person_date date,
person_gender char(6)
);

insert into person values('칠갑산', '010-1234-1234',
'대구시 수성구 만촌동-123', sysdate, 'Male');

insert into person values('이철용', '010-3456-7890',
'서울시 마포구 노원동-34', sysdate, 'Male');

insert into person values('황석포', '010-7890-4566',
'울산시 동구 사복동-144', sysdate - 3, 'Female');

