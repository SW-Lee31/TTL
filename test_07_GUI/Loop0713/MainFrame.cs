using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0713
{
    public partial class MainFrame : Form
    {
        int sum = 0;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("############################################################");
            Console.WriteLine("1 ~ 100 까지의 숫자 중 5의 배수만 출력하는 프로그램 (for문)");
            Console.WriteLine("############################################################");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {   
                    if (i == 100)
                    {
                        Console.Write(i);
                        continue;
                    }
                    Console.Write(i + ", ");
                    sum += i;
                }

                else
                {
                    continue;
                }
            }
            Console.WriteLine("\n1 ~ 100까지의 숫자 중 5의 배수의 합을 출력 : " + sum);
            Console.WriteLine();


            Console.WriteLine("############################################################");
            Console.WriteLine("1 ~ 100 까지의 숫자 중 5의 배수만 출력하는 프로그램 (do-while문)");
            Console.WriteLine("############################################################");

            int index = 1;
            sum = 0;

            do
            {
                if (index % 5 == 0)
                {
                    if (index == 100)
                    {
                        Console.WriteLine(index);
                        index++;
                        continue;
                    }
                    Console.Write(index + ", ");
                    sum += index;
                    index++;
                }
                
                else
                {
                    index++;
                    continue;
                }
            } while (index <= 100);
            Console.WriteLine("\n1 ~ 100까지의 숫자 중 5의 배수의 합을 출력 : " + sum);
            Console.WriteLine();
        }



    }
}
