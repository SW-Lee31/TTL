using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.Util;

namespace View_structure_0811.UI.UI_contents
{
    public partial class Admin_main_form : MaterialForm
    {
        #region
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int Wparam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108
        #endregion //마우스조작

        Admin_Customer_manage admin_customer_manage;
        const string UI_NAME_ADMIN_CUSTOMER_MANAGE = "Admin_Customer_manage";
        Admin_contents.Admin_stock_management admin_stock_management;
        const string UI_NAME_ADMIN_STOCK_MANAGE = "Admin_stock_management";

        public Admin_main_form()
        {
            InitializeComponent();
            admin_customer_manage = new Admin_Customer_manage();
            admin_stock_management = new Admin_contents.Admin_stock_management();
        }

        private void Admin_main_form_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void but_cus_add_Click(object sender, EventArgs e)
        {
            controllView(admin_customer_manage, UI_NAME_ADMIN_CUSTOMER_MANAGE);
        }

        private void but_add_stuff_Click(object sender, EventArgs e)
        {
            controllView(admin_stock_management, UI_NAME_ADMIN_STOCK_MANAGE);
        }
    }
}
