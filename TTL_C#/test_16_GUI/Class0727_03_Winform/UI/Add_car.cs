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
    public partial class Add_car : MaterialForm
    {
        public Add_car()
        {
            InitializeComponent();
        }

        private void Add_car_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }



        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {

        }

        private void input_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_color.Items.Clear();

            Image model_img;

            string model = input_model.SelectedItem.ToString();

            switch (model)
            {
                case "Suzuki Model no.1":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model1.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Blue");
                    break;

                case "Suzuki Model no.2":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model2.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    input_color.Items.Add("Red");
                    break;

                case "Suzuki Model no.3":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model3.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    break;

                case "Suzuki Model no.4":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\suzuki_model4.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Black");
                    break;

                case "Karasaki Model no.1":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model1.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black/Green");
                    break;

                case "Karasaki Model no.2":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model2.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Sand");
                    break;

                case "Karasaki Model no.3":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model3.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Black");
                    break;

                case "Karasaki Model no.4":
                    model_img = Image.FromFile(@"C:\c#_work\test_16_GUI\Class0727_03_Winform\Resource\karasaki_model4.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Green");
                    break;
            }

        }

        private void input_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_model.Items.Clear();

            if (input_brand.SelectedItem.ToString() == "Suzuki")
            {
                input_model.Items.Add("Suzuki Model no.1");
                input_model.Items.Add("Suzuki Model no.2");
                input_model.Items.Add("Suzuki Model no.3");
                input_model.Items.Add("Suzuki Model no.4");
            }

            else if (input_brand.SelectedItem.ToString() == "Karasaki")
            {
                input_model.Items.Add("Karasaki Model no.1");
                input_model.Items.Add("Karasaki Model no.2");
                input_model.Items.Add("Karasaki Model no.3");
                input_model.Items.Add("Karasaki Model no.4");
            }

            else if (input_brand.SelectedItem.ToString() == "Harley")
            {
                input_model.Items.Add("Harley Model no.1");
                input_model.Items.Add("Harley Model no.2");
                input_model.Items.Add("Harley Model no.3");
                input_model.Items.Add("Harley Model no.4");
            }
        }

        private void input_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (input_color.SelectedItem.ToString() == "Blue")
            {
                output_stock.Text = 4.ToString();
            }

            else if (input_color.SelectedItem.ToString() == "Black")
            {
                output_stock.Text = 11.ToString();
            }

            else if (input_color.SelectedItem.ToString() == "Chrom")
            {
                output_stock.Text = 7.ToString();
            }

            else if (input_color.SelectedItem.ToString() == "Sand")
            {
                output_stock.Text = 3.ToString();
            }

            else if (input_color.SelectedItem.ToString() == "Green")
            {
                output_stock.Text = 18.ToString();
            }

            else if (input_color.SelectedItem.ToString() == "Black/Green")
            {
                output_stock.Text = "No Stock remaining";
            }

            else if (input_color.SelectedItem.ToString() == "Red")
            {
                output_stock.Text = 2.ToString();
            }
        }
    }
}
