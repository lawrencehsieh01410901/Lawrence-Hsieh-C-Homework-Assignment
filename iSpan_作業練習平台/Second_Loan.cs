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
    public partial class Second_Loan : Form
    {
        public static Second_Loan sform1;//???
        public static string ans1;
        public static string ans2;
        public static string ans3;
        public static string ans4;
        public static string ans5;
        public double Total;
        public double YearToMonth;
        public double ToMonthRate;
        public double FirstPay;
        public double AvgRatePay;
        public string MonthPay;
        public string TotalPay;
        public Second_Loan()
        {
            InitializeComponent();
        }

        private void Second_Loan_Load(object sender, EventArgs e)//怎麼改掉20230329???
        {
            sform1 = this;
            textBox1.Text = "100000";
            textBox2.Text = "2";
            textBox3.Text = "10";
            textBox4.Text = "0";
            ans1 = textBox1.Text;
            ans2 = textBox2.Text;
            ans3 = textBox3.Text;
        }
        private void Report_Click(object sender, EventArgs e)
        {
            Second_Loan_Report slr = new Second_Loan_Report();
            CalcData();//注意前後!!!!
            slr.Show();
            //CalcData();//你都把報表Show玩了，才計算，請問怎麼會顯示出來???
        }
        void CalcData() 
        {
            Total = double.Parse(textBox1.Text); //貸款金額
            ans1 = Total.ToString();//--->報表2-1 答案
            YearToMonth = (double.Parse(textBox2.Text)) * 12;//期限into 月份數
            //ans2 = YearToMonth.ToString();//--->報表2-1 答案
            ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//月利率計算
            //ans3 = ToMonthRate.ToString();//--->報表2-1 答案
            FirstPay = double.Parse(textBox4.Text);//頭期款
            //-------------->
            AvgRatePay = Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            string MonthPay_First;//月付款
            MonthPay_First = Convert.ToString(Math.Round(Math.Round(Total - FirstPay) * AvgRatePay));
            ans4 = MonthPay_First;//--->報表2-1 答案

            //double Total = double.Parse(textBox1.Text); //貸款金額
            //double YearToMonth = double.Parse(textBox2.Text) * 12;//期限into 月份數
            //double ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//利率計算
            //double FirstPay = double.Parse(textBox4.Text);//頭期款

            //double AvgRatePay = (Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate) / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            string TotalPay;
            //string MonthPay;//月付款

            MonthPay = Convert.ToString(Math.Round(Total - FirstPay) * AvgRatePay);
            //TotalPay = Convert.ToString(Total + double.Parse(MonthPay) * YearToMonth);//24
            TotalPay = Convert.ToString(Math.Round(double.Parse(MonthPay) * YearToMonth));//24
            ans5 = TotalPay;//--->報表2-2 答案
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
            */
            double Total = double.Parse(textBox1.Text); //貸款金額
            //ans1 = Total.ToString();//--->報表2-1 答案
            double YearToMonth = (double.Parse(textBox2.Text)) * 12;//期限into 月份數
            //ans2 = YearToMonth.ToString();//--->報表2-1 答案
            double ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//月利率計算
            //ans3 = ToMonthRate.ToString();//--->報表2-1 答案
            double FirstPay = double.Parse(textBox4.Text);//頭期款
            //-------------->
            double AvgRatePay = Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            string MonthPay;//月付款
            MonthPay = Convert.ToString(Math.Round(Math.Round(Total - FirstPay) * AvgRatePay));
            ans4 = MonthPay;//--->報表2-1 答案
            MessageBox.Show("月付款: " + MonthPay + "元");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(textBox1.Text); //貸款金額
            double YearToMonth = double.Parse(textBox2.Text) * 12;//期限into 月份數
            double ToMonthRate = ((double.Parse(textBox3.Text)) / 12) / 100;//利率計算
            double FirstPay = double.Parse(textBox4.Text);//頭期款

            double AvgRatePay = (Math.Pow((1 + ToMonthRate), YearToMonth) * ToMonthRate) / (Math.Pow((1 + ToMonthRate), YearToMonth) - 1);
            string TotalPay;
            string MonthPay;//月付款

            MonthPay = Convert.ToString(Math.Round(Total - FirstPay) * AvgRatePay);
            //TotalPay = Convert.ToString(Total + double.Parse(MonthPay) * YearToMonth);//24
            TotalPay = Convert.ToString(Math.Round(double.Parse(MonthPay) * YearToMonth));//24
            ans5 = TotalPay;//--->報表2-2 答案
            MessageBox.Show("總付款金額: " + TotalPay + "元");
        }
    }
}
