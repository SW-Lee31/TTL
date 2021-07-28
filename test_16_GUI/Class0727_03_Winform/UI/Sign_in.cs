using Class0727_03_Winform.Util;
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

namespace Class0727_03_Winform.UI
{
    public partial class Sign_in : MaterialForm
    {
        public Sign_in()
        {
            InitializeComponent();
        }



        private void Add_customer_Load(object sender, EventArgs e)
        {
            Common.InitTheme_2(this);
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            new Sign_up().ShowDialog();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (input_id.Text == "abc" || input_pw.Text == "1234")
            {
                new MainUI_04_metro().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("잘못된 아이디 혹은 비밀번호입니다.");
            }
        }
    }
}
