using Class0727_03_Winform.Util;
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

namespace Class0727_03_Winform.UI
{
    public partial class Sign_up : MaterialForm
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            Common.InitTheme_2(this);
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
