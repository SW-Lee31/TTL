using Class0727_03_Winform.Util;
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

namespace Class0727_03_Winform.UI
{
    public partial class Main_user : MaterialForm
    {

        // Mouse 이동
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int Wparam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108

        UserControl_Home home_sheet;
        UserControl_secure security_sheet;
        UserControl_PC_manage manage_sheet;
        const string UC_NAME_HOME = "UserControl_Home";
        const string UC_NAME_SECURE = "UserControl_secure";
        const string UC_NAME_MANAGE = "UserControl_PC_manage";

        public Main_user()
        {
            InitializeComponent();
            home_sheet = new UserControl_Home();
            security_sheet = new UserControl_secure();
            manage_sheet = new UserControl_PC_manage();
            center_layout.Controls.Add(home_sheet);
            center_layout.Dock = DockStyle.Fill;
        }

        private void Main_user_Load(object sender, EventArgs e)
        {
            Common.InitTheme_3(this);
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void top_nav_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void controllView(UserControl uc, string viewName)
        {
            if (!center_layout.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                center_layout.Controls.Add(uc);
            }
            center_layout.Controls[viewName].BringToFront();
        }

        private void uiHeaderButton1_Click(object sender, EventArgs e)
        {
            controllView(home_sheet, UC_NAME_HOME);
        }

        private void uiHeaderButton2_Click(object sender, EventArgs e)
        {
            controllView(security_sheet, UC_NAME_SECURE);
        }

        private void uiHeaderButton3_Click(object sender, EventArgs e)
        {
            controllView(manage_sheet, UC_NAME_MANAGE);
        }
    }
}
