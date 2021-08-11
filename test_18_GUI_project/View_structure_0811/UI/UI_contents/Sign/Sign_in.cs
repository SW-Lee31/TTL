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
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents.Sign
{
    public partial class Sign_in : MaterialForm
    {
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
            new Admin_main_form().Show();
        }

        private void uiLinkLabel1_Click_1(object sender, EventArgs e)
        {
            new Sign_up().Show();
        }
    }
}
