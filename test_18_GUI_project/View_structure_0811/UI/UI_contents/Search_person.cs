using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_structure_0811.UI.UI_contents
{
    public partial class Search_person : UserControl
    {
        public Search_person()
        {
            InitializeComponent();
        }

        private void link_name_search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Add_person_name_search.Add_person_name_search().Show();
        }
    }
}
