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
using View_structure_0811.UI.UI_contents;
using View_structure_0811.Util;

namespace View_structure_0811.UI
{
    
    public partial class MainUI : MaterialForm
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
        #endregion  //마우스 클릭

        Home home_sheet;
        const string UI_HOME = "Home";

        public MainUI()
        {
            InitializeComponent();
            home_sheet = new Home();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
            controllview(home_sheet, UI_HOME);
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

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

        private void but_close_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void but_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void but_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by SW-Lee31", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
