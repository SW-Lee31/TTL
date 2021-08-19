using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array0713
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();

        // stack 배열 선언은 지역변수에서 활용 가능
        int[] arr_int_grobal = { 10, 20, 30, 40 };

        // heap 배열 선언은 전역변수로 활용 가능
        int[] arr_int = new int[4]
        {
            10, 20, 30, 40
        };

        // 메모리 할당의 문제 -> 지역변수, 전역변수 큰 차이 없이 활용가능

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // 1차원 배열 선언 및 초기화
            int[] arr_int_1 = { 10, 20, 30, 40, 50 }; // stack 영역
            char[] arr_char_1 = new char[4] // heap 영역
            {
                '이', '박', '김', '최'
            };

            // 배열변수명.Length -> 배열의 크기 반환
            Console.WriteLine("arr_int_1의 배열크기는 : {0}", arr_int_1.Length);
            Console.WriteLine("arr_char_1의 배열크기는 : {0}", arr_char_1.Length);

            for (int i = 0; i < arr_int_1.Length; i++)
            {
                Console.WriteLine("arr_int_1[{0}] = {1}", i, arr_int_1[i]);
            }

            for (int i = 0; i < arr_char_1.Length; i++)
            {
                Console.WriteLine("arr_char_1[{0}] = {1}", i, arr_char_1[i]);
            }

            for (int i = 0; i < arr_int_grobal.Length; i++)
            {
                Console.WriteLine("arr_char_grobal[{0}] = {1}", i, arr_int_grobal[i]);
            }

            string[] name = new string[3]
            {
                "홍길동", "전우치", "김유신"
            };

            // 빈 1차원 배열 생성
            string[] empty_name = new string[3];
            
            for (int i = 0; i < empty_name.Length; i++)
            {
                Console.WriteLine("empty_name[{0}] = {1}", i, empty_name[i]);
            }

            // 빈 배열에 값 삽입
            for (int i = 0; i < empty_name.Length; i++)
            {
                empty_name[i] = name[i];
                Console.WriteLine("empty_name[{0}]에 name[{1}]의 값 삽입 -> {2}", i, i, empty_name[i]);
                Console.WriteLine("empty_name의 값을 다시 제거");
                empty_name[i] = null;
                Console.WriteLine("empty_name[{0}] = {1}", i, empty_name[i]);
            }
            
            // 랜덤 정보 가져오기

                         /*Console.WriteLine(name[ran.Next(0, 3)]);*/

            for (int i = 0; i < name.Length; i++)
            {
                int index = ran.Next(0, 3);
                Console.WriteLine("배열(name)안의 인덱스 중 랜덤으로 출력 : {0}", name[index]);
                empty_name[i] = name[index];
                Console.WriteLine("empty_name[{0}]에 name[랜덤의 값(0 ~ 3)]의 값 삽입 -> {2}", i, i, empty_name[i]);
            }


        }
    }
}
