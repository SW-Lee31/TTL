create table student_db(
    st_id number not null,
    constraint pk_st_id primary key(st_id),
    
    st_name varchar2(20) not null,
    age number not null,
    constraint age_ck check (7 < age and age <= 19),
    
    addr varchar2(80) not null
);

create sequence st_seq_id increment by 1 start with 1000;

insert into student_db (st_id, st_name, age, addr) values (st_seq_id.nextval, 'ĥ����', 19, '�뱸�� �޼��� ȣ�굿 - 142');

update student_db set gender = 'Male' where st_name = 'ĥ����';

alter table student_db add (grade char(8) constraint grade_ck check (grade in ('A', 'B', 'C', 'D', 'F')));

update student_db set grade = 'B' where st_name = 'ĥ����';

insert into student_db values (st_seq_id.nextval, 'Ȳ����', 16, '����� ������ ������ - 122', 'Male', 'A');
insert into student_db values (st_seq_id.nextval, '����', 14, '����� ������ ������ - 122', 'Female', 'B');
insert into student_db values (st_seq_id.nextval, '�ֵ���', 15, '����� ������ ������ - 122', 'Female', 'F');
insert into student_db values (st_seq_id.nextval, '������', 11, '����� ������ ������ - 122', 'Female', 'F');
insert into student_db values (st_seq_id.nextval, 'Ȳ����', 12, '����� ������ ������ - 122', 'Male', 'B');
insert into student_db values (st_seq_id.nextval, 'Ȳ����', 17, '����� ������ ������ - 122', 'Female', 'A');
insert into student_db values (st_seq_id.nextval, '���¹�', 19, '����� ������ ������ - 122', 'Female', 'C');
insert into student_db values (st_seq_id.nextval, '������', 10, '����� ������ ������ - 122', 'Male', 'D');

-- 'Ȳ����', '�ں���', '�����ٶ����', 'avdxx����' �� �˻�
select * from student_db where st_name like '%����';

-- 'Ȳ����', '�ֺ���' �� �տ� �� ���� '_ _��' --> ��տ� �ƹ� ���� �� ���� �˻�
select * from student_db where st_name like '__��';

-- ������������ ���� asc (���� ����)
select * from student_db order by st_name asc;

-- ���� ���� ���� ���� �� ���ĵ� ���� ���� �����ϸ� ���� ���� ����
select * from student_db order by st_name desc, age asc;


