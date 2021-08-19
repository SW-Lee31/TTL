using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control0707_3
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void operation_button_Click(object sender, EventArgs e)
        {
            int year = int.Parse(input.Text);
            string str = string.Format("{0}년은 윤년입니다.", year);

            if ((year % 4) == 0 && (year % 100) != 0)
            {
                output.Text = str;
            }

            else if ((year % 400) == 0)
            {
                output.Text = str;
            }

            else
            {
                output.Text = year + "년은 윤년이 아닙니다.";
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }
    }
}
