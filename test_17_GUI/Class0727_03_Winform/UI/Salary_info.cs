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
    partial class Salary_info : MaterialForm
    {
        CarAdapter carapt;

        public Salary_info()
        {
            InitializeComponent();
        }

        public Salary_info(CarAdapter carapt)
        {
            InitializeComponent();
            this.carapt = carapt;
        }

        private void Salary_info_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            output_buyer.Text = "";
            output_date.Text = "";
            output_name.Text = "";
            output_preview.Image = null;

            string se_num = input_serial.Text;

            for (int i = 0; i < carapt.Order_list.Count; i++)
            {
                for (int j = 0; j < carapt.Order_list[i].Se_num.Count; j++)
                {
                    if (se_num == carapt.Order_list[i].Se_num[j])
                    {
                        output_name.Text = carapt.Order_list[i].Model;
                        output_date.Text = carapt.Order_list[i].Date;
                        output_buyer.Text = carapt.Order_list[i].Cus_name;
                        /*output_preview.Image = */
                    }
                }
                

                switch (carapt.Order_list[i].Model)
                {
                    case "Suzuki Model no.1":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model1.jpg");
                        break;

                    case "Suzuki Model no.2":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model2.jpg");
                        break;

                    case "Suzuki Model no.3":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model3.jpg");
                        break;

                    case "Suzuki Model no.4":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model4.jpg");
                        break;

                    case "Karasaki Model no.1":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model1.jpg");
                        break;

                    case "Karasaki Model no.2":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model2.jpg");
                        break;

                    case "Karasaki Model no.3":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model3.jpg");
                        break;

                    case "Karasaki Model no.4":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model4.jpg");
                        break;

                    case "Harley Model no.1":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model1.jpg");
                        break;

                    case "Harley Model no.2":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model2.jpg");
                        break;

                    case "Harley Model no.3":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model3.jpg");
                        break;

                    case "Harley Model no.4":
                        output_preview.Image = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model4.jpg");
                        break;
                }
            }

            if (output_name.Text == "")
            {
                MessageBox.Show("No data matches with inputed serial number");
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
