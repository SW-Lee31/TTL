/* 
varchar :  ���� ���� ���� ������ (1 ~ 4000 Bytes)
varchar2 : ���� ���� ���� ������ (1 ~ 4000 Bytes)
char : ���� ���� ���� ������ (1 ~ 2000 Bytes)
number : ���� ���� ���� ������
date :  ��¥ (7 Bytes)
clob :  ��뷮 ���ڿ� ó��
blob :  ���� ���� ��ü (���̳ʸ�)

DDL : create, alter, drop table
DML : CRUD
DCL : ..
*/

create table student_t (
        -- primary key : �⺻Ű -> ������ ��, ���� ����
    stu_id number not null primary key, 
    stu_name varchar2(20) not null,
    age number not null,
    address varchar2(80) not null
);

insert into student_t values (0001, 'ȫ�浿', 18, '����� ������ �λ굿-123');

insert into student_t values (0002, 'ĥ����', 17, '���� âȣ�� ��-3221');

-- ���̺� ���ο� Column �߰�
alter table student_t add (grade char(5));

-- auto increment -> Oracle ������ Sequence �� �θ� (�ڵ� �� ����)
-- ������ ����
create sequence seq_id increment by 1 start with 3; -- 1���� 1�� �����ϴ� ������ seq_id ����

insert into student_t (stu_id, stu_name, age, address) values (seq_Id.nextval, 'Ȳ����', 18, '������ ���ڰ� 123');

insert into student_t (stu_id, stu_name, age, address) values (seq_id.nextval, '������', 16, '���׽� ������ 54');

insert into student_t values (seq_id.nextval, '��ö��', 19, '���ֽ� ���� ȣ���� 10', 'A');

select stu_name from student_t;

-- ���̺� ���� �ÿ� ����� �������� ���� �����ؾ� �� (��� ū ����� ����)
-- drop sequence seq_id;

-- ���̺� ����
-- drop table student_t;