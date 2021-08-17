using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.Adapter;
using View_structure_0811.CSV;
using View_structure_0811.Model;

namespace View_structure_0811.UI.UI_contents
{
    

    partial class Add_person : UserControl
    {
        string file_path_personal_info = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Personal_info.csv";

        Person_adapter peradp;

        public Add_person()
        {
            InitializeComponent();
        }

        public Add_person(Person_adapter peradp)
        {
            InitializeComponent();
            this.peradp = peradp;
        }

        private void Add_person_Load(object sender, EventArgs e)
        {

        }

        private void but_confirm_Click(object sender, EventArgs e)
        {
            
            // 데이터 입력
            #region
            string name = "";
            string digit = "";
            string addr = "";

            if (empty_check(input_name.Text) == true)
            {
                name = input_name.Text;
            }

            else
            {
                MessageBox.Show("이름이 입력되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (empty_check(input_digit.Text) == true)
            {
                digit = input_digit.Text;
            }

            else
            {
                MessageBox.Show("전화번호가 입력되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (empty_check(input_addr.Text) == true)
            {
                addr = input_addr.Text;
            }

            else
            {
                MessageBox.Show("주소가 입력되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DateTime datetime = input_date.Value;
            string date = string.Format("{0}년 {1}월 {2}일", datetime.Year, datetime.Month, datetime.Day);

            string gender = "";

            if (input_gender_male.Checked == true)
            {
                gender = "남자";
            }

            else if (input_gender_female.Checked == true)
            {
                gender = "여자";
            }

            else
            {
                MessageBox.Show("성별에 체크해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion 

            Person person_index = new Person(name, digit, addr, date, gender);
            /*person_index.print_personal_info();*/

            MessageBox.Show("인적사항이 저장되었습니다.");

            Person_adapter.Add_list(person_index);
            CSV_writer.Load_csv_personal(file_path_personal_info);
            /*CSV_reader.Read_csv(file_path_personal_info);*/
        }

        public bool empty_check(string value)
        {
            if (value == "")
            {
                return false;
            }

            return true;
        }
    }
}
