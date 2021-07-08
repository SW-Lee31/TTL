using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control0708
{
    public partial class te : Form
    {
        double temp = 0;

        public te()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   ///////////////////////////////////////////////////////////////////////////////
            /////////////////////////숫자 대수비교 및 홀,짝수 판단///////////////////////////
            ///////////////////////////////////////////////////////////////////////////////
            
            // 숫자 Num_1 입력
            Console.Write("숫자(Num_1)를 입력하세요. : ");
            int Num_1 = int.Parse(Console.ReadLine());

            // 숫자 Num_2 입력
            Console.Write("숫자(Num_2)를 입력하세요. : ");
            int Num_2 = int.Parse(Console.ReadLine());
            if (Num_1 == Num_2)
            {
                Console.WriteLine("두 수의 값은 같습니다.");
                if (Num_1 % 2 == 0 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("두 숫자 모두 짝수입니다.");
                }

                else if (Num_1 % 2 == 0 && Num_2 % 2 == 1)
                {
                    Console.WriteLine("Num_1는 짝수이고, Num_2는 홀수입니다.");
                }

                else if (Num_1 % 2 == 1 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("Num_1는 홀수이고, Num_2는 짝수입니다.");
                }

                else
                {
                    Console.WriteLine("둘 다 홀수입니다.");
                }
            }

            else if (Num_1 > Num_2)
            {
                Console.WriteLine("Num_1의 값이 더 큽니다.");
                if (Num_1 % 2 == 0 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("두 숫자 모두 짝수입니다.");
                }

                else if (Num_1 % 2 == 0 && Num_2 % 2 == 1)
                {
                    Console.WriteLine("Num_1는 짝수이고, Num_2는 홀수입니다.");
                }

                else if (Num_1 % 2 == 1 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("Num_1는 홀수이고, Num_2는 짝수입니다.");
                }

                else
                {
                    Console.WriteLine("둘 다 홀수입니다.");
                }
            }

            else if (Num_1 < Num_2)
            {
                Console.WriteLine("Num_2의 값이 더 큽니다.");
                if (Num_1 % 2 == 0 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("두 숫자 모두 짝수입니다.");
                }

                else if (Num_1 % 2 == 0 && Num_2 % 2 == 1)
                {
                    Console.WriteLine("Num_1는 짝수이고, Num_2는 홀수입니다.");
                }

                else if (Num_1 % 2 == 1 && Num_2 % 2 == 0)
                {
                    Console.WriteLine("Num_1는 홀수이고, Num_2는 짝수입니다.");
                }

                else
                {
                    Console.WriteLine("둘 다 홀수입니다.");
                }
            }
            //////////////////////////////////////////////////////////////////////////
            //////////////////////////////////윤년계산////////////////////////////////
            /////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n");
            Console.WriteLine("#################################################");

            Console.Write("윤년인지 판단할 년(Year)을 입력해주세요.");
            int Year = int.Parse(Console.ReadLine());
            string output_str = string.Format("{0}년은 윤년입니다.", Year);
            string output_str_neagative = string.Format("{0}년은 윤년이 아닙니다.", Year);

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine(output_str);
            }

            else
            {
                Console.WriteLine(output_str_neagative);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal_group_Enter(object sender, EventArgs e)
        {

        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            ouput_oper.Text = "";
            double result_1 = double.Parse(num1_input.Text);
            double result_2 = double.Parse(num2_input.Text);
            temp = result_1 + result_2;
            ouput_oper.Text = "+";
            result_output.Text = temp.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            ouput_oper.Text = "";
            double result_1 = double.Parse(num1_input.Text);
            double result_2 = double.Parse(num2_input.Text);
            temp = result_1 - result_2;
            ouput_oper.Text = "-";
            result_output.Text = temp.ToString();
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            ouput_oper.Text = "";
            double result_1 = double.Parse(num1_input.Text);
            double result_2 = double.Parse(num2_input.Text);
            temp = result_1 * result_2;
            ouput_oper.Text = "x";
            result_output.Text = temp.ToString();
        }

        private void nanu_Click(object sender, EventArgs e)
        {
            ouput_oper.Text = "";
            double result_1 = double.Parse(num1_input.Text);
            double result_2 = double.Parse(num2_input.Text);
            temp = Math.Round((result_1 / result_2), 3);
            ouput_oper.Text = "÷";
            result_output.Text = temp.ToString();
        }

        private void text10_Click(object sender, EventArgs e)
        {

        }

        private void oper_button2_Click(object sender, EventArgs e)
        {
            double korean = double.Parse(kor_input.Text);
            double english = double.Parse(eng_input.Text);
            double math = double.Parse(math_input.Text);
            double society = double.Parse(soci_input.Text);
            double science = double.Parse(sci_input.Text);

            double sum_amount = korean + english + math + society + science;
            double average_amount = (korean + english + math + society + science) / 5;

            sum_result.Text = sum_amount.ToString();
            avg_result.Text = average_amount.ToString();

            if (average_amount >= 90)
            {
                level_result.Text = "A+";
            }    

            else if (average_amount >= 85)
            {
                level_result.Text = "A";
            }

            else if (average_amount >= 80)
            {
                level_result.Text = "B+";
            }

            else if (average_amount >= 75)
            {
                level_result.Text = "B";
            }

            else if (average_amount >= 70)
            {
                level_result.Text = "C+";
            }

            else if (average_amount >= 65)
            {
                level_result.Text = "C";
            }

            else
            {
                level_result.Text = "F";
            }


        }

        private void kor_input_TextChanged(object sender, EventArgs e)
        {
            double korean = double.Parse(kor_input.Text);
            if (korean > 100)
            {
                MessageBox.Show("Input value in 1 ~ 100");
            }
        }

        private void eng_input_TextChanged(object sender, EventArgs e)
        {
            double english = double.Parse(eng_input.Text);
            if (english > 100)
            {
                MessageBox.Show("Input value in 1 ~ 100");
            }
        }

        private void math_input_TextChanged(object sender, EventArgs e)
        {
            double math = double.Parse(math_input.Text);
            if (math > 100)
            {
                MessageBox.Show("Input value in 1 ~ 100");
            }
        }

        private void soci_input_TextChanged(object sender, EventArgs e)
        {
            double society = double.Parse(soci_input.Text);
            if (society > 100)
            {
                MessageBox.Show("Input value in 1 ~ 100");
            }
        }

        private void sci_input_TextChanged(object sender, EventArgs e)
        {
            double science = double.Parse(sci_input.Text);
            if (science > 100)
            {
                MessageBox.Show("Input value in 1 ~ 100");
            }
        }
    }
}
