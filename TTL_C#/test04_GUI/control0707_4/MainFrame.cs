using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control0707_4
{
    public partial class MainFrame : Form
    {
        int price = 0;
        int amount = 0;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string line_maker = "#################################################";
            string br = "\n";
            void additional()
            {
               Console.WriteLine("\t구매하신 담배 총량은 : {0}개입니다.", amount);
               Console.WriteLine("\t결제금액은 {0}원입니다.", price);
               Console.WriteLine(line_maker);
               Console.WriteLine(br);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine(line_maker);
            Console.WriteLine("담배 자판기 프로그램 V1.0");
            Console.WriteLine(line_maker);
            Console.WriteLine(br);
            Console.WriteLine("원하는 담배를 메뉴에서 선택하세요.");
            Console.WriteLine(br);
            Console.WriteLine("1. 에쎄 골든 리프 : 6000원");
            Console.WriteLine("2. 에쎄 스페셜 골드 : 5000원");
            Console.WriteLine("3. 더원 블루 : 4500원");
            Console.WriteLine("4. 더원 오렌지 : 4500원");
            Console.WriteLine("5. 더원 화이트 : 4500원");
            Console.WriteLine(br);
            Console.WriteLine("0. 어플리케이션 이용 및 결제하기");
            Console.WriteLine(line_maker);
            Console.WriteLine(br);
            Console.Write("담배를 선택하세요 -> ");

            while (true)
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(line_maker);
                        Console.WriteLine("\n\t★에쎄 골든 리프를 선택하셨습니다.");
                        price += 6000;
                        ++amount;
                        additional();
                        break;
                
                    case 2:
                        Console.WriteLine(line_maker);
                        Console.WriteLine("\n\t★에쎄 스페셜 골드를 선택하셨습니다.");
                        price += 5000;
                        ++amount;
                        additional();
                        break;

                    case 3:
                        Console.WriteLine(line_maker);
                        Console.WriteLine("\n\t★더원블루를 선택하셨습니다.");
                        price += 4500;
                        ++amount;
                        additional();
                        break;

                    case 4:
                        Console.WriteLine(line_maker);
                        Console.WriteLine("\n\t★더원 오렌지를 선택하셨습니다.");
                        price += 4500;
                        ++amount;
                        additional();
                        break;

                    case 5:
                        Console.WriteLine(line_maker);
                        Console.WriteLine("\n\t★더원 화이트를 선택하셨습니다.");
                        price += 4500;
                        ++amount;
                        additional();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("0 ~ 5 까지의 값을 입력하세요.");
                        break;
                }

                if (choice == 0)
                {
                    break;
                }

            }

        }

        private void esse_special_Click(object sender, EventArgs e)
        {
            int cost = 5000;
            price += cost;
            ++amount;
            remind.Text = "에쎄 골든 리프를 선택하셨습니다.";
            amount_output.Text = "선택한 담배 개수 : " + amount;
            price_output.Text = price + "원";
        }

        private void esse_golden_Click(object sender, EventArgs e)
        {
            int cost = 6000;
            price += cost;
            ++amount;
            remind.Text = "에쎄 골든 리프를 선택하셨습니다.";
            amount_output.Text = "선택한 담배 개수 : " + amount;
            price_output.Text = price + "원";
        }

        private void one_blue_Click(object sender, EventArgs e)
        {
            int cost = 4500;
            price += cost;
            ++amount;
            remind.Text = "에쎄 골든 리프를 선택하셨습니다.";
            amount_output.Text = "선택한 담배 개수 : " + amount;
            price_output.Text = price + "원";
        }

        private void one_orange_Click(object sender, EventArgs e)
        {
            int cost = 4500;
            price += cost;
            ++amount;
            remind.Text = "에쎄 골든 리프를 선택하셨습니다.";
            amount_output.Text = "선택한 담배 개수 : " + amount;
            price_output.Text = price + "원";
        }

        private void one_white_Click(object sender, EventArgs e)
        {
            int cost = 4500;
            price += cost;
            ++amount;
            remind.Text = "에쎄 골든 리프를 선택하셨습니다.";
            amount_output.Text = "선택한 담배 개수 : " + amount;
            price_output.Text = price + "원";
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if (price_input.Text != null)
            { 
                int accept = int.Parse(price_input.Text);
                if (price < accept)
                {
                    result_output_2.Text = accept + "원 받았습니다.";
                    result_output.Text = "거스름돈은 " + (accept - price) + "원입니다.";
                }

                else if (price == accept)
                {
                    result_output_2.Text = accept + "원 받았습니다.";
                    result_output.Text = "딱 맞게 지불하셨습니다.";
                }

                else if (price > accept)
                {
                    result_output_2.Text = accept + "원 받았습니다.";
                    result_output.Text = (price - accept) + "원 만큼 모자랍니다.";
                }
            }
            if (price_input.Text == null)
            {
                MessageBox.Show("결제금액을 입력해주세요.");
            }
        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
