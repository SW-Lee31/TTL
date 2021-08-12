using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_structure_0811.UI.UI_contents.Track_del_info;

namespace View_structure_0811.UI.UI_contents
{
    public partial class Tracking_del : UserControl
    {
        string location;

        public Tracking_del()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            new Tracking_del_info_map(location).Show();
        }
    }
}
