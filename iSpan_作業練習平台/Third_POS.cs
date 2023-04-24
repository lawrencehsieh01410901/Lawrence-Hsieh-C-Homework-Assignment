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
    public partial class Third_POS : Form
    {
        public int Total = 0; 
        public int Beer_Count = 0;
        public int Tequila_Count = 0;
        public int Whisky_Count = 0;
        public int Wine_Count = 0;

        public Third_POS()
        {
            InitializeComponent();
        }

        private void Beer_Click(object sender, EventArgs e)
        {
            Total = Total + 160;
            textBox1.Text = "$NT: " + Total;
            Beer_Count++;
            txtListShow();
        }

        private void Tequila_Click(object sender, EventArgs e)
        {
            Total = Total + 180;
            textBox1.Text = "$NT: " + Total;
            Tequila_Count++;
            txtListShow();
        }

        public void txtListShow() 
        {
            StringBuilder output = new StringBuilder();
            
            if(Beer_Count > 0) 
            {
                output.AppendLine("啤酒 Beer X " + Beer_Count + " 共NT$" + (160 * Beer_Count));
            }
            if (Tequila_Count > 0) 
            {
                output.AppendLine("龍舌蘭 Tequila X " + Tequila_Count + " 共NT$" + (180 * Tequila_Count));
            }
            if (Whisky_Count > 0)
            {
                output.AppendLine("威士忌 Whisky X " + Whisky_Count + " 共NT$" + (350 * Whisky_Count));
            }
            if (Wine_Count > 0)
            {
                output.AppendLine("紅酒 Wine X " + Wine_Count + " 共NT$" + (320 * Wine_Count));
            }

            textBox2.Text = output.ToString();
        }

        private void Whisky_Click(object sender, EventArgs e)
        {
            Total = Total + 350;
            textBox1.Text = "$NT: " + Total;
            Whisky_Count++;
            txtListShow();
        }

        private void RemoveList_Click(object sender, EventArgs e)
        {
            textBox2.Text = "目前清單為空:";
            textBox1.Text = "$NT: ";
            Total = 0;
            Beer_Count = 0;
            Tequila_Count = 0;
            Whisky_Count = 0;
            Wine_Count = 0;

    }

        private void Wine_Click(object sender, EventArgs e)
        {
            Total = Total + 320;
            textBox1.Text = "$NT: " + Total;
            Wine_Count++;
            txtListShow();
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: " + Total);
        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + Total +"\r\n" + "折扣後總金額: NT$" + Total * 0.9);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
