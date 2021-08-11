using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.UI.UI_contents.Sign;

namespace View_structure_0811.UI.UI_contents
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void uiHeaderButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SW-Lee31");
        }

        private void uiHeaderButton4_Click(object sender, EventArgs e)
        {
            new Sign_in().ShowDialog();
        }
    }
}
