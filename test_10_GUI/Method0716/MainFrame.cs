using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716
{
    public partial class MainFrame : Form
    {
        string name = "Grobal Main Form";
        public MainFrame()
        {
            InitializeComponent();
        }

        // Winform이 실행되기 전에 Console내부에서 작동하는 메서드
        private void MainFrame_Load(object sender, EventArgs e)
        {
            // 동일 변수명일 경우 로컬이 우선됨(로컬에서 새로 할당된다고 생각하면 됨)
            string name = "Local Main Form";
            Console.WriteLine("\"{0}\" is now on activate - in MainFrame_Load", name);
            MessageBox.Show("MainFrame_Load is running");
            function_2();
            Console.WriteLine("Method \"Plus\" is called with parameter 10 and 20 -> result : {0}", Plus(10, 20));
            Console.WriteLine("every method is called");
        }

        //  1. void 메서드명(함수명) + () -> 파라미터 받는 곳 
        void function_1()
        {
            Console.WriteLine("\"{0}\" is now on activate - in function_1", name);
            MessageBox.Show("function_1 is called.");
        }

        void function_2()
        {
            Console.WriteLine("\"{0}\" is now on activate - in fucntion_2", name);
            MessageBox.Show("function_2 is called");
            function_1();
        }

        // 2. data_type -> {반환(return)값의 자료형} 메서드명(parameter)
        int Plus(int x, int y)
        {
            MessageBox.Show("Plus is called");
            return x + y;
        }

    }
}
