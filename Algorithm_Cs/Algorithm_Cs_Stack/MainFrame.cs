using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Cs_Stack
{
    public partial class MainFrame : Form
    {
        const int len_arr = 10;
        int[] stack_arr = new int[len_arr];

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < stack_arr.Length; i++)
            {
                Console.WriteLine(stack_arr[i]);
            }*/

            int operation_count = int.Parse(Console.ReadLine());
            for (int i = 0; i < operation_count; i++)
            {
                string oper = Console.ReadLine();
                switch (oper)
                {
                    case "push":
                        int input_num = int.Parse(Console.ReadLine());
                        push(input_num);
                        break;

                    case "pop":
                        Console.WriteLine(pop());
                        break;

                    case "size":
                        Console.WriteLine(size_of_stack());
                        break;

                    case "empty":
                        Console.WriteLine(empty_check());
                        break;

                    case "top":
                        Console.WriteLine(top());
                        break;

                    default:
                        MessageBox.Show("명령어를 다시 입력하시오.");
                        break;
                }
            }
        }

        int size_of_stack()
        {
            int size_checksum = 0;

            for (int i = 0; i < stack_arr.Length; i++)
            {
                if (stack_arr[i] != 0)
                {
                    size_checksum++;
                }
            }

            return size_checksum;
        }

        void push(int X)
        {
            int input_space = size_of_stack();

            stack_arr[input_space] = X;
        }

        int pop()
        {
            int output_space = size_of_stack();

            int pop_value = stack_arr[output_space - 1];
            stack_arr[output_space - 1] = 0;

            return pop_value;
        }

        int empty_check()
        {
            int checksum = size_of_stack();

            if (checksum == 0)
            {
                return 0;
            }

            else
                return 1;
        }

        int top()
        {
            int checksum = size_of_stack();

            if (checksum == 0)
            {
                return -1;
            }

            else
            {
                return stack_arr[checksum - 1];
            }
        }
    }
}
