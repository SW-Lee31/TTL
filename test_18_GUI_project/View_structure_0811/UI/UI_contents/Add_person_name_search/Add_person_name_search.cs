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

namespace View_structure_0811.UI.UI_contents.Add_person_name_search
{
    public partial class Add_person_name_search : MaterialForm
    {
        public Add_person_name_search()
        {
            InitializeComponent();
        }

        private void Add_person_name_search_Load(object sender, EventArgs e)
        {
            Common.Theme_light(this);
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
