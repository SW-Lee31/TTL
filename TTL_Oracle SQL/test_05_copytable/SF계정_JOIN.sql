-- JOIN :  2�� �̻��� ���̺��� ������ ������ �����ͼ� ��ġ�� ��
select e.eno, e.ename, d.dname, e.dno 
from com_employee e, com_department d
where e.dno = d.dno and e.eno = 7788;

-- using ��� (inner join)
select e.eno, e.ename, d.dname, dno
    from com_employee e join com_department d
    using(dno) where e.eno = 7788;

-- on ��� 
select e.eno, e.ename, d.dname, e.dno
    from com_employee e join com_department d
    on e.dno = d.dno where e.eno = 7788;
    
    
-- 3���� ���̺� JOIN
select e.ename, d.dname, e.salary, s.grade
    from com_employee e, com_department d, com_salgrade s
    where e.dno = d.dno  and e.salary between losal and hisal order by e.ename desc;
    
-- �ڿ� JOIN : �ߺ��� �����ϰ� �� ��� (���� column�� ���� �� ����)
select e.eno, e.ename, d.dname, dno
    from com_employee e natural join com_department d;
    
    
-- outer join
-- left outer join  : ���� ���̺� null�� ���� ��
select e.ename as "���", m.ename as "���ӻ��"
    from com_employee e
    left outer join com_employee m
    on e.manager = m.eno;
    
/*
A join B (������) : A ���� * B ���� (OR)
A inner join B (������) :  A�� B�� ��ġ�ϴ� ���� ������ (AND)
A left outer join B : (A + ������) B���̺� ���� Ű���� ���ؼ��� null�� ä��� (A�� B�� �ش� �� ���� �� null�Է�)
A right outer join B : (������ + B) B�� ���� A���� ���� �� B�� null �Է�
A union all B : (A�� ��� �� + B�� ����� + �ߺ� �� ����)
A union B : (A�� ��� �� + B�� ��� ��, �ߺ� �� ����)
*/

-- �ǽ�

-- join (������)
select *
    from com_employee e, com_department d
    where e.eno = 7788;
    
-- inner join (������)
select *
    from com_employee e natural join com_department d
    where e.eno = 7788;
    
-- left outer join (a -> b Ž��) 
select e.ename as "�����", m.ename as "�����ڸ�"
    from com_employee e left outer join com_employee m
    on e.manager = m.eno;
    
-- right outer join (b -> a Ž��)
select e.ename as "�����", m.ename as "�����ڸ�"
    from com_employee e right outer join com_employee m
    on e.manager = m.eno;

    
