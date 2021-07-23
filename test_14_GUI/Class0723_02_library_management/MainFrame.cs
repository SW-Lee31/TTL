using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0723_02_library_management
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("대여 도서관 : {0}", Customer.LIBRARY);
            Console.WriteLine();
            Customer lender = new Customer("홍길동", "010-1234-4312", new Book("삼국지", "이문열", "장강출판사", "소설"));
            Customer lender2 = new Customer("전우치", "010-3241-1322", new Book("초한지", "황정운", "장강출판사", "소설"));
            lender.showCusomerInfo();
            Console.WriteLine();
            lender2.showCusomerInfo();
            
            
            Book lender2_book = lender2.getBook();
            lender2_book.setTitle("서유기");
            // == lender2.getbook().setTitle("서유기");
            lender.getBook().setTitle("삼국지");
        }
    }
}
