using Oracle0820.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle0820
{
    public partial class MainUI : Form
    {
        string table_name;
        string seq_name;
        int index = 1000;

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            OraMgr.Instance.connectDB();
        }

        private void but_oracle_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void but_create_table_Click(object sender, EventArgs e)
        {
            table_name = input_table_name.Text;
            seq_name = input_seq_name.Text;
            OraMgr.Instance.create_table(table_name, seq_name);
        }

        private void but_drop_table_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.drop_table(table_name, seq_name);
        }

        private void input_table_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void but_insert_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            int age = int.Parse(input_age.Text);
            string addr = input_addr.Text;
            string grade = input_grade.Text;
            

            OraMgr.Instance.insert_DB("STUDENT_T", index, name, age, addr, grade);
            index++;
        }

        private void but_show_Click(object sender, EventArgs e)
        {
            string column = "stu_id";
            table_name = "student_t";

            OraMgr.Instance.show_DB(table_name, column);
        }
    }
}
