using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input_03
{
    public partial class MainForm_02 : Form
    {
        public MainForm_02()
        {
            InitializeComponent();
        }

        private void MainForm_02_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to Exit?");
            Application.Exit();
        }

        private void t_temp_to_c_temp_Click(object sender, EventArgs e)
        {
            double t_temp = double.Parse(t_temp_input.Text);
            double value_c = (t_temp / 1.8) - 32;
            c_temp_value.Text = value_c.ToString();
        }

        private void c_temp_to_t_temp_Click(object sender, EventArgs e)
        {
            double c_temp = double.Parse(c_temp_input.Text);
            double value_t = 32 + (1.8 * c_temp);
            t_temp_value.Text = value_t.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
