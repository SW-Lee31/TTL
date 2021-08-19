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

namespace View_structure_0811.UI.Admin_contents.Admin_stock_management_contents
{
    public partial class Admin_stock_management_main : MaterialForm
    {
        Admin_stock_management_serial serial_sheet;
        Admin_stock_management_del del_sheet;
        const string UI_NAME_ADMIN_STOCK_MANAGEMENT_SERIAL = "Admin_stock_management_serial";
        const string UI_NAME_ADMIN_STOCK_MANAGEMENT_DEL = "Admin_stock_management_del";
        string page_change;

        public Admin_stock_management_main()
        {
            InitializeComponent();
        }

        public Admin_stock_management_main(string page_change)
        {
            InitializeComponent();
            this.page_change = page_change;
            serial_sheet = new Admin_stock_management_serial();
            del_sheet = new Admin_stock_management_del();
        }

        private void Admin_stock_management_main_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);

            switch (page_change)
            {
                case "serial":
                    controllView(serial_sheet, UI_NAME_ADMIN_STOCK_MANAGEMENT_SERIAL);
                    break;

                case "del":
                    controllView(del_sheet, UI_NAME_ADMIN_STOCK_MANAGEMENT_DEL);
                    break;
            }
        }

        void controllView(UserControl uc, string viewName)
        {
            if (!main_panel.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                main_panel.Controls.Add(uc);
            }
            main_panel.Controls[viewName].BringToFront();
        }

        private void but_input_serial_Click(object sender, EventArgs e)
        {
            controllView(serial_sheet, UI_NAME_ADMIN_STOCK_MANAGEMENT_SERIAL);
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void but_manage_del_Click(object sender, EventArgs e)
        {
            controllView(del_sheet, UI_NAME_ADMIN_STOCK_MANAGEMENT_DEL);
        }
    }
}
