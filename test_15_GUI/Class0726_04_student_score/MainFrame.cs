using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726_04_student_score
{
    public partial class MainFrame : Form
    {
        int student_number = 5;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            Score[] student_list = new Score[student_number];
            

            for (int i = 0; i < student_number; i++)
            {
                Student student_name = new Student(ran.Next(10), ran.Next(10), ran.Next(10));
                int korean = ran.Next(35, 101);
                int english = ran.Next(40, 101);
                int math = ran.Next(34, 101);
                int society = ran.Next(45, 101);
                int science = ran.Next(55, 95);
                int history = ran.Next(48, 101);

                student_list[i] = new Score(student_name, korean, english, math, society, science, history);

                Console.WriteLine();
                student_list[i].show_score();
                Console.WriteLine("점수 합 : {0}", student_list[i].sum_score());
                Console.WriteLine("점수 평균 : {0}", student_list[i].avg_score());
                Console.WriteLine();
                Console.WriteLine("\"{0}\"의 성적은 \"{1}\" 입니다", student_list[i].St_name.Name,
                    student_list[i].get_result(student_list[i].avg_score()));
                Console.WriteLine("##########################################");
            }

            Console.WriteLine();
            Console.WriteLine("{0}의 점수변경 --> 국어점수 : 100점", student_list[0].St_name.Name);
            student_list[0].Korean = 100;
            student_list[0].show_score();
            Console.WriteLine("점수 합 : {0}", student_list[0].sum_score());
            Console.WriteLine("점수 평균 : {0}", student_list[0].avg_score());
            Console.WriteLine();
            Console.WriteLine("\"{0}\"의 성적은 \"{1}\" 입니다", student_list[0].St_name.Name,
                student_list[0].get_result(student_list[0].avg_score()));
            Console.WriteLine("##########################################");




        }
    }
}
