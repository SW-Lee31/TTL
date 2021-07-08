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
        int knife = 0;
        int fest = 0;
        int bibim = 0;
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
            menu_output.Text = "김치찌개";
            ++kimchi_amount;
            kimchi_num.Text = kimchi_amount.ToString();
            pay += 5000;
            payment.Text = pay.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            menu_output.Text = "칼국수";
            ++knife;
            knife_num.Text = knife.ToString();
            pay += 4500;
            payment.Text = pay.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu_output.Text = "잔치국수";
            ++fest;
            fest_num.Text = fest.ToString();
            pay += 4000;
            payment.Text = pay.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu_output.Text = "비빔밥";
            ++bibim;
            rice_num.Text = bibim.ToString();
            pay += 4000;
            payment.Text = pay.ToString();
        }

        private void soy_button_Click(object sender, EventArgs e)
        {
            menu_output.Text = "된장찌개";
            soy_amount += 1;
            soy_num.Text = soy_amount.ToString();
            pay += 5000;
            payment.Text = pay.ToString();
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
