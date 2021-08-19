using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace split0713
{
    public partial class MainFrame : Form
    {
        string input_value = "";
        double num_1 = 0;
        double num_2 = 0;
        string oper = "";
        double temp = 0;
        

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
 
        }

        private void num1_button_Click(object sender, EventArgs e)
        {
            string input_button = ((Control)sender).Name.ToString();

            Console.WriteLine(input_button);

            switch (input_button)
            {
                case "num1_button":
                    input_value += "1";
                    output.Text = input_value;
                    break;

                case "num2_button":
                    input_value += "2";
                    output.Text = input_value;
                    break;

                case "num3_button":
                    input_value += "3";
                    output.Text = input_value;
                    break;

                case "num4_button":
                    input_value += "4";
                    output.Text = input_value;
                    break;

                case "num5_button":
                    input_value += "5";
                    output.Text = input_value;
                    break;

                case "num6_button":
                    input_value += "6";
                    output.Text = input_value;
                    break;

                case "num7_button":
                    input_value += "7";
                    output.Text = input_value;
                    break;

                case "num8_button":
                    input_value += "8";
                    output.Text = input_value;
                    break;

                case "num9_button":
                    input_value += "9";
                    output.Text = input_value;
                    break;

                case "num0_button":
                    input_value += "0";
                    output.Text = input_value;
                    break;

                case "clear_button":
                    temp = 0;
                    num_1 = 0;
                    num_2 = 0;
                    input_value = "";
                    output.Text = "";
                    break;

                case "dot_button":
                    input_value += ".";
                    output.Text = input_value;
                    break;
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            if (temp  == 0)
            {
                input_value += " +";
            }

            else
            {
                input_value += "+ ";
            }

            output.Text = input_value;

            string[] words = input_value.Split(' ');

            if (words[1] == "+")
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }

                if (temp == 0)
                {
                    num_1 = double.Parse(words[0]);
                    Console.WriteLine("num_1 = {0}, oper = {1}", num_1, oper);
                }
            }

            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }
            }
            input_value = "";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                input_value += " -";
            }

            else
            {
                input_value += "- ";
            }

            output.Text = input_value;


            string[] words = input_value.Split(' ');

            if (words[1] == "-")
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }

                if (temp == 0)
                {
                    num_1 = double.Parse(words[0]);
                    Console.WriteLine("num_1 = {0}, oper = {1}", num_1, oper);
                }
            }

            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }
            }
            input_value = "";
        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                input_value += " x";
            }

            else
            {
                input_value += "x ";
            }

            output.Text = input_value;


            string[] words = input_value.Split(' ');

            if (words[1] == "x")
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }

                if (temp == 0)
                {
                    num_1 = double.Parse(words[0]);
                    Console.WriteLine("num_1 = {0}, oper = {1}", num_1, oper);
                }
            }

            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }
            }
            input_value = "";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            num_2 = double.Parse(input_value);
            input_value = "";

            if (temp == 0)
            {
                switch (oper)
                {
                    case "+":
                        temp = num_1 + num_2;
                        break;

                    case "-":
                        temp = num_1 - num_2;
                        break;

                    case "*":
                        temp = num_1 * num_2;
                        break;

                    case "/":
                        temp = Math.Round((num_1 / num_2), 3);
                        break;
                }
                output.Text = "결과는 : " + temp;
                num_2 = 0;
            }

            else
            {
                switch (oper)
                {
                    case "+":
                        temp += num_2;
                        break;

                    case "-":
                        temp -= num_2;
                        break;

                    case "*":
                        temp *= num_2;
                        break;

                    case "/":
                        temp = Math.Round((temp / num_2), 3);
                        break;
                }
                output.Text = "결과는 : " + temp;
                num_2 = 0;
                oper = "";
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                input_value += " ÷";
            }

            else
            {
                input_value += "÷ ";
            }

            output.Text = input_value;

            string[] words = input_value.Split(' ');

            if (words[1] == "÷")
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }

                if (temp == 0)
                {
                    num_1 = double.Parse(words[0]);
                    Console.WriteLine("num_1 = {0}, oper = {1}", num_1, oper);
                }
            }

            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("<{0}>", word);
                    switch (word)
                    {
                        case "+":
                            oper = "+";
                            break;

                        case "-":
                            oper = "-";
                            break;

                        case "x":
                            oper = "*";
                            break;

                        case "÷":
                            oper = "/";
                            break;
                    }
                }
            }
            input_value = "";
        }

        private void route_button_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                num_1 = int.Parse(input_value);
                temp = Math.Round(Math.Sqrt(num_1), 3);
                num_1 = 0;
            }

            else
            {
                temp = Math.Round(Math.Sqrt(temp), 3);
            }

            output.Text = "결과는 : " + temp.ToString();
        }
    }
}
