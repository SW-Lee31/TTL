using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operator0706
{
    public partial class MainForm2 : Form
    {   // Global
        int kor = 90;

        public MainForm2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 폼이 사용자에게 보여지기 직전에 실행되는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm2_Load(object sender, EventArgs e)
        {
            {   // Local
                int kor = 100;
                Console.WriteLine("국어(Local) : " + kor);
            }
            Console.WriteLine("국어(Global) : " + kor);

            // Operator

            // 사칙연산 +, -, /, *, %
            
            // output.format
            int a = 2, b = 3;
            Console.WriteLine("{0} % {1} = {2}", b, a, (b % a));

            // 증감 연산자
            a = 10;
            b = a++;
            Console.WriteLine("b = {0}, a = {1}", b, a);
            //a가 한번 더(다음에) 나올때 1증감되서 나옴 

            b = ++a;
            Console.WriteLine("b = {0}, a = {1}", b, a);

            //비교연산자
            a = 100;
            b = 200;

            Console.WriteLine("{0} == {1}이다 : {2}", a, b, (a == b));
            Console.WriteLine("{0} != {1}이다 : {2}", a, b, (a != b));
            Console.WriteLine("{0} > {1}이다 : {2}", a, b, (a > b));
            Console.WriteLine("{0} < {1}이다 : {2}", a, b, (a < b));
            Console.WriteLine("{0} >= {1}이다 : {2}", a, b, (a >= b));
            Console.WriteLine("{0} <= {1}이다 : {2}", a, b, (a <= b));

            //논리연산자
            a = 99;
            Console.WriteLine("AND 논리연산(100 <= a <= 200) : {0}", (a >= 100) && (a <= 200));
            Console.WriteLine("OR 논리연산(a < 100 OR a > 200) : {0}", (a < 100) || (a > 200));
            Console.WriteLine("OR 논리연산(a < 100 OR a > 200) : {0}", (a < 100) || (a > 200));
            Console.WriteLine("! 논리연산 (a != 100) : {0}", !(a == 100));
            // +삼항 연산자
            a = 10;
            b = 15;
            string res = "";
            res = (a > b) ? "a가 크다" : "b가 크다";
            Console.WriteLine("{0} > {1} ->  {2}", a, b, res);
        }
    }
}
