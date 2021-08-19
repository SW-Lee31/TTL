using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0708_2
{


    public partial class MainFrame : Form
    {
        int order_amount = 0;
        int pay = 0;
        int kimchi_amount = 0;
        int knife_amount = 0;
        int fest_amount = 0;
        int bibim_amount = 0;
        int soy_amount = 0;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void payment_Click(object sender, EventArgs e)
        {

        }

        private void kimchi_button_Click(object sender, EventArgs e)
        {
            string button_name = ((Control)sender).Name.ToString();

            Console.WriteLine("버튼 이름 : " + button_name);

            switch (button_name)
            {
                case "kimchi_button":
                    menu_output.Text = "김치찌개";
                    kimchi_amount++;
                    kimchi_num.Text = kimchi_amount.ToString();
                    pay += 5000;
                    payment.Text = pay.ToString();
                    break;

                case "soy_button":
                    menu_output.Text = "된장찌개";
                    soy_amount++;
                    soy_num.Text = soy_amount.ToString();
                    pay += 5000;
                    payment.Text = pay.ToString();
                    break;

                case "knife_button":
                    menu_output.Text = "칼국수";
                    knife_amount++;
                    knife_num.Text = knife_amount.ToString();
                    pay += 4500;
                    payment.Text = pay.ToString();
                    break;

                case "fest_button":
                    menu_output.Text = "잔치국수";
                    fest_amount++;
                    fest_num.Text = fest_amount.ToString();
                    pay += 4000;
                    payment.Text = pay.ToString();
                    break;

                case "bibim_button":
                    menu_output.Text = "비빔밥";
                    bibim_amount++;
                    rice_num.Text = bibim_amount.ToString();
                    pay += 5000;
                    payment.Text = pay.ToString();
                    break;
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void soy_button_Click(object sender, EventArgs e)
        {

        }

        private void payprice_Click(object sender, EventArgs e)
        {
            int price = int.Parse(price_input.Text);

            if (pay < price)
            {
                warn.Text = "거스름돈은 " + (price - pay) + "원 입니다.";
            }

            else if (pay > price)
            {
                warn.Text = "결제금액이 모자랍니다.";
            }

            else
            {
                warn.Text = "딱 맞게 계산 하셨습니다.";
            }
        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
