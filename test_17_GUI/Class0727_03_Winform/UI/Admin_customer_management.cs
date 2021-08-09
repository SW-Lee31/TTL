using Class0727_03_Winform.Adapter;
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
    partial class Admin_customer_management : MaterialForm
    {
        CusAdpater cusapt;
        CarAdapter carapt;

        int LIST_INDEX = 6;

        public Admin_customer_management()
        {
            InitializeComponent();
        }

        public Admin_customer_management(CusAdpater cusapt, CarAdapter carapt)
        {
            InitializeComponent();
            this.cusapt = cusapt;
            this.carapt = carapt;
        }

        private void Admin_customer_management_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
            init_list_view();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void init_list_view()
        {
            /*string[] list_data = { "1", "홍길동", "01012341234", "ㅏㄴㅁ안어ㅜ무1동", "남자", "2021년 8월 9일", "1991년 1월 11일" };*/

            for (int i = 0; i < cusapt.Cus_list.Count; i++)
            {
                string[] list_data = { (i + 1).ToString(), cusapt.Cus_list[i].Name, cusapt.Cus_list[i].Digit, cusapt.Cus_list[i].Addr,
                    cusapt.Cus_list[i].Gender, cusapt.Cus_list[i].Date, cusapt.Cus_list[i].Birth };

                cus_listview.Items.Add(new ListViewItem(list_data));
            }
        }

        void init_gird_view()
        {
            /*string[] gird_data = { "intoroduce", "internet" };*/

            /*for (int i = 0; i < cusapt.Cus_list.Count; i++)
            {
                string[] gird_data = new string[cusapt.Cus_list[i].Sub_path.Count];
                for (int j = 0; j < cusapt.Cus_list[i].Sub_path.Count; j++)
                {
                    gird_data[j] = cusapt.Cus_list[i].Sub_path[j];
                    cus_sub_path.Rows.Add(gird_data[i]);
                }
            }*/


        }

        private void uiImageListBox1_ItemClick(object sender, EventArgs e)
        {

        }

        private void cus_listview_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }

        private void Admin_customer_management_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cus_listview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cus_sub_path.Rows.Clear();
            ordered_senum.Rows.Clear();

            string name = cus_listview.FocusedItem.SubItems[1].Text;

            for (int i = 0; i < cusapt.Cus_list.Count; i++)
            {
                if (name == cusapt.Cus_list[i].Name)
                {
                    for (int j = 0; j < cusapt.Cus_list[i].Sub_path.Count; j++)
                    {
                        cus_sub_path.Rows.Add(cusapt.Cus_list[i].Sub_path[j]);
                        ordered_senum.Rows.Add(carapt.Order_list[i].Se_num[j]);
                    }
                }
            }
        }
    }
}
