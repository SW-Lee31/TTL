using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input0705_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("     Form is in loading.. \npush the 'Submit' button");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to quit?");
            Application.Exit();
        }

        private void label_output_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(input_value.Text);
            double result = radius * radius * 3.14;
            output_value.Text = result.ToString();
        }

        private void summary_Click(object sender, EventArgs e)
        {

        }

        private void input_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_value_Click(object sender, EventArgs e)
        {

        }
    }
}
