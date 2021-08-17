using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.CSV;

namespace View_structure_0811.UI.UI_contents
{
    public partial class Search_person : UserControl
    {
        string file_path_member = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Member_info.csv";

        public Search_person()
        {
            InitializeComponent();
        }

        private void link_name_search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Add_person_name_search.Add_person_name_search().Show();
        }

        private void output_addr_Click(object sender, EventArgs e)
        {

        }

        private void Search_person_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            List<string[]> csv_value_member = CSV_reader.Read_csv(file_path_member);

            for (int i = 0; i < csv_value_member.Count; i++)
            {
                for (int j = 0; j < csv_value_member[i].Length; j++)
                {
                    Console.Write(csv_value_member[i][j] + "/");
                }
                Console.WriteLine();
            }

            string input_value = " " + input_memberdigit.Text;

            for (int i = 1; i < csv_value_member.Count; i++)
            {
                if (input_value == csv_value_member[i][6])
                {
                    output_name.Text = csv_value_member[i][1];
                    output_digit.Text = csv_value_member[i][2];
                    output_addr.Text = csv_value_member[i][3];
                    output_birth.Text = csv_value_member[i][4];
                    output_gender.Text = csv_value_member[i][5];
                }
            }
            
        }
    }
}
