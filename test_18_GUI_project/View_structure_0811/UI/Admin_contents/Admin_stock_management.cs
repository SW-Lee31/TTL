using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.UI.Admin_contents.Admin_stock_management_contents;

namespace View_structure_0811.UI.Admin_contents
{
    public partial class Admin_stock_management : UserControl
    {
        string page_change;

        public Admin_stock_management()
        {
            InitializeComponent();
        }

        private void but_stock_digit_Click(object sender, EventArgs e)
        {
            page_change = "serial";
            new Admin_stock_management_main(page_change).Show();
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            page_change = "del";
            new Admin_stock_management_main(page_change).Show();
        }
    }
}
