using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726_03_student_management
{
    public partial class MainFrame : Form
    {
        const int STUDENT_NUM = 10;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Random ran = new Random();

            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동",
                "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};

            Student[] stu = new Student[STUDENT_NUM];

            for (int i = 0; i < STUDENT_NUM; i++)
            {
                stu[i] = new Student(name[ran.Next(name.Length)], age[ran.Next(age.Length)],
                                gender[ran.Next(gender.Length)], address[ran.Next(address.Length)]);

                Console.WriteLine("번호 : {0}", (i + 1));
                
                /*if (i == 9)
                {
                    stu[9].Name = "전우치";
                    stu[9].Age = 24;
                    stu[9].Gender = '남';
                    stu[9].Address = "조선 한양인근 두메산골";
                }*/

                if (i == 9)
                {
                    stu[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
                }

                Console.WriteLine(stu[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
