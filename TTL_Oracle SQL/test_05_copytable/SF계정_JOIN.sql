-- JOIN :  2개 이상의 테이블에서 각각의 정보를 가져와서 합치는 것
select e.eno, e.ename, d.dname, e.dno 
from com_employee e, com_department d
where e.dno = d.dno and e.eno = 7788;

-- using 사용 (inner join)
select e.eno, e.ename, d.dname, dno
    from com_employee e join com_department d
    using(dno) where e.eno = 7788;

-- on 사용 
select e.eno, e.ename, d.dname, e.dno
    from com_employee e join com_department d
    on e.dno = d.dno where e.eno = 7788;
    
    
-- 3개의 테이블 JOIN
select e.ename, d.dname, e.salary, s.grade
    from com_employee e, com_department d, com_salgrade s
    where e.dno = d.dno  and e.salary between losal and hisal order by e.ename desc;
    
-- 자연 JOIN : 중복을 제거하고 값 출력 (공통 column을 제거 후 조인)
select e.eno, e.ename, d.dname, dno
    from com_employee e natural join com_department d;
    
    
-- outer join
-- left outer join  : 왼쪽 테이블에 null값 존재 시
select e.ename as "사원", m.ename as "직속상관"
    from com_employee e
    left outer join com_employee m
    on e.manager = m.eno;
    
/*
A join B (합집합) : A 갯수 * B 갯수 (OR)
A inner join B (교집합) :  A와 B의 일치하는 값만 가져옴 (AND)
A left outer join B : (A + 교집합) B테이블에 없는 키값에 대해서는 null로 채운다 (A에 B의 해당 값 부재 시 null입력)
A right outer join B : (교집합 + B) B에 대한 A값이 부재 시 B에 null 입력
A union all B : (A의 모든 행 + B의 모든행 + 중복 행 포함)
A union B : (A의 모든 행 + B의 모든 행, 중복 행 제거)
*/

-- 실습

-- join (합집합)
select *
    from com_employee e, com_department d
    where e.eno = 7788;
    
-- inner join (교집합)
select *
    from com_employee e natural join com_department d
    where e.eno = 7788;
    
-- left outer join (a -> b 탐색) 
select e.ename as "사원명", m.ename as "관리자명"
    from com_employee e left outer join com_employee m
    on e.manager = m.eno;
    
-- right outer join (b -> a 탐색)
select e.ename as "사원명", m.ename as "관리자명"
    from com_employee e right outer join com_employee m
    on e.manager = m.eno;

    
