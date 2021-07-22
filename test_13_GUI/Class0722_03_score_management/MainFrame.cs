using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0722_03_score_management
{
    public partial class MainFrame : Form
    {
        const int STUDENT_NUM = 5;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            string line = "#####################################################################";

            StudentName first_one = new StudentName();
            first_one.createName(ran.Next(10), ran.Next(10), ran.Next(10));
            StudentRecord first_one_score = new StudentRecord(ran.Next(35, 101), ran.Next(35, 101),
                ran.Next(35, 101), ran.Next(35, 101), ran.Next(35, 101), ran.Next(35, 101));
            
            Console.WriteLine("\"{0}\"의 총점 : {1}점 평균 : {2}점  입니다.", first_one.getname(), first_one_score.sum_result(), first_one_score.avg_result());
            Console.WriteLine("\"{0}\"의 학점은 \"{1}\" 입니다.", first_one.getname(), first_one_score.score_result());

            Console.WriteLine(line);
            Console.WriteLine();

            StudentName second_one = new StudentName();
            second_one.createName(ran.Next(10), ran.Next(10), ran.Next(10));
            StudentRecord second_one_score = new StudentRecord(ran.Next(45, 99), ran.Next(45, 99),
                ran.Next(45, 99), ran.Next(45, 99), ran.Next(45, 99), ran.Next(45, 99));

            Console.WriteLine("\"{0}\"의 총점 : {1}점 평균 : {2}점  입니다.", second_one.getname(), second_one_score.sum_result(), second_one_score.avg_result());
            Console.WriteLine("\"{0}\"의 학점은 \"{1}\" 입니다.", second_one.getname(), second_one_score.score_result());

            Console.WriteLine(line);
            Console.WriteLine();

            StudentName third_one = new StudentName();
            third_one.createName(ran.Next(10), ran.Next(10), ran.Next(10));
            StudentRecord third_one_score = new StudentRecord(ran.Next(47, 99), ran.Next(45, 99),
                ran.Next(45, 99), ran.Next(48, 96), ran.Next(46, 99), ran.Next(45, 99));

            Console.WriteLine("\"{0}\"의 총점 : {1}점 평균 : {2}점  입니다.", third_one.getname(), third_one_score.sum_result(), third_one_score.avg_result());
            Console.WriteLine("\"{0}\"의 학점은 \"{1}\" 입니다.", third_one.getname(), third_one_score.score_result());

            Console.WriteLine(line);
            Console.WriteLine();

            StudentName forth_one = new StudentName();
            forth_one.createName(ran.Next(10), ran.Next(10), ran.Next(10));
            StudentRecord forth_one_score = new StudentRecord(ran.Next(47, 99), ran.Next(45, 99),
                ran.Next(45, 99), ran.Next(48, 96), ran.Next(46, 99), ran.Next(45, 99));

            Console.WriteLine("\"{0}\"의 총점 : {1}점 평균 : {2}점  입니다.", forth_one.getname(), forth_one_score.sum_result(), forth_one_score.avg_result());
            Console.WriteLine("\"{0}\"의 학점은 \"{1}\" 입니다.", forth_one.getname(), forth_one_score.score_result());

            Console.WriteLine(line);
            Console.WriteLine();

            StudentName fifth_one = new StudentName();
            fifth_one.createName(ran.Next(10), ran.Next(10), ran.Next(10));
            StudentRecord fifth_one_score = new StudentRecord(ran.Next(47, 99), ran.Next(45, 99),
                ran.Next(45, 99), ran.Next(48, 96), ran.Next(46, 99), ran.Next(45, 99));

            Console.WriteLine("\"{0}\"의 총점 : {1}점 평균 : {2}점  입니다.", fifth_one.getname(), fifth_one_score.sum_result(), fifth_one_score.avg_result());
            Console.WriteLine("\"{0}\"의 학점은 \"{1}\" 입니다.", fifth_one.getname(), fifth_one_score.score_result());
        }
    }
}
