using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0722_02_array_operation
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            double[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Operation oper = new Operation(arr);

            Console.WriteLine("배열의 합은 {0}, 평균은 {1}입니다. ", oper.sum_result(), oper.avg_result());
        }
    }
}
