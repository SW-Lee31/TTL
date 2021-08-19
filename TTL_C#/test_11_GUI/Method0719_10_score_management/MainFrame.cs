using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_10_score_management
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();
        const int PEOPLE = 5;
        const int SUBJECT = 6;
        enum PERSON_NAME
        {
            강일식, 김두식, 이삼식, 박사식, 최오식
        }

        enum SUBJECT_NAME
        {
            국어, 영어, 수학, 사회, 과학, 국사
        }

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            double[][] score_list = new double[PEOPLE][];

            for (int i = 0; i < PEOPLE; i++)
            {
               score_list[i] =  Person_record();
            }

            Console.WriteLine();
            Console.WriteLine("#################### 점수 공개 #######################");
            Console.WriteLine();

            for (int i = 0; i < score_list.Length; i++)
            {
                Console.Write("{0}의 점수입니다. --> ", Enum.GetName(typeof(PERSON_NAME), i));
                for (int j = 0; j < score_list[i].Length; j++)
                {
                    Console.Write("{0} : {1} 점    ", Enum.GetName(typeof(SUBJECT_NAME), j), score_list[i][j]);
                }
                Console.WriteLine();
            }

            double[] sum_arr = Score_sum(score_list);
            double[] avg_arr = Score_avg(sum_arr);

            Console.WriteLine();
            Console.WriteLine("#################### 점수 합산 #######################");
            Console.WriteLine();

            for (int i = 0; i < sum_arr.Length; i++)
            {
                Console.WriteLine("{0}의 점수 합산 : {1} 점", Enum.GetName(typeof(PERSON_NAME), i), sum_arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("#################### 점수 평균 #######################");
            Console.WriteLine();

            for (int i = 0; i < avg_arr.Length; i++)
            {
                Console.WriteLine("{0}의 점수 평균 : {1} 점", Enum.GetName(typeof(PERSON_NAME), i), avg_arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("#################### 학점 결과 #######################");
            Console.WriteLine();
            Score_decision(avg_arr);
        }

        double Create_score()
        {
            double score = ran.Next(45, 100);

            return score;
        }

        double[] Person_record()
        {
            double[] man_record = new double[SUBJECT];

            for (int i = 0; i < SUBJECT; i++)
            {
                man_record[i] = Create_score();
            }

            return man_record;
        }

        double[] Score_sum(double[][] score_list)
        {
            double[] sum_arr = new double[PEOPLE];

            for (int i = 0; i < score_list.Length; i++)
            {
                for (int j = 0; j < score_list[i].Length; j++)
                {
                    sum_arr[i] += score_list[i][j];
                }
            }

            return sum_arr;
        }

        double[] Score_avg(double[] sum_arr)
        {
            double[] avg_arr = new double[PEOPLE];

            for (int i = 0; i < avg_arr.Length; i++)
            {
                avg_arr[i] = Math.Round((sum_arr[i] / SUBJECT), 3);
            }

            return avg_arr;
        }

        void Score_decision(double[] avg_arr)
        {
            for (int i = 0; i < PEOPLE; i++)
            {
                if (avg_arr[i] >= 85)
                {
                    Console.WriteLine("{0}의 점수는 \"{1}\"입니다. ", Enum.GetName(typeof(PERSON_NAME), i), "A");
                }

                else if (avg_arr[i] >= 75)
                {
                    Console.WriteLine("{0}의 점수는 \"{1}\"입니다. ", Enum.GetName(typeof(PERSON_NAME), i), "B");
                }

                else if (avg_arr[i] >= 65)
                {
                    Console.WriteLine("{0}의 점수는 \"{1}\"입니다. ", Enum.GetName(typeof(PERSON_NAME), i), "C");
                }

                else if (avg_arr[i] >= 55)
                {
                    Console.WriteLine("{0}의 점수는 \"{1}\"입니다. ", Enum.GetName(typeof(PERSON_NAME), i), "D");
                }

                else
                {
                    Console.WriteLine("{0}의 점수는 \"{1}\"입니다. ", Enum.GetName(typeof(PERSON_NAME), i), "F");
                }
            }
        }



    }





    
}
