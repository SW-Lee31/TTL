using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Method0716_10_sum
{

    public partial class MainFrame : Form
    {
        StreamWriter writer = new StreamWriter(@"c:\\c#_work\test_10_GUI\test.txt");
        Random ran = new Random();
        string[] name_arr = new string[50];
        string name_collection = "";
        int index = 0;
        const int INDEX_NUM = 50;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        string Create_name()
        {
            string[] first_name = new string[]
            {
                "김", "박", "이", "최", "장", "정", "심", "황", "양"
            };

            string[] middle_name = new string[]
            {
                "상", "준", "희", "건", "정", "제", "창", "건", "호"
            };

            string[] last_name = new string[]
            {
                "원", "혁", "환", "윤", "훈", "진", "헌", "현", "영"
            };

            name_collection += first_name[ran.Next(9)];
            name_collection += middle_name[ran.Next(9)];
            name_collection += last_name[ran.Next(9)];

            return name_collection;
        }

        string Clear()
        {
            name_collection = "";

            return name_collection;
        }

        string[] Insert_name(int index, string name_collection)
        {
            name_arr[index] = name_collection;

            return name_arr;
        }

        string Choose_name(int index)
        {
            string name_choosed;
            name_choosed = name_arr[index - 1];

            return name_choosed;
        }

        string Drop_name(int index)
        {
            string name_dropped;
            name_dropped = name_arr[index - 1];
            name_arr[index - 1] = null;

            return name_dropped;
        }

        void Delete_all()
        {
            for (int i = 0; i < INDEX_NUM; i++)
            {
                name_arr[i] = null;
            }
        }

        void Commit()
        {
            for (int i = 0; i < INDEX_NUM; i++)
            {
                writer.WriteLine("{0}번 리스트 -> {1}", (i + 1), name_arr[i]);
            }
            writer.Close();
        }

        private void name_create_button_Click(object sender, EventArgs e)
        {
            string C_name = Create_name();
            name_output.Text = "";
            name_output_show.Text = C_name + " is created";
            Clear();
            Insert_name(index, C_name);
            index++;
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            name_output_show.Text = "";
            name_output.Text = Choose_name(int.Parse(print_index_input.Text)) + " is the name you searched";
        }

        private void drop_button_Click(object sender, EventArgs e)
        {
            name_output_show.Text = "";
            name_output.Text = Drop_name(int.Parse(drop_index_input.Text)) + " is the name you dropped";
        }

        private void commit_button_Click(object sender, EventArgs e)
        {
            name_output_show.Text = "";
            name_output.Text = "The elements are loaded in \'test.txt\'";
            Commit();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            name_output_show.Text = "";
            Delete_all();
            name_output.Text = "All elements are deleted";
            index = 0;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }
    }
}
