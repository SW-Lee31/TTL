using MaterialSkin;
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

namespace Class0727_02_Winform
{
    public partial class MainUI : MaterialForm
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            initTheme();
        }

        void initTheme()
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey600,
                Primary.LightBlue500,
                Accent.Cyan400,
                TextShade.WHITE);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            

        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by SW-Lee31 on 2021.07.27", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("정말로 종료하시겠습니까? ", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_maximum_Click(object sender, EventArgs e)
        {
        }
    }
}
