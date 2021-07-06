using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operator0706_2
{
    public partial class MainForm03 : Form
    {
        public MainForm03()
        {
            InitializeComponent();
        }

        private void MainForm03_Load(object sender, EventArgs e)
        {
        }

        private void num_output_Click(object sender, EventArgs e)
        {

        }

        private void num_button_Click(object sender, EventArgs e)
        {
            int num = int.Parse(num_input.Text);
            int result = (num % 2);

            if (result == 1)
                num_output.Text = "홀수입니다.";
            else
                num_output.Text = "짝수입니다.";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void greatest_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_1 = int.Parse(greatest_1.Text);
            int num_2 = int.Parse(greatest_2.Text);
            string result = "";
            result = (num_1 > num_2) ? ">" : "<";
            greatest_output.Text = result;

            if (num_1 == num_2)
                greatest_output.Text = "=";
            
        }
    }
}
