using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input_04
{
    public partial class MainForm_03 : Form
    {
        public MainForm_03()
        {
            InitializeComponent();
        }

        private void MainForm_03_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void sum_botton_Click(object sender, EventArgs e)
        {
            int korean = int.Parse(korean_input.Text);
            int english = int.Parse(english_input.Text);
            int math = int.Parse(math_input.Text);
            int society = int.Parse(society_input.Text);
            int science = int.Parse(science_input.Text);

            int sum_result = korean + english + math + society + science;
            sum.Text = sum_result.ToString();
        }

        private void korean_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(korean_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100의 값을 입력해주세요");
            }
        }

        private void ave_button_Click(object sender, EventArgs e)
        {
            int korean = int.Parse(korean_input.Text);
            int english = int.Parse(english_input.Text);
            int math = int.Parse(math_input.Text);
            int society = int.Parse(society_input.Text);
            int science = int.Parse(science_input.Text);

            int ave_result = (korean + english + math + society + science) / 5;
            average.Text = ave_result.ToString();

            if (ave_result >= 90)
            {
                level_value.Text = "A 입니다.";
            }
            else if (ave_result >= 80)
            {
                level_value.Text = "B 입니다.";
            }
            else if (ave_result >= 70)
            {
                level_value.Text = "B- 입니다.";
            }
            else if (ave_result >= 60)
            {
                level_value.Text = "C 입니다.";
            }
            else
            {
                level_value.Text = "D 입니다.";
            }
        }

        private void english_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(english_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100의 값을 입력해주세요");
            }
        }

        private void math_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(math_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100의 값을 입력해주세요");
            }
        }

        private void society_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(society_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100의 값을 입력해주세요");
            }
        }

        private void science_input_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(science_input.Text) > 100)
            {
                MessageBox.Show("1 ~ 100의 값을 입력해주세요");
            }
        }

        private void english_Click(object sender, EventArgs e)
        {

        }
    }
}
