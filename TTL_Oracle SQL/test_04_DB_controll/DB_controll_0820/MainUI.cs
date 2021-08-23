using DB_controll_0820.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_controll_0820
{
    public partial class MainUI : Form
    {
        string table_name;

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            Oramgr.Instance.connect_DB();
            /*Oramgr.Instance.create_sequence();*/
        }

        private void but_create_table_Click(object sender, EventArgs e)
        {
            table_name = input_table_name.Text;

            Oramgr.Instance.create_table(table_name);
        }

        private void but_show_Click(object sender, EventArgs e)
        {
            Oramgr.Instance.show_DB(table_name);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string celeb = input_cel.Text;
            int effect = int.Parse(input_effect.Text);
            int dev = int.Parse(input_dev.Text);
            string fuct = input_fuct.Text;

            Oramgr.Instance.insert_DB(table_name, celeb, effect, dev, fuct);
        }

        private void but_drop_table_Click(object sender, EventArgs e)
        {
            Oramgr.Instance.drop_table(table_name);
        }
    }
}
