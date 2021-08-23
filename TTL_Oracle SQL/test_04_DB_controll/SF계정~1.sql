"create table " + table_name + " (" +
                    "st_id number not null, " +
                    "constraint pk_st_id primary key(st_id), " +
                    "st_name varchar2(20) not null, " +
                    "age number not null, " +
                    "addr varchar2(80) not null" +
                    ")";