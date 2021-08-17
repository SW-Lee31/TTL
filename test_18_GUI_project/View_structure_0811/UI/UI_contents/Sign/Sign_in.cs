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
using View_structure_0811.Adapter;
using View_structure_0811.CSV;
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents.Sign
{
    partial class Sign_in : MaterialForm
    {
        string file_path_id = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Admin_id_info";

        public Sign_in()
        {
            InitializeComponent();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

            Common.Theme_light(this);
        }

        private void uiFlowLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void link_create_Click(object sender, EventArgs e)
        {
            new Sign_up().ShowDialog();
        }

        private void link_find_Click(object sender, EventArgs e)
        {

        }

        private void but_login_Click(object sender, EventArgs e)
        {
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void input_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sign_up().Show();
        }

        private void but_login_Click_1(object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string id = " " + input_id.Text;
            string pw = " " + input_pw.Text;

            List<string[]> csv_value = CSV_reader.Read_csv(file_path_id);

            if (id_check(csv_value, id) == false)
            {
                MessageBox.Show("존재하지 않는 아이디입니다.");
            }

            else if (pw_check(csv_value, pw) == false)
            {
                MessageBox.Show("일치하지 않는 비밀번호입니다.");
            }

            else
            {
                new Admin_main_form().Show();
                Close();
            }
        }

        private void uiLinkLabel1_Click_1(object sender, EventArgs e)
        {
            new Sign_up().Show();
        }

        public bool id_check(List<string[]> result, string id)
        {
            for (int i = 1; i < result.Count; i++)
            {
                if (id == result[i][1])
                {
                    return true;
                }
            }
            return false;
        }

        public bool pw_check(List<string[]> result, string pw)
        {
            for (int i = 1; i < result.Count; i++)
            {
                if (pw == result[i][2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
