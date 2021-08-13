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
        string[] id_value;


        public Sign_in()
        {
            InitializeComponent();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

            Common.Theme_light(this);

            id_value = CSV_reader.Read_csv_id().ToArray();

            /*id_value = CSV_reader.split(CSV_reader.Read_csv_id());

            for (int i = 0; i < id_value.Length; i++)
            {
                Console.WriteLine(id_value[i]);
            }*/
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

            /*if (id_check() == true && pw_check() == true)
            {
                new Admin_main_form().Show();
            }
            
            else if (id_check() == true && pw_check() == false)
            {
                MessageBox.Show("비밀번호가 틀렸습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (id_check() == false && pw_check() == true)
            {
                MessageBox.Show("없는 아이디입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("등록되지 않은 정보입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            new Admin_main_form().Show();
        }

        private void uiLinkLabel1_Click_1(object sender, EventArgs e)
        {
            new Sign_up().Show();
        }

        /*bool id_check()
        {
            for (int i = 1; i < id_value.Length; i++)
            {
                string[] elements = CSV_reader.split(id_value[i]);

                for (int j = 0; j < elements.Length; j++)
                {
                    Console.WriteLine(elements[j]);
                }

                if (input_id.Text == elements[1])
                {
                    return true;
                }
            }

            return false;

        }*/

        /*bool pw_check()
        {
            for (int i = 1; i < id_value.Count; i++)
            {
                string[] elements = CSV_reader.split(id_value[i]);

                if (input_id.Text == elements[2])
                {
                    return true;
                }

            }

            return false;
        }*/
    }
}
