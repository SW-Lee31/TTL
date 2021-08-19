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
    public partial class Salary_info : MaterialForm
    {
        public Salary_info()
        {
            InitializeComponent();
        }

        private void Salary_info_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyyMMdd");

            string serial_num = input_serial.Text;

            switch (serial_num)
            {
                case "aaa1111":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model1.jpg");
                    output_name.Text = "Suzuki model num.1";
                    output_buyer.Text = "Lee sang won";
                    output_date.Text = date;
                    break;

                case "aaa1112":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model2.jpg");
                    output_name.Text = "Suzuki model num.2";
                    output_buyer.Text = "James Dean";
                    output_date.Text = date;
                    break;

                case "aaa1113":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model3.jpg");
                    output_name.Text = "Suzuki model num.3";
                    output_buyer.Text = "Paul Phenix";
                    output_date.Text = date;
                    break;

                case "aaa1114":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model4.jpg");
                    output_name.Text = "Suzuki model num.4";
                    output_buyer.Text = "Hobs Smith";
                    output_date.Text = date;
                    break;

                case "aab1111":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model1.jpg");
                    output_name.Text = "karasaki model num.1";
                    output_buyer.Text = "Kharl Drogo";
                    output_date.Text = date;
                    break;

                case "aab1112":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model2.jpg");
                    output_name.Text = "karasaki model num.2";
                    output_buyer.Text = "Lee sang won";
                    output_date.Text = date;
                    break;

                case "aab1113":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model3.jpg");
                    output_name.Text = "karasaki model num.3";
                    output_buyer.Text = "Tom Swaltzki";
                    output_date.Text = date;
                    break;

                case "aab1114":
                    output_preview.Image = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model4.jpg");
                    output_name.Text = "karasaki model num.4";
                    output_buyer.Text = "Ivan volsachik";
                    output_date.Text = date;
                    break;

                default:
                    MessageBox.Show("No data about inputed serial number");
                    break;
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
