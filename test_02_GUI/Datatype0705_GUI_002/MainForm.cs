using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datatype0705_GUI_002
{
    public partial class MainForm : Form
    {
        // 생성자 메서드
        public MainForm()
        {
            // UI 컨트롤러 초기화
            InitializeComponent();
        }

        // 인터페이스가 실행되기 전에 실행되는 코드
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Program Start");
            Console.WriteLine("Program Loading..");

            // 인적사항
            string co_name = "(주)경북산업";
            string work_ID = "KB11111111802";
            string part_name = "물류관리부";
            string level = "대리";
            string name = "홍길동";
            int salary = 3000000;
            int age = 34;
            string gender = "Male";
            string kakao_id = "hong_dong";
            string addr = "대구 동구 신천 3동";
            string phone_num = "010-1234-5678";
            string detail_job = "원자재 입,출,재고 관리담당";


            // 화면 구성 
            string line_maker = "=================================================================================\n";
            string br = "\n";
            string solid = "---------------------------------------------------------------------------------\n";
            string title = "(주)경북산업 직원관리 프로그램";

            Console.WriteLine(line_maker);
            Console.WriteLine("\t\t\t" + title);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t회사명 : \t" + co_name);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t사원번호 : \t" + work_ID);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t부서명 : \t" + part_name);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t직급 : \t\t" + level);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t이름 : \t\t" + name);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t급여 : \t\t" + salary);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t나이 : \t\t" + age);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t성별 : \t\t" + gender);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t카카오  : \t" + kakao_id);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t주소 : \t\t" + addr);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t전화번호 : \t" + phone_num);
            Console.WriteLine(solid);
            Console.WriteLine("\t\t\t주요업무내용 : \t" + detail_job);
            Console.WriteLine(br);
            Console.WriteLine(line_maker);


            // UI 텍스트 출력(Label 활용)
            
            // 레이블설정
            employee_management.Text = title;
            company.Text = "회사명 : ";
            co_num.Text = "사원번호 : ";
            co_class.Text = "부서명 : ";
            co_level.Text = "직급 : ";
            employee_name.Text = "이름 : ";
            employee_salary.Text = "급여 : ";
            employee_age.Text = "나이 : ";
            employee_gender.Text = "성별 : ";
            kakao.Text = "카카오  : ";
            address.Text = "주소 : ";
            tel.Text = "전화번호 : ";
            detail.Text = "주요업무내용 : ";

            // 레이블 Value 출력
            company_value.Text = co_name;
            co_num_value.Text = work_ID;
            co_class_value.Text = part_name;
            co_level_value.Text = level;
            employee_name_value.Text = name;
            employee_salary_value.Text = salary.ToString();
            employee_age_value.Text = age.ToString();
            employee_gender_value.Text = gender;
            kakao_value.Text = kakao_id;
            address_value.Text = addr;
            tel_value.Text = phone_num;
            detail_value.Text = detail_job;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void company_Click(object sender, EventArgs e)
        {

        }

        private void kakao_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void detail_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
