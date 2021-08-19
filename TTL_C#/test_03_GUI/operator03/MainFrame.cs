using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operator03
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

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void input_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void operate_button_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(input_amount.Text);
            
            int fivehundred = amount / 500;
            amount %= 500;
            fivehundred_ouput.Text = fivehundred.ToString();

            int hundred = amount / 100;
            amount %= 100;
            hundred_output.Text = hundred.ToString();

            int fifty = amount / 50;
            amount %= 50;
            fifty_output.Text = fifty.ToString();

            int ten = amount / 10;
            amount %= 10;
            ten_output.Text = ten.ToString();
        }
    }
}
