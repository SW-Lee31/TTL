using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_5
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();
        const int MEN = 5;
        const int SUBJECT = 5;
        enum Name
        {
            홍길동, 임꺽정, 장길산, 이재명, 윤석열
        }

        enum SUBJ
        { 
            국어, 영어, 수학, 사회, 과학
        }


        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[][] result = new int[MEN][];
            result = Order_point();
            int sum = 0;

            Console.WriteLine("##########################성적공개#############################");

            for (int i = 0; i < MEN; i++)
            {
                Console.Write("{0}의 성적   ", Enum.GetName(typeof(Name), i));

                for (int j = 0; j < result[i].GetLength(0); j++)
                {
                    Console.Write("{0} : {1}점, ", Enum.GetName(typeof(SUBJ), j), result[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("##########################평균 및 학점공개#############################");

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result[i].GetLength(0); j++)
                {
                    sum += result[i][j];
                }
                
                if (sum / SUBJECT >= 90)
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> A학점입니다.", Enum.GetName(typeof(Name), i),(sum / SUBJECT));
                }

                else if (sum / SUBJECT >= 80)
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> B학점입니다.", Enum.GetName(typeof(Name), i), (sum / SUBJECT));
                }

                else if (sum / SUBJECT >= 70)
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> C학점입니다.", Enum.GetName(typeof(Name), i), (sum / SUBJECT));
                }

                else if (sum / SUBJECT >= 60)
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> D학점입니다.", Enum.GetName(typeof(Name), i), (sum / SUBJECT));
                }

                else if (sum / SUBJECT >= 50)
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> E학점입니다.", Enum.GetName(typeof(Name), i), (sum / SUBJECT));
                }

                else
                {
                    Console.WriteLine("{0}의 평균은 {1}점 -> F학점입니다.", Enum.GetName(typeof(Name), i), (sum / SUBJECT));
                }

                sum = 0;
            } 
        }

        int[] Create_point()
        {
            int korean = ran.Next(30, 101);
            int english = ran.Next(20, 101);
            int math = ran.Next(15, 101);
            int society = ran.Next(40, 101);
            int science = ran.Next(30, 101);

            int[] man_score = new int[5]
            {
                korean, english, math, society, science
            };

            return man_score;
        }

        int[][] Order_point()
        {
            int[][] score_list = new int[MEN][];

            for (int i = 0; i < score_list.Length; i++)
            {
                score_list[i] = Create_point();
            }

            return score_list;
        }
    }
}
