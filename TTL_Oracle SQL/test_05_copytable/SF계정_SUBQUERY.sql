DROP TABLE EMPLOYEE;
DROP TABLE DEPARTMENT;
DROP TABLE SALGRADE;

CREATE TABLE COM_DEPARTMENT
   (DNO NUMBER(2) CONSTRAINT PK_DEPT PRIMARY KEY,
   DNAME VARCHAR2(14),
	 LOC   VARCHAR2(13) ) ;

CREATE TABLE COM_EMPLOYEE 
   (ENO NUMBER(4) CONSTRAINT PK_EMP PRIMARY KEY,
	 ENAME VARCHAR2(10),
 	 JOB   VARCHAR2(9),
	 MANAGER  NUMBER(4),
	 HIREDATE DATE,
	 SALARY NUMBER(7,2),
	 COMMISSION NUMBER(7,2),
	 DNO NUMBER(2) CONSTRAINT FK_DNO REFERENCES COM_DEPARTMENT);

CREATE TABLE COM_SALGRADE
   (GRADE NUMBER,
	 LOSAL NUMBER,
	 HISAL NUMBER );

INSERT INTO COM_DEPARTMENT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO COM_DEPARTMENT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO COM_DEPARTMENT VALUES (30,'SALES','CHICAGO');
INSERT INTO COM_DEPARTMENT VALUES (40,'OPERATIONS','BOSTON');

INSERT INTO COM_EMPLOYEE VALUES
(7369,'SMITH','CLERK',    7902,to_date('17-12-1980','dd-mm-yyyy'),800,NULL,20);
INSERT INTO COM_EMPLOYEE VALUES
(7499,'ALLEN','SALESMAN', 7698,to_date('20-2-1981', 'dd-mm-yyyy'),1600,300,30);
INSERT INTO COM_EMPLOYEE VALUES
(7521,'WARD','SALESMAN',  7698,to_date('22-2-1981', 'dd-mm-yyyy'),1250,500,30);
INSERT INTO COM_EMPLOYEE VALUES
(7566,'JONES','MANAGER',  7839,to_date('2-4-1981',  'dd-mm-yyyy'),2975,NULL,20);
INSERT INTO COM_EMPLOYEE VALUES
(7654,'MARTIN','SALESMAN',7698,to_date('28-9-1981', 'dd-mm-yyyy'),1250,1400,30);
INSERT INTO COM_EMPLOYEE VALUES
(7698,'BLAKE','MANAGER',  7839,to_date('1-5-1981',  'dd-mm-yyyy'),2850,NULL,30);
INSERT INTO COM_EMPLOYEE VALUES
(7782,'CLARK','MANAGER',  7839,to_date('9-6-1981',  'dd-mm-yyyy'),2450,NULL,10);
INSERT INTO COM_EMPLOYEE VALUES
(7788,'SCOTT','ANALYST',  7566,to_date('13-07-1987', 'dd-mm-yyyy'),3000,NULL,20);
INSERT INTO COM_EMPLOYEE VALUES
(7839,'KING','PRESIDENT', NULL,to_date('17-11-1981','dd-mm-yyyy'),5000,NULL,10);
INSERT INTO COM_EMPLOYEE VALUES
(7844,'TURNER','SALESMAN',7698,to_date('8-9-1981',  'dd-mm-yyyy'),1500,0,30);
INSERT INTO COM_EMPLOYEE VALUES
(7876,'ADAMS','CLERK',    7788,to_date('13-07-1987', 'dd-mm-yyyy'),1100,NULL,20);
INSERT INTO COM_EMPLOYEE VALUES
(7900,'JAMES','CLERK',    7698,to_date('3-12-1981', 'dd-mm-yyyy'),950,NULL,30);
INSERT INTO COM_EMPLOYEE VALUES
(7902,'FORD','ANALYST',   7566,to_date('3-12-1981', 'dd-mm-yyyy'),3000,NULL,20);
INSERT INTO COM_EMPLOYEE VALUES
(7934,'MILLER','CLERK',   7782,to_date('23-1-1982', 'dd-mm-yyyy'),1300,NULL,10);

INSERT INTO COM_SALGRADE VALUES (1, 700,1200);
INSERT INTO COM_SALGRADE VALUES (2,1201,1400);
INSERT INTO COM_SALGRADE VALUES (3,1401,2000);
INSERT INTO COM_SALGRADE VALUES (4,2001,3000);
INSERT INTO COM_SALGRADE VALUES (5,3001,9999);

COMMIT;

-- ���̺� ���� (�����ͱ���)
create table dept_copy as select * from com_department;

-- ���̺� ���� (������)
create table dept_copy2 as select * from com_department where 0 = 1;

-- com_department�� 10�� �μ��� �������� 20�� �μ��� ���������� ����
update dept_copy set loc = 
(select loc from dept_copy where dno = 20)
where dno = 10;

create table emp_copy as select * from com_employee;

-- sales �μ����� �ٹ��ϴ� ��� ��� ����
delete emp_copy where dno = 
    (select dno from com_department where dname = 'SALES');

-- ��¥ ������ �˻�
select * from com_employee where hiredate <= '1981/01/01';

-- �� ������ Ȱ��
select * from com_employee where dno = 10 and job = 'MANAGER';

    -- �޿� 1000�� 1500 ������ �� �̻�
select * from com_employee where salary between 1000 and 1500;

    -- �� �˻�
select * from com_employee where commission in (300, 500, 1400);

-- �׷� �Լ�
select sum(salary) as "�޿� �Ѿ�",
    avg(salary) as "�޿� ���",
    max(salary) as "�ִ� �޿�",
    min(salary) as "�ּ� �޿�"
from com_employee;

-- count : ���� ������ ���ϴ� �Լ�
select count(*) as "����� ��" from com_employee;

-- Ư�� �÷��� �������� �׷�з�
select dno as "�μ� ��ȣ", avg(salary) as "��� �޿�"
    from com_employee group by dno;
    
select dno, job, count(*), sum(salary) from com_employee
    group by dno, job 
    order by dno desc, job desc;
    
-- ��¥ ǥ��
-- TO_CHAR() :  ����, ��¥�� ���ڿ��� ǥ��
-- ���� ��¥, �ð� (dual : �Լ�, ��� ���� Ȯ���� �� ����ϴ� ���̺�
select ename, hiredate, 
    to_char(hiredate, 'yy-mm') as "�Ի� ��-��",
    to_char(hiredate, 'yyyy/mm/dd day') as "�Ի� ��-��-��-����",
    to_char(sysdate, 'yyyy/mm/dd, hh24:mi:ss') as "���糯¥, �ð�"
from com_employee;
    
select to_char(sysdate, 'yyyy/mm/dd, hh24:mi:ss') as "���糯¥, �ð�" from dual;

-- ��ȭ��ȣ
-- L : ���� �� ��ȭ ��ȣ
-- 0 : �ڸ����� ���� ������ '0'���� ä��
-- 9 : �ڸ����� ���� ������ ����
select ename, to_char(salary, 'L999,999') from com_employee;

-- case�� Ȱ���� �̸�, �μ��� ���
select ename, dno,
    case
        when dno = 10 then 'ACCOUNTING'
        when dno = 20 then 'RESEARCH'
        when dno = 30 then 'SALES'
        when dno = 40 then 'OPERATIONS'
        else 'DEFAULT'
    end as "�μ���"
from com_employee order by dno;

-- �μ���, ������, �����, ��� ����� ��� �޿� ���
select decode (dno, 10, 'ACCOUNTING',
                            20, 'RESEARCH',
                            30, 'SALES',
                            40, 'OPERATIONS') as "�μ���",
        decode (dno, 10, 'NEW_YORK',
                            20, 'DALLAS',
                            30, 'CHICAGO',
                            40, 'BOSTON') as "����",
        count(*) as "�����",
        round(avg(salary)) as "��� �޿�"
from com_employee group by dno;
