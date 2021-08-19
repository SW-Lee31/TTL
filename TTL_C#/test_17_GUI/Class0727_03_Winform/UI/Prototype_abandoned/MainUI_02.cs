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
    public partial class MainUI_02 : MaterialForm

    {
        public MainUI_02()
        {
            InitializeComponent();
        }

        private void MainUI_02_Load(object sender, EventArgs e)
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
    }
}
