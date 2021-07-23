using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0723_01
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Random_info name = new Random_info();
            Random ran = new Random();

            string[] gender = { "Male", "Female" };

            Student st_1 = new Student("홍길동", "Male", 27, "010-1232-1322", "대구시 수성구 만촌동 11");
            st_1.show_info();

            // 18명의 정보 얻기
            Student[] st_arr = new Student[18];
            
            for (int i = 0; i < st_arr.Length; i++)
            {
                st_arr[i] = new Student(name.createName(ran.Next(10), ran.Next(10), ran.Next(10)),
                    gender[ran.Next(1)],
                    ran.Next(20, 40),
                    name.Create_digit(ran.Next(3), ran.Next(10), ran.Next(10)), 
                    name.Create_addr(ran.Next(8), ran.Next(8), ran.Next(10)));

                st_arr[i].show_info();
                Console.WriteLine();
            }

            


        }
    }
}
