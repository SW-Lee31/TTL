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
using View_structure_0811.Util;

namespace View_structure_0811.UI.Order_contents
{
    public partial class Order_Main : MaterialForm
    {
        Order_jd jd_sheet;
        const string UI_NAME_ORDER_JD = "Order_jd";

        public Order_Main()
        {
            InitializeComponent();
            jd_sheet = new Order_jd();
        }

        private void Order_Main_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        void controllview(UserControl sheet, string viewname)
        {
            if (!main_panel.Controls.ContainsKey(viewname))
            {
                sheet.Dock = DockStyle.Fill;
                main_panel.Controls.Add(sheet);
            }

            main_panel.Controls[viewname].BringToFront();
        }

        private void but_jd_Click(object sender, EventArgs e)
        {
            controllview(jd_sheet, UI_NAME_ORDER_JD);
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
