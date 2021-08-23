
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle0820.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";

        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류 : {0}", e.Message);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류 : {0}", e.Message);
            }
        }

        public void create_table(string table_name, string seq_name)
        {
            try
            {
                string sql = "create table " + table_name + " (" +
                    "st_id number not null, " +
                    "constraint pk_st_id primary key(st_id), " +
                    "st_name varchar2(20) not null, " +
                    "age number not null, " +
                    "addr varchar2(80) not null" +
                    ")";

                Console.WriteLine(sql);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "create sequence " + seq_name +
                    " increment by 1 start with 1000";

                Console.WriteLine(seq);

                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블, 시퀀스 생성완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 | 시퀀스 생성 오류 : {0}", e.Message);
            }
        }

        public void drop_table(string table_name, string seq_name)
        {
            try
            {
                string sql = "drop table " + table_name;


                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "drop sequence " + seq_name;
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 | 시퀀스 삭제 오류 : {0}", e.Message);
            }
        }

        public void insert_DB(string table_name, int id_num, string name, int age, string addr, string grade)
        {
            try
            {
                string sql = string.Format("insert into {0} values ({1}, '{2}', {3}, '{4}', '{5}')",
                                table_name, id_num, name, age, addr, grade);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("정보 입력 실패 : {0}", e.Message);
            }


        }

        public void show_DB(string table_name, string column)
        {
            string sql = "select * from " + table_name + " order by " + column + " desc";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("아이디 : {0}", rd["stu_id"]);
                    Console.WriteLine("이름 : {0}", rd["stu_name"]);
                    Console.WriteLine("나이 : {0}", rd["age"]);
                    Console.WriteLine("주소 : {0}", rd["address"]);
                    Console.WriteLine("성적 : {0}", rd["grade"]);
                    Console.WriteLine("##########################################");
                }
            }
            else
            {
                Console.WriteLine("현재 데이터가 존재하지 않습니다.");
            }

            rd.Close();
        }
    }
}
