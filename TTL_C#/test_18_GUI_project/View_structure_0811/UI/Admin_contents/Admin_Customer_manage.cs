using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.Adapter;
using View_structure_0811.CSV;
using View_structure_0811.Model;

namespace View_structure_0811.UI.UI_contents
{ 
    public partial class Admin_Customer_manage : UserControl
    {
        string file_path_personal = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Personal_info.csv";
        string file_path_member = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Member_info.csv";

        public Admin_Customer_manage()
        {
            InitializeComponent();
        }

        private void Admin_Customer_manage_Load(object sender, EventArgs e)
        {
            List<string[]> csv_value_personal = CSV_reader.Read_csv(file_path_personal);

            for (int i = 1; i < csv_value_personal.Count; i++)
            {
                output_cusname.Items.Add(csv_value_personal[i][1]);
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            List<string[]> csv_value_personal = CSV_reader.Read_csv(file_path_personal);

            for (int i = 1; i < csv_value_personal.Count; i++)
            {
                if (output_cusname.Text == csv_value_personal[i][1])
                {
                    output_addr.Text = csv_value_personal[i][3];
                    output_birth.Text = csv_value_personal[i][4];
                    output_digit.Text = csv_value_personal[i][2];
                    output_gender.Text = csv_value_personal[i][5];
                }
            }
        }

        private void cus_but_submit_Click(object sender, EventArgs e)
        {
            List<string[]> csv_value_personal = CSV_reader.Read_csv(file_path_personal);

            string member_digit = input_mem_digit.Text;
            Member member_index;

            for (int i = 0; i < csv_value_personal.Count; i++)
            {
                if (output_cusname.Text == csv_value_personal[i][1])
                {
                    member_index = new Member(csv_value_personal[i][1],
                        csv_value_personal[i][2], csv_value_personal[i][3],
                        csv_value_personal[i][5], csv_value_personal[i][4],
                        member_digit);

                    Member_adapter.Add_list(member_index);
                }
            }

            Member_adapter.print_member_list();
            CSV_writer.Load_csv_member(file_path_member);
        }
    }
}
