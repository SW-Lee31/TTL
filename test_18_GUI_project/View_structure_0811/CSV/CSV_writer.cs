using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_structure_0811.Adapter;
using View_structure_0811.Model;

namespace View_structure_0811.CSV
{
    class CSV_writer
    {
        static public void Load_csv_personal(string file_path_personal_info)
        {
            StreamWriter csv_person = new StreamWriter(file_path_personal_info, false, Encoding.UTF8);

            csv_person.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
               "번호", "이름", "전화번호", "주소", "가입날짜", "성별");

            for (int i = 0; i < Person_adapter.Personal_info_list.Count; i++)
            {
                csv_person.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
                                        i + 1,
                                        Person_adapter.Personal_info_list[i].Name,
                                        Person_adapter.Personal_info_list[i].Digit,
                                        Person_adapter.Personal_info_list[i].Addr,
                                        Person_adapter.Personal_info_list[i].Date,
                                        Person_adapter.Personal_info_list[i].Gender);
            }
            csv_person.Close();
        }

        static public void Load_csv_id(string file_path_id_info)
        {
            StreamWriter csv_id = new StreamWriter(file_path_id_info, false, Encoding.UTF8);

            csv_id.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
               "번호", "ID", "Password", "이름", "전화번호", "주소");

            for (int i = 0; i < Id_adapter.Id_list.Count; i++)
            {
                csv_id.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
                                        i + 1,
                                        Id_adapter.Id_list[i].Id,
                                        Id_adapter.Id_list[i].Password,
                                        Id_adapter.Id_list[i].Name,
                                        Id_adapter.Id_list[i].Digit,
                                        Id_adapter.Id_list[i].Addr);
            }
            csv_id.Close();
        }

        static public void Load_csv_member(string file_path_member_info)
        {
            StreamWriter csv_id = new StreamWriter(file_path_member_info, false, Encoding.UTF8);

            csv_id.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
               "번호", "이름", "전화번호", "주소", "가입날짜", "성별", "고객번호");

            for (int i = 0; i < Member_adapter.Member_list.Count; i++)
            {
                csv_id.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                                        i + 1,
                                        Member_adapter.Member_list[i].Name1,
                                        Member_adapter.Member_list[i].Digit1,
                                        Member_adapter.Member_list[i].Addr1,
                                        Member_adapter.Member_list[i].Date1,
                                        Member_adapter.Member_list[i].Gender1,
                                        Member_adapter.Member_list[i].Member_digit);
            }
            csv_id.Close();
        }


    }
}
