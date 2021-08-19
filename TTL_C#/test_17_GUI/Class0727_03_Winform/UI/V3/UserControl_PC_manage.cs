using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0727_03_Winform.UI
{
    public partial class UserControl_PC_manage : UserControl
    {
        public UserControl_PC_manage()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            new UserControl_Signin().Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".........................");
        }
    }
}
