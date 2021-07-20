using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0720
{
    class Dog
    {
        public string name;
        public string gender;
        public string owner_name;

        public void Bark()
        {
            Console.WriteLine("{0} : 멍멍!", name);
        }
    }
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
