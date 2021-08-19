using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_07_odd_multiple_table
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Print_odd_multi();
        }

        void Print_odd_multi()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write("{0} X {1} = {2}\t", j, i, (i * j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
