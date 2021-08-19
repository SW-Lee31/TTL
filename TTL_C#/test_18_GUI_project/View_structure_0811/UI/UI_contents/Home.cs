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
using View_structure_0811.UI.Order_contents;
using View_structure_0811.UI.UI_contents.Sign;

namespace View_structure_0811.UI.UI_contents
{
    partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void uiHeaderButton1_Click(object sender, EventArgs e)
        {

        }

        private void link_homepage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SW-Lee31");
        }

        private void but_admin_Click(object sender, EventArgs e)
        {
            new Sign_in().ShowDialog();
        }

        private void uiHeaderButton1_Click_1(object sender, EventArgs e)
        {
            new Order_Main().Show();
        }
    }
}
