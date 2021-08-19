using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Method0721_setup
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();
        string filepath = "C:\\c#_work\\addr.txt";
        int index_arr = 0;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void store_buttton_Click(object sender, EventArgs e)
        {
            if (path_input.Text != "")
            {
                filepath = path_input.Text;
            }

            if (input_index_input.Text == "")
            {
                MessageBox.Show("인원 수를 입력해주세요.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                index_arr = int.Parse(input_index_input.Text);
                StreamWriter writer = new StreamWriter(filepath);

                writer.WriteLine("번호\t이름\t전화번호\t\t메일\t\t\t주소");
                writer.WriteLine("#################################################################################");

                for (int i = 0; i < index_arr; i++)
                {
                    string data = get_name() + "\t";
                    data += get_digit() + "\t";
                    data += get_mail() + "\t";
                    data += get_add() + "\t";

                    writer.WriteLine("{0}\t{1}", (i + 1), data);
                }

                writer.Close();
                MessageBox.Show("주소록이 저장되었습니다.");
            }
        }

        string get_name()
        {
            string[] first_name = { "김", "박", "이", "최", "장", "황", "정", "양" };
            string[] middle_name = { "승", "민", "현", "창", "상", "정", "재", "현" };
            string[] last_name = { "욱", "혁", "승", "신", "헌", "운", "영", "석" };

            string created_name = first_name[ran.Next(8)] + middle_name[ran.Next(8)] + last_name[ran.Next(8)];

            return created_name;
        }

        string get_digit()
        {
            string[] first_phone_num = { "010", "011", "016", "070", "001" };
            string[] middle_phone_num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] last_phone_num = middle_phone_num;
            string dash = "-";

            string created_digit = first_phone_num[ran.Next(5)] + dash;

            for (int i = 0; i < 4; i++)
            {
                created_digit += middle_phone_num[ran.Next(10)];
            }
            created_digit += dash;

            for (int i = 0; i < 4; i++)
            {
                created_digit += last_phone_num[ran.Next(10)];
            }

            return created_digit;
        }

        string get_mail()
        {
            string[] mail_elements_char = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
            string[] mail_elements_digit = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] domain_addr = { "naver", "hanmail", "gmail", "yahoo", "hotmail", "hanmir", "weppy" };
            string at_sign = "@";
            string dotcom = ".com";

            string created_mail = "";

            for (int i = 0; i < ran.Next(4, 8); i++)
            {
                created_mail += mail_elements_char[ran.Next(mail_elements_char.Length)];
            }

            for (int i = 0; i < ran.Next(2, 5); i++)
            {
                created_mail += mail_elements_digit[ran.Next(mail_elements_digit.Length)];
            }

            created_mail += at_sign;
            created_mail += domain_addr[ran.Next(domain_addr.Length)];
            created_mail += dotcom;

            return created_mail;
        }

        string get_add()
        {
            string[] city = { "서울시", "대구시", "영천시", "대전시", "부산시", "광주시", "제주시", "울산시" };
            string[] area = { "동구", "서구", "중구", "북구", "남구" };
            string[] house_num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string bunji = "번지";

            string created_addr = city[ran.Next(city.Length)] + " " + area[ran.Next(area.Length)] + " ";

            for (int i = 0; i < ran.Next(2, 5); i++)
            {
                string randint = house_num[ran.Next(house_num.Length)];
                if (i == 0 && randint == "0")
                {
                    continue;
                }
                created_addr += randint;
            }
            created_addr += bunji;

            return created_addr;
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            output_listbox.Items.Clear();

            if (path_input.Text != "")
            {
                filepath = path_input.Text;
            }
            // 파일데이터를 읽어들여 배열에 저장
            string[] arrdata = File.ReadAllLines(filepath);

            if (arrdata.Length > 0)
            {
                if (print_index_input.Text == "")
                {
                    for (int i = 0; i < arrdata.Length; i++)
                    {
                        output_listbox.Items.Add(arrdata[i]);
                    }
                }

                else
                {
                    int print_index_num = int.Parse(print_index_input.Text);
                    for (int i = 0; i < 2; i++)
                    {
                        output_listbox.Items.Add(arrdata[i]);
                    }

                    output_listbox.Items.Add(arrdata[print_index_num + 1]);
                }
            }

            else
            {
                MessageBox.Show("저장된 정보가 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("개발정보 : 2021년 7월 20일 by 이상원", "프로그램 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
