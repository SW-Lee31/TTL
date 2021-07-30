using Class0727_03_Winform.Adapter;
using Class0727_03_Winform.Util;
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

namespace Class0727_03_Winform.UI
{
    public partial class MainUI_03 : MaterialForm
    {
        CusAdpater cusadp = new CusAdpater();

        public MainUI_03()
        {
            InitializeComponent();
        }

        private void MainUI_03_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_maximum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void site_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SW-Lee31");
        }

        private void but_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tMade by SW-Lee31\n\t\tCreated on 2021-07-28\nLicense and authority about project are on SW-Lee31");
        }

        private void uiHeaderButton1_Click(object sender, EventArgs e)
        {

        }

        private void but_admin_Click(object sender, EventArgs e)
        {
            new Sign_in().ShowDialog();
        }

        private void but_personal_info_Click(object sender, EventArgs e)
        {
            new Personal_info(cusadp).Show();

            /*cusadp.Show_cus_list_added_info();*/
            /*MainUI_02 personal_info = new MainUI_02();*/
            // 기존의(전) 창을 선택 X - focus가 자기자신에게만 해당
            /*personal_info.ShowDialog();*/
        }

        private void but_add_customer_Click(object sender, EventArgs e)
        {
            new Add_customer(cusadp).Show();
        }

        private void but_add_car_Click(object sender, EventArgs e)
        {
            new Add_car().Show();
        }

        private void but_car_salary_Click(object sender, EventArgs e)
        {
            new Salary_info().Show();
        }
    }
}
