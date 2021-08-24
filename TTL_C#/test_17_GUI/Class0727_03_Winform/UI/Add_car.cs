﻿using Class0727_03_Winform.Adapter;
using Class0727_03_Winform.Model;
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
    partial class Add_car : MaterialForm
    {
        CusAdpater cusapt;
        CarAdapter carapt;

        string brand;
        string model;
        string color;
        string cus_name;
        string date;
        string se_num;

        public Add_car()
        {
            InitializeComponent();
        }

        public Add_car(CusAdpater cusapt, CarAdapter carapt)
        {
            InitializeComponent();
            this.cusapt = cusapt;
            this.carapt = carapt;
        }

        private void Add_car_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
            brand_choose();

            input_cusname.Items.Clear();

            for (int name_index = 0; name_index < cusapt.Cus_list.Count; name_index++)
            {
                input_cusname.Items.Add(cusapt.Cus_list[name_index].Name);
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            brand = input_brand.Text;
            model = input_model.Text;
            color = input_color.Text;
            cus_name = input_cusname.Text;
            se_num = input_senum.Text;
            DateTime dateTime = input_date.Value;
            date = string.Format("{0}년 {1}월 {2}일", dateTime.Year, dateTime.Month, dateTime.Day);

            List<string> se_num_list = new List<string>();
            List<string> brand_list = new List<string>();
            List<string> model_list = new List<string>();
            List<string> color_list = new List<string>();
            List<string> date_list = new List<string>();


            se_num_list.Add(se_num);
            brand_list.Add(brand);
            model_list.Add(model);
            color_list.Add(color);
            date_list.Add(date);


            if (carapt.Order_list.Count == 0)
            {
                for (int i = 0; i < cusapt.Cus_list.Count; i++)
                {
                    if (cus_name == cusapt.Cus_list[i].Name)
                    {
                        Car car_index = new Car(brand_list, model_list, color_list, cusapt.Cus_list[i], se_num_list, date_list);
                        carapt.Add_order_list(car_index);
                    }
                }
            }

            else
            {
                for (int i = 0; i < carapt.Order_list.Count; i++)
                {
                    if (cus_name == carapt.Order_list[i].Cus.Name)
                    {
                        carapt.Order_list[i].Se_num_list.Add(se_num);
                        carapt.Order_list[i].Brand_list.Add(brand);
                        carapt.Order_list[i].Model_list.Add(model);
                        carapt.Order_list[i].Color_list.Add(color);
                        carapt.Order_list[i].Date_list.Add(date);
                    }

                    else
                    {
                        for (int j = 0; j < cusapt.Cus_list.Count; j++)
                        {
                            if (cus_name == cusapt.Cus_list[j].Name)
                            {
                                Car car_index = new Car(brand_list, model_list, color_list, cusapt.Cus_list[j], se_num_list, date_list);
                                carapt.Add_order_list(car_index);
                                break;
                            }
                        
                        }
                        break;
                    }
                }
            }
            carapt.show_list();
        }

        private void input_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            color_choose();
        }

        private void input_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            model_choose();
        }

        private void input_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void brand_choose()
        {
            input_brand.Items.Clear();
            input_brand.Items.Add("Suzuki");
            input_brand.Items.Add("Karasaki");
            input_brand.Items.Add("Harley");
        }

        void model_choose()
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

        void color_choose()
        {
            input_color.Items.Clear();

            Image model_img;

            string model = input_model.SelectedItem.ToString();

            switch (model)
            {
                case "Suzuki Model no.1":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model1.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Blue");
                    break;

                case "Suzuki Model no.2":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model2.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    input_color.Items.Add("Red");
                    break;

                case "Suzuki Model no.3":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model3.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    break;

                case "Suzuki Model no.4":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\suzuki_model4.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Black");
                    break;

                case "Karasaki Model no.1":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model1.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black/Green");
                    break;

                case "Karasaki Model no.2":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model2.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Sand");
                    break;

                case "Karasaki Model no.3":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model3.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Black");
                    break;

                case "Karasaki Model no.4":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\karasaki_model4.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Chrom");
                    input_color.Items.Add("Green");
                    break;

                case "Harley Model no.1":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model1.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    break;

                case "Harley Model no.2":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model2.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    input_color.Items.Add("chrom");
                    break;

                case "Harley Model no.3":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model3.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    input_color.Items.Add("White");
                    break;

                case "Harley Model no.4":
                    model_img = Image.FromFile(@"C:\c#_work\test_17_GUI\Class0727_03_Winform\Resource\harley_model4.jpg");
                    output_preview.Image = model_img;
                    input_color.Items.Add("Black");
                    input_color.Items.Add("Brown");
                    break;
            }
        }

        private void input_cusname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}