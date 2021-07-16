using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_8_score_operate
{
    public partial class MainFrame : Form
    {
        const int SUBJECT = 5;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            double[] result_arr = new double[2];
            result_arr = sum_avg(subject_input());
            double sum = result_arr[0];
            double avg = result_arr[1];

            Console.WriteLine("###### 점수의 총합은 {0}, 점수의 평균은 {1} 입니다. #######", sum, avg);
        }

        double[] subject_input()
        {
            double korean = 0;
            double english = 0;
            double math = 0;
            double society = 0;
            double science = 0;

            Console.Write("국어 점수를 입력해주세요. : ");
            string korean_input = Console.ReadLine();

            while (check_double(korean_input) == false || (double.Parse(korean_input) < 0) || (double.Parse(korean_input) > 100))
            {
                Console.Write("국어 점수(숫자)를 다시 입력해주세요. : ");
                korean_input = Console.ReadLine();
            }

            korean = double.Parse(korean_input);

            Console.Write("영어 점수를 입력해주세요. : ");
            string english_input = Console.ReadLine();

            while (check_double(english_input) == false || (double.Parse(english_input) < 0) || (double.Parse(english_input) > 100))
            {
                Console.Write("영어 점수(숫자)를 다시 입력해주세요. : ");
                english_input = Console.ReadLine();
            }

            english = double.Parse(english_input);

            Console.Write("수학 점수를 입력해주세요. : ");
            string math_input = Console.ReadLine();

            while (check_double(math_input) == false || (double.Parse(math_input) < 0) || (double.Parse(math_input) > 100))
            {
                Console.Write("수학 점수(숫자)를 다시 입력해주세요. : ");
                math_input = Console.ReadLine();
            }

            math = double.Parse(math_input);

            Console.Write("사회 점수를 입력해주세요. : ");
            string society_input =Console.ReadLine();

            while (check_double(society_input) == false || (double.Parse(society_input) < 0) || (double.Parse(society_input) > 100))
            {
                Console.Write("사회 점수(숫자)를 다시 입력해주세요. : ");
                society_input = Console.ReadLine();
            }

            society = double.Parse(society_input);

            Console.Write("과학 점수를 입력해주세요. : ");
            string science_input = Console.ReadLine();

            while (check_double(science_input) == false || (double.Parse(science_input) < 0) || (double.Parse(science_input) > 100))
            {
                Console.Write("과학 점수(숫자)를 다시 입력해주세요. : ");
                science_input = Console.ReadLine();
            }

            science = double.Parse(science_input);

            double[] subject = new double[SUBJECT]
            {
                korean, english, math, society, science
            };

            return subject;
        }

        bool check_double(string element)
        {
            double checksum = 0;
            bool check_double = double.TryParse(element.ToString(), out checksum);

            /*Console.WriteLine(check_double);*/
            return check_double;
        }

        double[] sum_avg(double[] subject)
        {
            double[] sum_avg = new double[2];
            double sum = 0;



            for (int i = 0; i < subject.Length; i++)
            {
                sum += subject[i];
            }


            sum_avg[0] = sum;

            double avg = sum / SUBJECT;
            sum_avg[1] = avg;

            return sum_avg;
        }
    }
}
