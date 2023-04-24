using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan_作業練習平台
{
    public partial class Second_Loan_Report : Form
    {
        public Second_Loan_Report()
        {
            InitializeComponent();
        }

        private void Second_Loan_Report_Load(object sender, EventArgs e)
        {
            label6.Text = Second_Loan.ans1;
            label7.Text = Second_Loan.ans2;
            label8.Text = Second_Loan.ans3;//20230407抓錯欄位
            label9.Text = Second_Loan.ans4;
            label10.Text = Second_Loan.ans5;
        }
    }
}
