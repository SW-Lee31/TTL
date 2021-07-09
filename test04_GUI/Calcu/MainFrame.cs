using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu
{
    public partial class MainFrame : Form
    {
        string result = "";
        double temp = 0;
        string num_1 = "";
        string num_2 = "";
        string oper = "";

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num2_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "2";
            output.Text = result;
        }

        private void num3_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "3";
            output.Text = result;
        }

        private void num4_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "4";
            output.Text = result;
        }

        private void num5_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "5";
            output.Text = result;
        }

        private void num6_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "6";
            output.Text = result;
        }

        private void num7_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "7";
            output.Text = result;
        }

        private void num8_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "8";
            output.Text = result;
        }

        private void num9_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "9";
            output.Text = result;
        }

        private void num0_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "0";
            output.Text = result;
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
