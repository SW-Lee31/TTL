using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0727_01_sigletone
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Random ran = new Random();

            for (int i = 0; i < 5; i++)
            {
                // 독립적인 객체 5개 생성
                Singletest test_01 = new Singletest(ran);
                Console.WriteLine("랜덤한 숫자 : {0}", test_01.getdata());
                // 같은 객체에서의 값 변경(객체는 하나로 동일)
                /*Singletest test_02 = Singletest.getinst(ran);*/
                Console.WriteLine("랜덤한 숫자 - 싱글톤 : {0}", Singletest.getinst(ran).getdata());
            }


        }
    }
}
