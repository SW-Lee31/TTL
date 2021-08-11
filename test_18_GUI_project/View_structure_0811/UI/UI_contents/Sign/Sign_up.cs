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

namespace View_structure_0811.UI.UI_contents.Sign
{
    public partial class Sign_up : MaterialForm
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        private void but_submit_Click(object sender, EventArgs e)
        {

        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
