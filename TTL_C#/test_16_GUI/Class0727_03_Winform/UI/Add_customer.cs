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
    public partial class Add_customer : MaterialForm
    {
        public Add_customer()
        {
            InitializeComponent();
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {
            Common.InitTheme(this);
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
