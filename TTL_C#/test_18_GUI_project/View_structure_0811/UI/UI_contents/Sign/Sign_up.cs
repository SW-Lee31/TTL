using MaterialSkin.Controls;
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
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents.Sign
{
    partial class Sign_up : MaterialForm
    {
        string file_path_id = @"C:\Users\sangw\Desktop\TTL_master\TTL\test_18_GUI_project\View_structure_0811\CSV\Admin_id_info";

        public Sign_up()
        {
            InitializeComponent();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click_1(object sender, EventArgs e)
        {
            string name = "";
            string digit = "";
            string addr = "";
            string id = "";
            string pw = "";
            string pw_result = "";
            string pw_checksum = "";


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

            if (empty_check(input_id.Text) == true)
            {
                id = input_id.Text;
            }

            else
            {
                MessageBox.Show("아이디가 입력되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (empty_check(input_password.Text) == true)
            {
                pw = input_password.Text;
            }

            else
            {
                MessageBox.Show("비밀번호가 입력되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (empty_check(input_password_check.Text) == true)
            {
                pw_checksum = input_password_check.Text;
            }

            else
            {
                MessageBox.Show("비밀번호를 확인해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (pw == pw_checksum)
            {
                pw_result = pw;
                Admin_id id_index = new Admin_id(id, pw_result, name, digit, addr);
                Id_adapter.add_list(id_index);
                CSV_writer.Load_csv_id(file_path_id);
                CSV_reader.Read_csv(file_path_id);
                MessageBox.Show("회원가입이 완료되었습니다.");
                Close();
            }

            else
            {
                MessageBox.Show("패스워드가 일치하지 않습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
