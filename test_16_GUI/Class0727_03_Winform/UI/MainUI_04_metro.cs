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
    public partial class MainUI_04_metro : MaterialForm
    {
        public MainUI_04_metro()
        {
            InitializeComponent();
        }

        private void site_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SW-Lee31");
        }

        private void button_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button_maximum_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button_minimum_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
