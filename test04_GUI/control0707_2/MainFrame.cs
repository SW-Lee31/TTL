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
        string temp_str = "";
        string num_1 = "";
        string num_2 = "";
        string oper = "";
        string output_temp = "";


        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_button_Click(object sender, EventArgs e)
        {
            string input_button = ((Control)sender).Name.ToString();

            Console.WriteLine(input_button);

            switch (input_button)
            {
                case "num1_button":
                    output.Text = "";
                    result += "1";
                    output.Text = result;
                    break;

                case "num2_button":
                    output.Text = "";
                    result += "2";
                    output.Text = result;
                    break;

                case "num3_button":
                    output.Text = "";
                    result += "3";
                    output.Text = result;
                    break;

                case "num4_button":
                    output.Text = "";
                    result += "4";
                    output.Text = result;
                    break;

                case "num5_button":
                    output.Text = "";
                    result += "5";
                    output.Text = result;
                    break;

                case "num6_button":
                    output.Text = "";
                    result += "6";
                    output.Text = result;
                    break;

                case "num7_button":
                    output.Text = "";
                    result += "7";
                    output.Text = result;
                    break;

                case "num8_button":
                    output.Text = "";
                    result += "8";
                    output.Text = result;
                    break;

                case "num9_button":
                    output.Text = "";
                    result += "9";
                    output.Text = result;
                    break;

                case "num0_button":
                    output.Text = "";
                    result += "0";
                    output.Text = result;
                    break;

                case "clear_button":
                    output.Text = "";
                    result = "";
                    temp = 0;
                    output.Text = result;
                    break;

                case "dot_button":
/*                    if (temp != 0)
                    {
                        output_temp += ".";
                    }*/

                    output.Text = output_temp;
                    result += ".";
                    output_temp += result;
                    result = "";
                    temp = double.Parse(output_temp);
                    output.Text = output_temp;
                    break;
            }

        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            num_2 = result;
            /*            num_1 = temp.ToString();*/

            double output_num = 0;

/*            if (temp == 0)
            {
                if (oper == "+")
                {
                    temp = double.Parse(num_1) + double.Parse(num_2);
                    output_num = double.Parse(num_1) + double.Parse(num_2);
                    output_temp = temp.ToString();
                }

                else if (oper == "*")
                {
                    temp = double.Parse(num_1) * double.Parse(num_2);
                    output_num = double.Parse(num_1) * double.Parse(num_2);
                    output_temp = temp.ToString();
                }

                else if (oper == "-")
                {
                    temp = double.Parse(num_1) - double.Parse(num_2);
                    output_num = double.Parse(num_1) - double.Parse(num_2);
                    output_temp = temp.ToString();
                }

                else if (oper == "/")
                {
                    temp = Math.Round(double.Parse(num_1) / double.Parse(num_2), 3);
                    output_num = Math.Round(output_num, 3);
                    output_num = double.Parse(num_1) / double.Parse(num_2);
                    output_temp = temp.ToString();
                }
            }*/

/*            else
            {*/
                if (oper == "+")
                {
                    temp = double.Parse(num_1) + double.Parse(num_2);
                    output_num = temp;
                    output_temp = output_num.ToString();
                    output.Text = output_temp;
                }

                else if (oper == "*")
                {
                    temp = temp * double.Parse(num_2);
                    output_num = temp;
                    output_temp = output_num.ToString();
                }

                else if (oper == "-")
                {
                    temp = temp - double.Parse(num_2);
                    output_num = temp;
                    output_temp = output_num.ToString();
                }

                else if (oper == "/")
                {
                    temp = Math.Round(temp / double.Parse(num_2), 3);
                    output_num = temp;
                    output_temp = output_num.ToString();
                }
/*            }*/
            output.Text = "결과 :" + output_temp;
            num_2 = "";
            result = "";
            oper = "";
            output_num = 0;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            string dot = ".";
            bool dotcontain = output_temp.Contains(dot);

/*            if (temp == 0)
            {
                temp = double.Parse(result);
                oper = "+";
                output.Text = "+";
                result = "";
            }*/
            if (dotcontain == true)
                {
                    result = "";
                    oper = "+";
                    output.Text =  "+";
                }
            else
                {
                    temp = double.Parse(result);
                     num_1 = temp.ToString();
                     oper = "+";
                        output.Text = "+";
                     result = "";
                }
            

        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            string dot = ".";
            bool dotcontain = output_temp.Contains(dot);

           if (dotcontain == true)
            {
                num_1 = temp.ToString();
                temp = 0;
                result = "";
                oper = "-";
                output.Text = "-";
            }
           else
           {
                num_2 = temp.ToString();
                temp = 0;
                oper = "-";
                output.Text =  "-";
                result = "";
           }
        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            string dot = ".";
            bool dotcontain = output_temp.Contains(dot);

                if (dotcontain == true)
                {
                    result = "";
                    oper = "*";
                    output.Text =  "*";
                }
                else
                {
                    num_2 = temp.ToString();
                    oper = "*";
                    output.Text = "*";
                    result = "";
                }
        }


        private void na_button_Click(object sender, EventArgs e)
        {
            string dot = ".";
            bool dotcontain = output_temp.Contains(dot);

                if (dotcontain == true)
                {
                    result = "";
                    oper = "/";
                    output.Text = "/";
                }
                else
                {
                    num_2 = temp.ToString();
                    oper = "/";
                    output.Text = "/";
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

        private void route_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = Math.Round(Math.Sqrt(double.Parse(result)), 2);
                output.Text = "결과 : " + output_temp;
                result = "";
                output_temp = temp.ToString();
            }

            else
            {
                temp = Math.Round(Math.Sqrt(temp), 2);
                output.Text = "결과 : " + output_temp;
                result = "";
                output_temp = temp.ToString();
            }
        }
    }
}
