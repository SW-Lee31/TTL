using Class0727_03_Winform.Adapter;
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
    partial class Personal_info : MaterialForm
    {
        CusAdpater cusapt = new CusAdpater();
        static int INDEX;

        public Personal_info()
        {
            InitializeComponent();
        }

        public Personal_info(CusAdpater cusapt)
        {
            InitializeComponent();
            this.cusapt = cusapt;
        }

        private void Personal_info_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }

        private void but_index_submit_Click(object sender, EventArgs e)
        {
            string index_num = input_index.Text;
            INDEX = int.Parse(index_num);

            output_name.Text = cusapt.Cus_list[INDEX - 1].Name;
            output_digit.Text = cusapt.Cus_list[INDEX - 1].Digit;
            output_date.Text = cusapt.Cus_list[INDEX - 1].Date;
            output_birth.Text = cusapt.Cus_list[INDEX - 1].Birth;
            output_gender.Text = cusapt.Cus_list[INDEX - 1].Gender;

            string sub_path_str = "";

            for (int i = 0; i < cusapt.Cus_list[INDEX - 1].Sub_path.Count; i++)
            {
                if (i == (cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1))
                {
                    sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1];
                }
                sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[i] + ", ";

            }

            output_path.Text = sub_path_str;
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            INDEX++;

            output_name.Text = cusapt.Cus_list[INDEX - 1].Name;
            output_digit.Text = cusapt.Cus_list[INDEX - 1].Digit;
            output_date.Text = cusapt.Cus_list[INDEX - 1].Date;
            output_birth.Text = cusapt.Cus_list[INDEX - 1].Birth;
            output_gender.Text = cusapt.Cus_list[INDEX - 1].Gender;

            string sub_path_str = "";

            for (int i = 0; i < cusapt.Cus_list[INDEX - 1].Sub_path.Count; i++)
            {
                if (i == (cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1))
                {
                    sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1];
                }
                sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[i] + ", ";

            }

            output_path.Text = sub_path_str;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            INDEX--;

            output_name.Text = cusapt.Cus_list[INDEX - 1].Name;
            output_digit.Text = cusapt.Cus_list[INDEX - 1].Digit;
            output_date.Text = cusapt.Cus_list[INDEX - 1].Date;
            output_birth.Text = cusapt.Cus_list[INDEX - 1].Birth;
            output_gender.Text = cusapt.Cus_list[INDEX - 1].Gender;

            string sub_path_str = "";

            for (int i = 0; i < cusapt.Cus_list[INDEX - 1].Sub_path.Count; i++)
            {
                if (i == (cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1))
                {
                    sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[cusapt.Cus_list[INDEX - 1].Sub_path.Count - 1];
                }
                sub_path_str += cusapt.Cus_list[INDEX - 1].Sub_path[i] + ", ";

            }

            output_path.Text = sub_path_str;
        }
    }
}
