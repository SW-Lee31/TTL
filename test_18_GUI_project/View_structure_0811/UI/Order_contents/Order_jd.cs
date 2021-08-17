using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_structure_0811.UI.Order_contents
{
    public partial class Order_jd : UserControl
    {
        public Order_jd()
        {
            InitializeComponent();
        }

        private void but_shirt_Click(object sender, EventArgs e)
        {
            string model_name = "John deere t-shirt model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
            
        }

        private void but_bottom_Click(object sender, EventArgs e)
        {
            string model_name = "John deere working pants model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
        }

        private void but_cap_Click(object sender, EventArgs e)
        {
            string model_name = "John deere sweat cap model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
        }

        private void but_outer_Click(object sender, EventArgs e)
        {
            string model_name = "John deere outer model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
        }

        private void but_shoes_Click(object sender, EventArgs e)
        {
            string model_name = "John deere working shoes model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
        }


        void model_item_add(string model_name)
        {
            input_model.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                input_model.Items.Add(model_name + (i + 1));
            }
        }

        private void but_accesorry_Click(object sender, EventArgs e)
        {
            string model_name = "John deere accessory model no.";

            model_item_add(model_name);

            panel_blind.Visible = false;
        }

        private void input_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            input_color.Text = "";

            switch (input_model.Text)
            {
                case "John deere t-shirt model no.1":
                    input_color.Text = "Green";
                    input_color.Text = "Black";
                    break;

                case "John deere t-shirt model no.2":
                    input_color.Text = "Gray";
                    break;

                case "John deere t-shirt model no.3":
                    input_color.Text = "Green/Gray";
                    input_color.Text = "Blue";
                    break;
            }
        }
    }
}
