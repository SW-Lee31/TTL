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
    class CSV_reader
    {
        static public List<string> Read_csv_personal()
        {
            StreamReader csv_person = new StreamReader(@"C:\\c#_work\\test_18_GUI_project\\View_structure_0811\\CSV\\personal_info.csv", false);

            List<string> csv_read_list = new List<string>();

            for (int row = 0; row < (Person_adapter.Personal_info_list.Count + 1); row++)
            {
                string csv_read_list_index = csv_person.ReadLine();

                csv_read_list.Add(csv_read_list_index);

                /*Console.WriteLine(csv_read_list[row]);*/
            }
            csv_person.Close();

            return csv_read_list;
        }

        static public List<string> Read_csv_id()
        {
            StreamReader csv_id = new StreamReader(@"C:\\c#_work\\test_18_GUI_project\\View_structure_0811\\CSV\\ID_info.csv", false);

            List<string> csv_id_list = new List<string>();

            while (csv_id.ReadLine() != null)
            {
                string csv_id_list_index = csv_id.ReadLine();

                csv_id_list.Add(csv_id_list_index);
            }

            for (int i = 0; i < csv_id_list.Count; i++)
            {
                Console.WriteLine(csv_id_list[i]);
            }

            csv_id.Close();

            return csv_id_list;
        }


        static public string[] split(List<string> list_value)
        {
            string[] elements = new string[list_value.Count];

            for (int i = 0; i< elements.Length; i++)
            {
                elements[i] = list_value[i].Split(',').ToString();
            }

            return elements;
        }
    }
}
