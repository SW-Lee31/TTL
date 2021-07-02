using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_03
{
    class input0702
    {
        public void input()
        {
            //sol_1
            Console.Write("숫자를 입력하세요 : \n");
            string f_num = Console.ReadLine();
            int num = int.Parse(f_num);
            
            //sol_2
            Console.Write("숫자를 입력하세요 : \n");
            int num_2 = int.Parse(Console.ReadLine());
            
            //형변환은 불가능 (str -> int)
            /*Console.Write("숫자를 입력하세요 : \n");
            string f_2_num = Console.ReadLine();
            int num_3 = (int)f_2_num;*/
            
            //sol_3
            Console.Write("숫자를 입력하세요 : \n");
            string f_3_num = Console.ReadLine();
            int num_4 = Convert.ToInt32(f_3_num);
            

            Console.WriteLine(num);
            Console.WriteLine(num_2);
            Console.WriteLine(num_4);


        }

    }
}
