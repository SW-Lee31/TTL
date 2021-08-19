using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input0706
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void sum_button_Click(object sender, EventArgs e)
        {
            int korean = int.Parse(korean_input.Text);
            int english = int.Parse(english_input.Text);
            int math = int.Parse(math_input.Text);
            int society = int.Parse(society_input.Text);
            int science = int.Parse(science_input.Text);

            int sum_result = korean + english + math + society + science;
            sum_output.Text = sum_result.ToString();
        }

        private void average_button_Click(object sender, EventArgs e)
        {
            int korean = int.Parse(korean_input.Text);
            int english = int.Parse(english_input.Text);
            int math = int.Parse(math_input.Text);
            int society = int.Parse(society_input.Text);
            int science = int.Parse(science_input.Text);

            double average_result = (korean + english + math + society + science) / 5;
            average_output.Text = average_result.ToString();


            if (average_result > 85)
                level_output.Text = "A";

            else if (average_result > 75)
                level_output.Text = "B";

            else if (average_result > 65)
                level_output.Text = "C";

            else
                level_output.Text = "F";
        }

        private void level_output_Click(object sender, EventArgs e)
        {

        }

        private void korean_input_TextChanged(object sender, EventArgs e)
        {
            int korean = int.Parse(korean_input.Text);
            if (korean > 100)
                MessageBox.Show("1 ~ 100의 점수를 입력해주세요.");
        }

        private void english_input_TextChanged(object sender, EventArgs e)
        {
            int english = int.Parse(english_input.Text);
            if (english > 100)
                MessageBox.Show("1 ~ 100의 점수를 입력해주세요.");
        }

        private void math_input_TextChanged(object sender, EventArgs e)
        {
            int math = int.Parse(math_input.Text);
            if (math > 100)
                MessageBox.Show("1 ~ 100의 점수를 입력해주세요.");
        }

        private void society_input_TextChanged(object sender, EventArgs e)
        {
            int society = int.Parse(society_input.Text);
            if (society > 100)
                MessageBox.Show("1 ~ 100의 점수를 입력해주세요.");
        }

        private void science_input_TextChanged(object sender, EventArgs e)
        {
            int science = int.Parse(science_input.Text);
            if (science > 100)
                MessageBox.Show("1 ~ 100의 점수를 입력해주세요.");
        }
    }
}
