using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726_01_array
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Array_operation result = new Array_operation(arr);

            Console.Write("배열의 합 : ");
            result.arr_sum();
            Console.Write("배열의 평균 : ");
            result.arr_avg();
        }
    }
}
