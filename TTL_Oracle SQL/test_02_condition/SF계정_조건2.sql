create table student_db(
    st_id number not null,
    constraint pk_st_id primary key(st_id),
    
    st_name varchar2(20) not null,
    age number not null,
    constraint age_ck check (7 < age and age <= 19),
    
    addr varchar2(80) not null
);

create sequence st_seq_id increment by 1 start with 1000;

insert into student_db (st_id, st_name, age, addr) values (st_seq_id.nextval, '칠갑산', 19, '대구시 달서구 호산동 - 142');

update student_db set gender = 'Male' where st_name = '칠갑산';

alter table student_db add (grade char(8) constraint grade_ck check (grade in ('A', 'B', 'C', 'D', 'F')));

update student_db set grade = 'B' where st_name = '칠갑산';

insert into student_db values (st_seq_id.nextval, '황봉석', 16, '서울시 마포구 도원동 - 122', 'Male', 'A');
insert into student_db values (st_seq_id.nextval, '김경범', 14, '서울시 마포구 도원동 - 122', 'Female', 'B');
insert into student_db values (st_seq_id.nextval, '최동훈', 15, '서울시 마포구 도원동 - 122', 'Female', 'F');
insert into student_db values (st_seq_id.nextval, '강동훈', 11, '서울시 마포구 도원동 - 122', 'Female', 'F');
insert into student_db values (st_seq_id.nextval, '황정운', 12, '서울시 마포구 도원동 - 122', 'Male', 'B');
insert into student_db values (st_seq_id.nextval, '황봉석', 17, '서울시 마포구 도원동 - 122', 'Female', 'A');
insert into student_db values (st_seq_id.nextval, '최태민', 19, '서울시 마포구 도원동 - 122', 'Female', 'C');
insert into student_db values (st_seq_id.nextval, '구자현', 10, '서울시 마포구 도원동 - 122', 'Male', 'D');

-- '황봉석', '박봉석', '가나다라봉석', 'avdxx봉석' 등 검색
select * from student_db where st_name like '%봉석';

-- '황봉석', '최봉석' 등 앞에 한 글자 '_ _산' --> 산앞에 아무 글자 두 글자 검색
select * from student_db where st_name like '__산';

-- 오름차순으로 정렬 asc (생략 가능)
select * from student_db order by st_name asc;

-- 앞의 것을 먼저 정렬 후 정렬된 앞의 것이 동일하면 뒤의 정렬 시행
select * from student_db order by st_name desc, age asc;


