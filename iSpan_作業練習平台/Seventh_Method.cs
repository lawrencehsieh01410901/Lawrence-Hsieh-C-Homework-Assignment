using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace iSpan_作業練習平台
{
    public partial class Seventh_Method : Form
    {
        public int[] data = new int[] {-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578,999 };
        public string[] names = new string[] {"mother張", "emma", "迪克蕭","J40", "Candy", "cindy", "Cocount", "cassidy", "Cat" };
        public int[] dataReverse = new int[] { 1,2,3 };
        public string[] dataReverseName = new string[] { "n1", "n2", "n3" };
        public Seventh_Method()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;
            if (string.IsNullOrEmpty(answer) || answer == "0") 
            {
                MessageBox.Show("請輸入數字!!!");
            }
            else 
            {
                if (Convert.ToInt32(answer) % 2 == 0)
                {
                    label3.Text = $"輸入的數字: {answer} 為偶數";
                }
                else
                {
                    label3.Text = $"輸入的數字: {answer} 為奇數";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int oddNumber = 0;
            int evenNumber = 0;
            for(int i = 0; i < data.Length; i++) 
            {
                if (data[i] % 2 == 0)
                {
                    evenNumber += 1;
                }
                else 
                {
                    oddNumber += 1; 
                }
            }
            label3.Text = "陣列[-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578,999]中，\r\n" +
                "奇數共: " + oddNumber + "個\r\n" +
                "偶數共: " + evenNumber + "個";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string longest = names.OrderByDescending(s => s.Length).First();//Callback function???
            label3.Text = "陣列[\"mother張\", \"emma\", \"迪克蕭\",\"J40\"]中，\r\n" +
                "最長名字為: " + longest;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //dataMax = data.Max();
            int dataMax = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > dataMax)
                    dataMax = data[i];
            }
            //-->
            int dataMin = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < dataMin)
                    dataMin = data[i];
            }
            label3.Text = "陣列[-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578, 999]中，\r\n" +
                "Max Value: " + dataMax + "\r\n" +
                "Min Value: " + dataMin;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            for (int i = 1; i <= 10; i++) 
            {
               if(i == 1 || i == 10) 
                {
                    label3.Text += "1 1 1 1 1 1 1 1 1 1\r\n"; 
                }
                else 
                {
                    label3.Text += "1 0 0 0 0 0 0 0 0 1\r\n";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "\r\n";
            for (int i = 0; i < dataReverse.Length; i++) 
            {
                label3.Text += "換位前，" + dataReverseName[i] + " = " + dataReverse[i] + "\r\n";
            }
            Array.Reverse(dataReverse);
            for (int i = 0; i < dataReverse.Length; i++)
            {
                label3.Text += "換位後，" + dataReverseName[i] + " = " + dataReverse[i] + "\r\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i<data.Length; i++) 
            {
                sum += data[i];
            }
            label3.Text = "陣列[-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578, 999]中，\r\n" +
                "加總後: " + sum;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ansMax = data.Max();
            label3.Text = "陣列[-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578, 999]中，\r\n" +
                "最大: " + ansMax;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ansMin = data.Min();
            label3.Text = "陣列[-1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578, 999]中，\r\n" +
                "最小: " + ansMin;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string name in names)
            {
                if (name.Contains("C") || name.Contains("c"))
                {
                    count += 1; 
                }
                label3.Text = "陣列[\"mother張\", \"emma\", \"迪克蕭\",\"J40\", \r\n \"Candy\", \"cindy\", \"Cocount\", \"cassidy\"\r\n], , \"Cat\"" +
                    "共有: " + count + "個含有C / c";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here";
            label3.BackColor = Color.DarkOrange;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1 || i == 10)
                {
                    label3.Text += "0 0 0 0 0 0 0 0 0 0\r\n";
                }
                else
                {
                    label3.Text += "0 1 1 1 1 1 1 1 1 0\r\n";
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    label3.Text += "1 0 1 0 1 0 1 0 1 0\r\n";
                }
                else
                {
                    label3.Text += "0 1 0 1 0 1 0 1 0 1\r\n";
                }
            }
        }
    }
}
