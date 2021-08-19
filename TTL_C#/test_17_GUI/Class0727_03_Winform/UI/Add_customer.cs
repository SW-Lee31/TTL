using Class0727_03_Winform.Adapter;
using Class0727_03_Winform.Model;
using Class0727_03_Winform.Util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0727_03_Winform.UI
{
    partial class Add_customer : MaterialForm
    {
        CusAdpater cusadp;

        public Add_customer()
        {
            InitializeComponent();
        }

        public Add_customer(CusAdpater cusadp)
        {
            InitializeComponent();
            this.cusadp = cusadp;
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
            year_make();
            month_make();
            string month_condition = cus_input_month.Items.ToString();
            day_make(month_condition);

            /*string kaka = "12r";
            Console.WriteLine(check_string(kaka));*/

        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            check_empty(cus_input_name.Text.ToString(), 1);
            if (check_string(cus_input_name.Text.ToString()) == true)
            {
                MessageBox.Show("Input Proper name");
                ActiveControl = cus_input_name;
                cus_input_name.Focus();
            }
            check_name(cus_input_name.Text.ToString());
            string name = cus_input_name.Text.ToString();

            check_empty(cus_input_digit.Text.ToString(), 2);
            if (check_string(cus_input_digit.Text.ToString()) == false)
            {
                MessageBox.Show("Input Proper digit");
            }
            string digit = cus_input_digit.Text.ToString();

            check_empty(cus_input_address.Text.ToString(), 3);
            if (check_string(cus_input_address.Text.ToString()) == true)
            {
                MessageBox.Show("Input Proper address");
            }
            string addr = cus_input_address.Text.ToString();

            DateTime date = cus_input_date.Value;
            string date_str = string.Format("{0}년 {1}월 {2}일", date.Year, date.Month, date.Day);

            check_empty(cus_input_year.SelectedText, 4);
            string birth_year = cus_input_year.SelectedText;
            
            check_empty(cus_input_month.SelectedText, 5);
            string birth_month = cus_input_month.SelectedText;
            
            check_empty(cus_input_day.SelectedText, 6);
            string birth_day = cus_input_day.SelectedText;

            string birth = string.Format("{0}년 {1}월 {2}일", birth_year, birth_month, birth_day);

            /*Console.WriteLine("이름 : {0} ", name);
            Console.WriteLine("번호 : {0}", digit);
            Console.WriteLine("주소 : {0}", addr);
            Console.WriteLine("구매날짜 : " + date_str);
            Console.WriteLine("생일 {0}년 {1}월 {2}일 ", birth_year, birth_month, birth_day);*/

            // 성별
            string gender = "";

            if (cus_input_gender_male.Checked == true)
            {
                gender = "Male";
                //Console.WriteLine("성별 : " + gender);
            }

            else if (cus_input_gender_female.Checked == true)
            {
                gender = "Female";
                //Console.WriteLine("성별 : " + gender);
            }

            else
            {
                MessageBox.Show("Choose at least one button of gender");
            }

            // 가입 경로
            UICheckBox[] sub_path_arr =
            {
                cus_input_but_ad, cus_input_but_introduced, cus_input_but_net, cus_input_but_club
            };

            List<string> sub_path_result_arr = new List<string>();

            for (int i = 0; i < sub_path_arr.Length; i++)
            {
                if (sub_path_arr[i].Checked == true)
                {
                    //Console.Write(sub_path_arr[i].Text + "   ");
                    sub_path_result_arr.Add(sub_path_arr[i].Text);
                }
            }

            Customer cust_elements = new Customer(name, digit, addr, date_str, birth, gender, sub_path_result_arr);
            MessageBox.Show("Successfully Loaded data");
            /*cust_001.show_personal_info();*/
            cusadp.Addcustomer(cust_elements);
            /*cusadp.Show_cus_list_added_info();*/
            cusadp.Load_csv_customer_info();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cus_input_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cus_input_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cus_input_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void year_make()
        {
            for (int i = 1915; i <= 2021; i++)
            {
                cus_input_year.Items.Add(i);
            }
        }

        void month_make()
        {
            int[] month_elements = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            for (int i = 0; i <= 11; i++)
            {
                cus_input_month.Items.Add(month_elements[i]);
            }
        }

        void day_make(string month_condition)
        {
            cus_input_day.Items.Clear();

            for (int i = 1; i <= 31; i++)
            {
                switch (month_condition)
                {
                    case "January":
                        cus_input_day.Items.Add(i);
                        break;

                    case "March":
                        cus_input_day.Items.Add(i);
                        break;

                    case "May":
                        cus_input_day.Items.Add(i);
                        break;

                    case "July":
                        cus_input_day.Items.Add(i);
                        break;

                    case "August":
                        cus_input_day.Items.Add(i);
                        break;

                    case "October":
                        cus_input_day.Items.Add(i);
                        break;

                    case "December":
                        cus_input_day.Items.Add(i);
                        break;

                    default:
                        if (i == 31)
                        {
                            break;
                        }
                        cus_input_day.Items.Add(i);
                        break;
                }
            }
        }

        void check_empty(string data, int index)
        {
            string value = "";
            switch (index)
            {
                case 1:
                    value = "name";
                    break;

                case 2:
                    value = "digit";
                    break;

                case 3:
                    value = "address";
                    break;

                case 4:
                    value = "birth year";
                    break;

                case 5:
                    value = "birth month";
                    break;

                case 6:
                    value = "birth day";
                    break;
            }
            
            string str = "Input customer's " + value;
            if (data == "")
            {
                MessageBox.Show(str);
            }
            return;
        }

        void check_name(string data)
        {
            string str = "Input proper customer's data"; 
            if (data.Length > 5)
            {
                MessageBox.Show(str);
            }
            return;

            /*
            // 정규표현 사용 (한글이름 2자 ~ 4자)
            Regex regex = new Regex(@"^[가-힣]{2, 4}$");

            // 한글이름 체크
            Match m = regex.Match(data);
            if (m.Success == false)
            {
                MessageBox.Show("잘못된 이름 정보입니다.");
                return;
            }
            */
        }

        bool check_string(string str)
        {
            int checksum = 0;
            bool check_int = int.TryParse(str, out checksum);

            return check_int;
        }

        /*bool check_int(int digit)
        {
            Regex regex = new Regex(@"^01{1}[01679]{1}[0-9]{7,8}$");
        }*/

        void focus(Control focus_value)
        {
            ActiveControl = focus_value;
            focus_value.Focus();
        }
    }
}
