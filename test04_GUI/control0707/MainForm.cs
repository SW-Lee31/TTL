using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control0707
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 폼이 화면에 보여지기 직전에 실행되는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*// 단일 If문 
            int num = 100;

            if (num <= 100)
            {
                Console.WriteLine("{0}(은)는 100보다 작거나 같다.", num);
            }

            // If - else 문
            int num2 = 200;

            if (num2 < 100)
            {
                Console.WriteLine("{0}(은)는 100보다 작다.", num2);
            }

            else
            {
                Console.WriteLine("{0}(은)는 100보다 크다.", num2);
            }

            // If - else if - (else) 문

            Console.WriteLine("현재시간은 " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 식사 시간");
            }

            else if (DateTime.Now.Hour < 14) 
            {
                Console.WriteLine("점심 식사 시간");
            }

            else
            {
                Console.WriteLine("저녁 식사 시간");
            }*/

            ///////////////////////////////////////////////////////////////////////
            ////////////////////////////홀,짝수 판단///////////////////////////////
            //////////////////////////////////////////////////////////////////////
       /*     Console.WriteLine("######################홀,짝수 판단############################");
            Console.WriteLine("숫자를 입력하세요.");
            int input_num = int.Parse(Console.ReadLine());

            if (input_num % 2 == 1)
            {
                string str = string.Format("{0}(은)는 홀수입니다.", input_num);
                Console.WriteLine(str);
            }

            else
            {
                string str = string.Format("{0}(은)는 짝수입니다.", input_num);
                Console.WriteLine(str);
            }*/

            ///////////////////////////////////////////////////////////////////////
            ////////////////////////////대수비교///////////////////////////////////
            //////////////////////////////////////////////////////////////////////
            /*Console.WriteLine("######################대수비교############################");
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            int input_num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력하세요.");
            int input_num2 = int.Parse(Console.ReadLine());

            if (input_num1 > input_num2)
            {
                Console.WriteLine("{0}(은)는 {1}보다 큽니다.", input_num1, input_num2);
            }

            else if (input_num1 < input_num2)
            {
                Console.WriteLine("{0}(은)는 {1}보다 작습니다.", input_num1, input_num2);
            }

            else
            {
                Console.WriteLine("{0}(은)는 {1}과 같습니다.", input_num1, input_num2);
            }
            */



        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void operate_Click(object sender, EventArgs e)
        {
            double korean = double.Parse(korean_input.Text);
            double english = double.Parse(english_input.Text);
            double math = double.Parse(math_input.Text);
            double society = double.Parse(society_input.Text);
            double science = double.Parse(science_input.Text);

            double sum_result = korean + english + math + society + science;
            double avearga_result = (korean + english + math + society + science) / 5;
            string level_result = "";

            if (avearga_result > 90)
            {
                level_result = "A";
            }

            else if (avearga_result > 80)
            {
                level_result = "B";
            }

            else if (avearga_result > 70)
            {
                level_result = "C";
            }

            else if (avearga_result > 60)
            {
                level_result = "D";
            }

            else
            {
                level_result = "F";
            }

            sum.Text = sum_result.ToString();
            average.Text = avearga_result.ToString();
            level.Text = level_result;

        }

        private void korean_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(korean_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100까지의 점수를 입력해주세요.");
            }
        }

        private void english_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(english_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100까지의 점수를 입력해주세요.");
            }
        }

        private void math_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(math_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100까지의 점수를 입력해주세요.");
            }
        }

        private void society_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(society_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100까지의 점수를 입력해주세요.");
            }
        }

        private void science_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(science_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100까지의 점수를 입력해주세요.");
            }
        }
    }
}
