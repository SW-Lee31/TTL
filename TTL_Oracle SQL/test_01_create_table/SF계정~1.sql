create table person(
person_name varchar2(20),
person_digit varchar2(20),
person_address varchar2(20),
person_date date,
person_gender char(6)
);

insert into person values('ĥ����', '010-1234-1234',
'�뱸�� ������ ���̵�-123', sysdate, 'Male');

insert into person values('��ö��', '010-3456-7890',
'����� ������ �����-34', sysdate, 'Male');

insert into person values('Ȳ����', '010-7890-4566',
'���� ���� �纹��-144', sysdate - 3, 'Female');

