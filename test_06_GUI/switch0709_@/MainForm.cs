using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch0709__
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("====================");
            Console.WriteLine("간단한 계산기 V1.0.1");
            Console.WriteLine("====================");

            while (true)
            {
                Console.Write("계산할 첫 번째 값을 입력하세요 : ");
                string num_1 = Console.ReadLine(); // num_1에 문자열 입력
                double check = 0; // num_1이랑 비교할 실수형(임의의 값)
                bool checked_num = double.TryParse(num_1, out check); // 실수형(check)이랑 num_1과 비교 (문자가 num_1에 하나도 없으면 true반환, 하나라도 있으면 false반환

                if (checked_num == true) // 비교값이 true가 나오면
                {
                    double num_1_value = double.Parse(num_1); // 새 변수 (계산에 활용 할 변수) 에 num_1을 실수로 바꿔서 값 입력
                    Console.Write("계산할 연산자를 입력하세요 : ");
                    string oper = Console.ReadLine(); // 연산자 입력받기
                    if ((oper == "+") || (oper == "-") || (oper == "*") || (oper == "/")) // 연산자가 (+, -, *, /)중 하나일 때
                    {
                        Console.Write("계산할 두 번째 값을 입력하세요 : "); 
                        string num_2 = Console.ReadLine(); // num_2에 문자열 입력
                        double check_2 = 0; // num_2과 비교할 실수형(임의의 값)
                        bool checked_num_2 = double.TryParse(num_2, out check_2); // 실수형(check_2)와 num_2랑 비교

                        if (checked_num_2 == true) // 비교값이 true가 나오면(num_2에는 문자열이 하나도 없다)
                        {
                            double num_2_value = double.Parse(num_2); // 새 변수 (계산에 활용할 변수) 에 num_2를 실수로 바꿔서 값 입력
                            
                            switch (oper)
                            {
                                case "+":
                                    Console.WriteLine("{0} + {1} = {2}", num_1, num_2, (num_1_value + num_2_value));
                                    Console.WriteLine("");
                                    break;

                                case "-":
                                    Console.WriteLine("{0} - {1} = {2}", num_1, num_2, (num_1_value - num_2_value));
                                    Console.WriteLine("");
                                    break;

                                case "*":
                                    Console.WriteLine("{0} x {1} = {2}", num_1, num_2, (num_1_value * num_2_value));
                                    Console.WriteLine("");
                                    break;

                                case "/":
                                    Console.WriteLine("{0} ÷ {1} = {2}", num_1, num_2, Math.Round((num_1_value / num_2_value), 3));
                                    Console.WriteLine("");
                                    break;
                            }
                        }

                        else // num_2에 문자열이 하나라도 포함돼있다?
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Warning : 숫자를 입력해주세요.");
                            Console.WriteLine("");
                        }
                    }

                    else if (oper == "route") // 연산자 (route)를 사용했다?
                    {
                        Console.WriteLine("√{0} = {1}", num_1, Math.Sqrt(num_1_value));
                        Console.WriteLine("");
                    }

                    else // 연산자 (+, -, *, /)도 아니고 route도 아니다?
                    {
                        Console.WriteLine("");
                        Console.WriteLine("연산자 (+, =, *, /)중 입력하세요.");
                        Console.WriteLine("");
                    }
                }

                else // num_1에 문자열이 하나라도 포함돼있다?
                {
                    Console.WriteLine("");
                    Console.WriteLine("Warning : 숫자를 입력해주세요.");
                    Console.WriteLine("");
                }





            }
        }
    }
}
