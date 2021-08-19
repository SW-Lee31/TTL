using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719
{
    public partial class MainFrame : Form
    {
        int local = 1;
        Random ran = new Random();

        string[] name = new string[6]
        {
            "황금새", "이석원", "이성현", "김동겸", "김종명", "황정운"
        };

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // 메서드_1 Print 사용
            Print();

            // 메서드_2 Plus 사용
            Plus(15, 17);

            // 메서드_3 Arr_one_hundred 사용
            int[] arr_1 = Arr_one_hundred(); 

            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.Write(arr_1[i] + " ");
            }
            Console.WriteLine();

            // 메서드_4 Select 사용
            string name_selection = Select(name);
            Console.WriteLine("선택된 이름은 {0}입니다.", name_selection);
            Console.WriteLine("선택된 이름은 {0}입니다.", Select(name));

            // 메서드_5(재귀함수) Factorial 사용
            Console.WriteLine("5! = {0}", Factorial(5));
        }

        // 1. 데이터타입(void) 메서드명 ()
        void Print()
        {
            int local = 2;
            Console.WriteLine("메서드_1(Print)가 실행되었습니다.");
            Console.WriteLine("변수 Local의 값은 {0}", local);
        }

        // 2. 데이터타입(void) 메서드명 (parameter)
        void Plus(int x, int y)
        {
            int sum = 0;
            Console.WriteLine("{0} + {1} = {2}", x, y, sum);
        }

        // 3. 데이터타입(非 void) 메서드명 () -> return
        int[] Arr_one_hundred()
        {
            int[] int_arr = new int[100];

            for (int i = 1; i < 101; i++)
            {
                int_arr[i - 1] = i;
            }

            return int_arr;
        }

        // 4. 데이터타입(非 void) 메서드명 (parameter) -> return
        string Select(string[] name)
        {
            int select = ran.Next(6);
            string result = name[select];

            return result;
        }

        // 5. recursive function(재귀함수)
        int Factorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }

            return num * factorial(num - 1);
        }
    }
}
