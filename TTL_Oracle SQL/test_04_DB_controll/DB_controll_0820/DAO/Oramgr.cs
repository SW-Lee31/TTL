using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_controll_0820.DAO
{
    class Oramgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";

        OracleConnection connect;
        OracleCommand cmd;
        static Oramgr instance;

        public static Oramgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Oramgr();
                }
                return instance;
            }
        }

        public Oramgr()
        {
            Console.WriteLine("오라클 객체 생성완료");
            connect = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        ~Oramgr()
        {
            Console.WriteLine("오라클 객체 소멸완료");
            close_DB();
        }

        public void connect_DB()
        {
            try
            {
                connect.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류 : {0}", e.Message);
            }
        }

        public void close_DB()
        {
            try
            {
                if (connect != null)
                {
                    connect.Close();
                    Console.WriteLine("오라클 접속 해체완료");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류 : {0}", e.Message);
            }
        }

        public void create_table(string table_name)
        {
            try
            {
                string sql = string.Format("create table {0}(" +
                    "celebrate number primary key, " +
                    "effect number not null, " +
                    "develop number not null, " +
                    "fuct varchar2(80) not null" +
                    ")", table_name);

                cmd.Connection = connect;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 생성완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 오류 : {0}", e.Message);
            }
        }

        public void create_sequence()
        {
            try
            {
                string seq = "create sequence seque_id_value increment by 1 start with 1000";

                cmd.Connection = connect;
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();

                Console.WriteLine("시퀀스 생성완료");
            }
            catch (OracleException e)
            {
                Console.WriteLine("시퀀스 생성오류 : {0}", e.Message);
            }
        }

        public void update_DB(string table_name, string element, string value, string nf_element, 
            string nf_value)
        {
            string sql = string.Format("update {0} set {1} = {2} where {3} = {4}",
                table_name, element, value, nf_element, nf_value);

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void delete_DB(string table_name, string nf_element, string nf_value)
        {
            string sql = string.Format("delete from {0} where {1} = {2}",
                table_name, nf_element, nf_value);

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void drop_table(string table_name)
        {
            string sql = string.Format("drop table {0}", table_name);

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void insert_DB(string table_name, string celebrate, int effect, int develop, string fuct)
        {
            string sql = string.Format("insert into {0} values (" +
                "'{1}', {2}, {3}, '{4}')", table_name, celebrate, effect, develop, fuct);

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void show_DB(string table_name, string column, string option)
        {
            string sql = "select * from " + table_name + " order by " + column + " " + option;

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("셀레브레이트명 : {0}", rd["celebrate"]);
                    Console.WriteLine("영향력 : {0}", rd["effect"]);
                    Console.WriteLine("성장치 : {0}", rd["develop"]);
                    Console.WriteLine("기능 : {0}", rd["fuct"]);
                    Console.WriteLine("##########################################");
                }
            }
            else
            {
                Console.WriteLine("현재 데이터가 존재하지 않습니다.");
            }

            rd.Close();
        }

        public void show_DB(string table_name)
        {
            string sql = "select * from " + table_name;

            cmd.Connection = connect;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Console.WriteLine("셀레브레이트명 : {0}", rd["celebrate"]);
                    Console.WriteLine("영향력 : {0}", rd["effect"]);
                    Console.WriteLine("성장치 : {0}", rd["develop"]);
                    Console.WriteLine("기능 : {0}", rd["fuct"]);
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
