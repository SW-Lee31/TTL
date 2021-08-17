using MaterialSkin.Controls;
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
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents.Add_person_name_search
{
    public partial class Add_person_name_search : MaterialForm
    {
        string file_path_pesonal = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Member_info.csv";

        public Add_person_name_search()
        {
            InitializeComponent();
        }

        private void Add_person_name_search_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            List<string[]> csv_value_member = CSV_reader.Read_csv(file_path_pesonal);

            string input_value = "  " + input_name.Text;

            for (int i = 1; i < csv_value_member.Count; i++)
            {
                if (input_value == csv_value_member[i][1])
                {
                    output_memberdigit.Text = csv_value_member[i][6];
                }
            }
        }
    }
}
