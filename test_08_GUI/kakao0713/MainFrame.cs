using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kakao0713
{
    public partial class MainFrame : Form
    {
        // 십진수값을 이진수값으로 변환, + 이진수 값 리스트를 문자열화
        public string Binary_ex(int num)
        {
            string result_str = ""; 
            List<int> lst = new List<int>();

                while (num != 0)
                {
                    lst.Add(num % 2);
                    num /= 2;
                    Console.WriteLine(lst);
                }

                lst.Reverse();

            // 이진수 값을 문자열화
            for (int i = 0; i < lst.Count; i++)
            {
                result_str += lst[i].ToString() + " ";
            }

            return result_str;
        }

        // 변의 길이에 맞게 빈 공간에 '0' 추가
        public string Addition(int index_amount, string result_string)
        {
            if (result_string.Length < index_amount)
            {
                while (result_string.Length < index_amount)
                {
                    result_string += "0 ";
                }
            }

            return result_string;
        }

        // 1을 #으로, 0을 _로 변환
        public string Swap_index(string index_str)
        {
            string result_str = "";
            string[] elements = index_str.Split(' ');

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == "1")
                {
                    result_str += "# ";
                }

                else
                {
                    result_str += "_ ";
                }
            }

            return result_str;
        }

        public string Compare(string result_string_1, string result_stirng_2)
        {
            string result_f = "";
            string[] com_res_1 = new string[result_string_1.Count()];
            string[] com_res_2 = new string[result_stirng_2.Count()];
            string[] elements_1 = result_string_1.Split(' ');
            string[] elements_2 = result_stirng_2.Split(' ');

            for (int i = 0; i < result_string_1.Length; i++)
            {
                if (elements_1[i] == elements_2[i] && elements_1[i] == "#")
                {
                    result_f += "#";
                }

                else if (elements_1[i] != elements_2[i] && elements_1[i] == "#")
                {
                    result_f += "#";
                }

                else if (elements_1[i] != elements_2[i] && elements_1[i] == " ")
                {
                    result_f += "#";
                }

                else
                {
                    result_f += "_";
                }
            }

            return result_f;
        }

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Binary_ex 테스트입니다. (8)");
            Console.WriteLine(Binary_ex(8));

            Console.WriteLine("Addition 테스트입니다. (\"1101\")");
            Console.WriteLine(Addition(5, "1101"));

            Console.WriteLine("Swap_index 테스트입니다. (10011)");
            Console.WriteLine(Swap_index("10011"));

            Console.WriteLine("Compare 테스트입니다. (_#__#_), (##__#)");
            Console.WriteLine(Compare("# _ _ # _ ", "# # _ _ # "));

/*            void Input_value(int index_num, List<int> list_1, List<int> list_2)
            {
                List<string> output_result_1 = new List<string>();
                List<string> output_result_2 = new List<string>();
                List<string> result_value = new List<string>();


                for (int i = 0; i < index_num; i++)
                {
                    output_result_1.Add(Binary_ex(list_1[i]));
                    output_result_2.Add(Binary_ex(list_2[i]));

                }*/

           /* }*/
        }
    }
}
