using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_03_score
{
    public partial class MainFrame : Form
    {
        const double SUBJECT = 5;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("국어점수를 입력해주세요. : ");
            string korean = Console.ReadLine();
           
            while (Check_double(korean) == false)
            {
                Console.Write("국어점수를 입력해주세요. : ");
                korean = Console.ReadLine();
            }
            double korean_value = double.Parse(korean);

            while (Check_range(korean_value) == false)
            {
                Console.Write("국어점수를 입력해주세요. : ");
                korean_value = double.Parse(Console.ReadLine());
            }

            Console.Write("영어점수를 입력해주세요. : ");
            string english = Console.ReadLine();
            
            while (Check_double(english) == false)
            {
                Console.Write("영어점수를 입력해주세요. : ");
                english = Console.ReadLine();
            }
            double english_value = double.Parse(english);

            while (Check_range(english_value) == false)
            {
                Console.Write("영어점수를 입력해주세요. : ");
                english_value = double.Parse(Console.ReadLine());
            }

            Console.Write("수학점수를 입력해주세요. : ");
            string math = Console.ReadLine();

            while (Check_double(math) == false)
            {
                Console.Write("수학점수를 입력해주세요. : ");
                math = Console.ReadLine();
            }
            double math_value = double.Parse(math);

            while (Check_range(math_value) == false)
            {
                Console.Write("수학점수를 입력해주세요. : ");
                math_value = double.Parse(Console.ReadLine());
            }

            Console.Write("사회점수를 입력해주세요. : ");
            string society = Console.ReadLine();

            while (Check_double(society) == false)
            {
                Console.Write("사회점수를 입력해주세요. : ");
                society = Console.ReadLine();
            }
            double society_value = double.Parse(society);

            while (Check_range(society_value) == false)
            {
                Console.Write("사회점수를 입력해주세요. : ");
                society_value = double.Parse(Console.ReadLine());
            }

            Console.Write("과학점수를 입력해주세요. : ");
            string science = Console.ReadLine();

            while (Check_double(science) == false)
            {
                Console.Write("과학점수를 입력해주세요. : ");
                science = Console.ReadLine();
            }
            double science_value = double.Parse(science);

            while (Check_range(science_value) == false)
            {
                Console.Write("과학점수를 입력해주세요. : ");
                science_value = double.Parse(Console.ReadLine());
            }

            double sum_result = Sum(korean_value, english_value, math_value, society_value, science_value);
            double avg_reuslt = Avg(sum_result);

            Console.WriteLine("점수의 합은 {0}\n점수의 평균은 {1} 입니다.", sum_result, avg_reuslt);
        }

        bool Check_double(string elements)
        {
            double checksum = 0;
            bool check_double = double.TryParse(elements, out checksum);
            
            if (check_double == false)
            {
                MessageBox.Show("숫자 값인 점수를 입력해주세요.");
            }

            return check_double;
        }

        bool Check_range(double element)
        {
            bool range_check;
            if (element < 0 || element > 100)
            {
                MessageBox.Show("0 ~ 100까지의 점수를 입력해주세요.");
                range_check = false;
            }

            else
            {
                range_check = true;
            }

            return range_check;
        }

        double Sum(double korean_value, double english_value, double math_value, double society_vlaue, double science_value)
        {
            double sum = korean_value + english_value + math_value + society_vlaue + science_value;

            return sum;
        }

        double Avg(double sum)
        {
            double avg = sum / SUBJECT;

            return avg;
        }
    }
}
