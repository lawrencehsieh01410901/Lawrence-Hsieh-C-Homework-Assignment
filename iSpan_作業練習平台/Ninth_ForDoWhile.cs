using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan_作業練習平台
{
    public partial class Ninth_ForDoWhile : Form
    {
        public Ninth_ForDoWhile()
        {
            InitializeComponent();
        }
        public int[] data = new int[] { -1, 1, 5, 6, 8, 7, 97, 54, 887, 65, 578, 999 };
        public string[] names = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "cindy", "Cocount", "cassidy", "Cat" };
        public int[] dataReverse = new int[] { 1, 2, 3 };
        public string[] dataReverseName = new string[] { "n1", "n2", "n3" };
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            string answer = textBox1.Text;
            if (string.IsNullOrEmpty(answer) || answer == "0")
            {
                MessageBox.Show("請輸入數字!!!");
            }
            else
            {
                if (Convert.ToInt32(answer) % 2 == 0)
                {
                    label3.Text += $"輸入的數字: {answer} 為偶數";
                }
                else
                {
                    label3.Text += $"輸入的數字: {answer} 為奇數";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int oddNumber = 0;
            int evenNumber = 0;
            for (int i = 0; i < data.Length; i++)
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
                if (i == 1 || i == 10)
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
            for (int i = 0; i < data.Length; i++)
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

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            int From = Convert.ToInt32(textBox2.Text);
            int To = Convert.ToInt32(textBox3.Text);
            int Steps = Convert.ToInt32(textBox4.Text);
            int sum = 0;

            for (int i = From; i <= To; i+= Steps) 
            {
                sum += i;
                MessageBox.Show("Current i: " + i + " Current sum: " + sum);
            }
            label3.Text += From + " 到 " + To + " 相隔 " + (Steps - 1) + "\r\n" +
                "加總為: " + sum;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            int From = Convert.ToInt32(textBox2.Text);
            int To = Convert.ToInt32(textBox3.Text);
            int Steps = Convert.ToInt32(textBox4.Text);
            int sum = 0;
            int currentNum = From;

            while (currentNum <= To) 
            {
                sum += currentNum;
                //MessageBox.Show(currentNum.ToString());
                currentNum += Steps;
            }
            label3.Text += From + " 到 " + To + " 相隔 " + (Steps - 1) + "\r\n" +
                "加總為: " + sum;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            int From = Convert.ToInt32(textBox2.Text);
            int To = Convert.ToInt32(textBox3.Text);
            int Steps = Convert.ToInt32(textBox4.Text);
            int sum = 0;
            int currentNum = From;

            do 
            {
                sum += currentNum;
                //MessageBox.Show(currentNum.ToString());
                currentNum += Steps;
            }
            while (currentNum <= To);
            label3.Text += From + " 到 " + To + " 相隔 " + (Steps - 1) + "\r\n" +
                "加總為: " + sum;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            string count = textBox5.Text;//User傳入數字

            if (string.IsNullOrEmpty( count) || count == "0") 
            {
                MessageBox.Show("請輸入正確數字");
            }
            else 
            {
                for (int i = 1; i <= Convert.ToInt32(count); i++)//迴圈執行幾次:(User傳入數字)
                {
                    for (int j = 1; j <= i; j++)//*號加幾次?(for迴圈裡同樣動作重複幾次?)
                    {
                        label3.Text += "*";
                    }
                    label3.Text += "\r\n";
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            int Num1 = 2;
            for (int j = 2; j <= 9; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    label3.Text += Num1 + " * " + i + " = " + Num1 * i + "| ";
                }
                label3.Text += "\r\n";
                Num1 += 1;
            }

        }


        private void button19_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n";
            int number = 100;
            string binary = Convert.ToString(number, 2);
            label3.Text += "Convert to Binary: " + binary;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label3.Text = "Results Here\r\n樂透號碼: [";
            Random r = new Random();
            List<int> randomList = new List<int>();
            
            for (int i = 0; i <= 6; i++) 
            {
                int MyNumber = r.Next(0, 100);
                if (!randomList.Contains(MyNumber)) 
                {
                    randomList.Add(MyNumber);
                }
            }
            for (int i = 1; i <= randomList.ToArray().Length - 1; i++)
            {
                label3.Text += " " + randomList.ToArray()[i] + " ";
            }
            label3.Text += "]";
        }
    }
}
