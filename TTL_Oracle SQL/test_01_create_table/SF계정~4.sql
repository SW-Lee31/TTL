/* 
varchar :  가변 길이 문자 데이터 (1 ~ 4000 Bytes)
varchar2 : 가변 길이 문자 데이터 (1 ~ 4000 Bytes)
char : 고정 길이 문자 데이터 (1 ~ 2000 Bytes)
number : 가변 길이 숫자 데이터
date :  날짜 (7 Bytes)
clob :  대용량 문자열 처리
blob :  이진 대형 객체 (바이너리)

DDL : create, alter, drop table
DML : CRUD
DCL : ..
*/

create table student_t (
        -- primary key : 기본키 -> 고유한 값, 참조 가능
    stu_id number not null primary key, 
    stu_name varchar2(20) not null,
    age number not null,
    address varchar2(80) not null
);

insert into student_t values (0001, '홍길동', 18, '서울시 마포구 두산동-123');

insert into student_t values (0002, '칠갑산', 17, '울산시 창호동 산-3221');

-- 테이블에 새로운 Column 추가
alter table student_t add (grade char(5));

-- auto increment -> Oracle 에서는 Sequence 라 부름 (자동 값 증가)
-- 시퀀스 생성
create sequence seq_id increment by 1 start with 3; -- 1부터 1씩 증가하는 시퀀스 seq_id 생성

insert into student_t (stu_id, stu_name, age, address) values (seq_Id.nextval, '황서방', 18, '강원도 감자골 123');

insert into student_t (stu_id, stu_name, age, address) values (seq_id.nextval, '강동순', 16, '포항시 마포동 54');

insert into student_t values (seq_id.nextval, '이철용', 19, '광주시 동구 호남동 10', 'A');

select stu_name from student_t;

-- 테이블 삭제 시에 연결된 시퀀스를 먼저 삭제해야 함 (사실 큰 상관은 없음)
-- drop sequence seq_id;

-- 테이블 삭제
-- drop table student_t;