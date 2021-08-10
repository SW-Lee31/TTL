using Class0727_03_Winform.Adapter;
using Class0727_03_Winform.Model;
using Class0727_03_Winform.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0727_03_Winform.UI
{
    partial class Admin_member_management : MaterialForm
    {
        CusAdpater cusapt;
        Customer cus;
        StreamReader csv_reader = new StreamReader(@"C:\\c#_work\\test_17_GUI\\test.csv");

        public Admin_member_management()
        {
            InitializeComponent();
        }

        public Admin_member_management(CusAdpater cusapt)
        {
            InitializeComponent();
            this.cusapt = cusapt;
        }

        private void Admin_member_management_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
            output_cusname.Items.Clear();

            /*Console.WriteLine(csv_reader.ReadLine());*/

            for (int row = 0; row < (cusapt.Cus_list.Count + 1); row++)
            {
                string csv_elements = csv_reader.ReadLine();
                string[] elements = csv_elements.Split(new char[] { ',' });
                if (elements[0] == "고객명")
                {
                    continue;
                }
                output_cusname.Items.Add(elements[0]);
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_cusname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void output_cusname_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            StreamReader csv_reader = new StreamReader(@"C:\\c#_work\\test_17_GUI\\test.csv");

            for (int row = 0; row < (cusapt.Cus_list.Count + 1); row++)
            {
                string csv_elements = csv_reader.ReadLine();
                string[] elements = csv_elements.Split(new char[] { ',' });
                if (elements[0] == "고객명")
                {
                    continue;
                }
                
                if(output_cusname.Text == elements[0])
                {
                    string digit = "";

                    for (int i = 1; i < elements[1].Length; i++)
                    {
                        if (elements[1][i] == '\'')
                        {
                            continue;
                        }
                        digit += elements[1][i];
                    }
                    output_digit.Text = digit;
                    output_date.Text = elements[3];
                    output_birth.Text = elements[4];
                    output_gender.Text = elements[5];
                    break;
                }
            }
        }

        private void cus_but_submit_Click(object sender, EventArgs e)
        {
            string member_digit = input_mem_digit.Text;

            for (int i = 0; i < cusapt.Cus_list.Count; i++)
            {
                if (output_cusname.Text == cusapt.Cus_list[i].Name)
                {
                    cusapt.Cus_list[i].Member_digit = member_digit;
                }
            }
        }

       void Add_mem_digit_csv(int i)
        {
            StreamWriter edit = new StreamWriter(@"C:\\c#_work\\test_17_GUI\\test.csv", false);

            /* csv 파일 수정관련 문의할 것*/
        }
    }
}
