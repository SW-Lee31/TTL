using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array0713_2
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            double[] arr_int = new double[10];
            double sum = 0;
            double average = 0;

            for (int i = 1; i <= 10; i++)
            {
                arr_int[i - 1] = i;
                Console.WriteLine("arr_int[{0}]의 값은 {1}입니다.", (i - 1), arr_int[i - 1]);
                sum += arr_int[i - 1];
            }
            

            Console.WriteLine("배열 안의 값들의 합은 : {0} 입니다.", sum);
            average = sum / arr_int.Length;
            Console.WriteLine("배열 안의 값들의 평균은 : {0} 입니다.", average);
        }
    }
}
