using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control0707_2
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

        private void num1_button_Click(object sender, EventArgs e)
        {
            output.Text = "";
            result += "1";
            output.Text = result;
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

        private void equal_button_Click(object sender, EventArgs e)
        {
            num_2 = result;
            double output_num = 0;

            if (temp == 0)
            { 
                if (oper == "+")
                {
                    temp = double.Parse(num_1) + double.Parse(num_2);
                    output_num = double.Parse(num_1) + double.Parse(num_2);
                }

                else if (oper == "*")
                {
                    temp = double.Parse(num_1) * double.Parse(num_2);
                    output_num = double.Parse(num_1) * double.Parse(num_2);
                }

                else if (oper == "-")
                {
                    temp = double.Parse(num_1) - double.Parse(num_2);
                    output_num = double.Parse(num_1) - double.Parse(num_2);
                }

                else if (oper == "/")
                {
                    temp = Math.Round(double.Parse(num_1) / double.Parse(num_2), 3);
                    output_num = Math.Round(output_num, 3);
                    output_num = double.Parse(num_1) / double.Parse(num_2);
                }
            }

            else
            {
                if (oper == "+")
                {
                    temp = temp + double.Parse(num_2);
                    output_num = temp;
                }

                else if (oper == "*")
                {
                    temp = temp * double.Parse(num_2);
                    output_num = temp;
                }

                else if (oper == "-")
                {
                    temp = temp - double.Parse(num_2);
                    output_num = temp;
                }

                else if (oper == "/")
                {
                    temp = Math.Round(temp / double.Parse(num_2), 3);
                    output_num = temp;
                }
            }
            output.Text = "결과 :" + output_num.ToString();
            num_1 = "";
            num_2 = "";
            result = "";
            oper = "";
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = double.Parse(result);
                oper = "+";
                output.Text = result + "+";
                result = "";
            }

            else
            {
                num_2 = result;
                oper = "+";
                output.Text = result + "+";
                result = "";
            }

        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = double.Parse(result);
                oper = "-";
                output.Text = result + "-";
                result = "";
            }
            
            else
            {
                num_2 = result;
                oper = "-";
                output.Text = result + "-";
                result = "";
            }

        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = double.Parse(result);
                oper = "*";
                output.Text = result + "x";
                result = "";
            }

            else
            {
                num_2 = result;
                oper = "*";
                output.Text = result + "*";
                result = "";
            }
        }


        private void na_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = double.Parse(result);
                oper = "/";
                output.Text = result + "÷";
                result = "";
            }

            else
            {
                num_2 = result;
                oper = "/";
                output.Text = result + "/";
                result = "";
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
