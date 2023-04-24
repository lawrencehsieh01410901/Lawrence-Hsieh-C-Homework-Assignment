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
    public partial class First_Hello : Form
    {
        public First_Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = "Hello, 我叫: ";
            string userName, englishName, Gender, star;
            userName = textBox1.Text;
            englishName = textBox2.Text;
            Gender = textBox3.Text;
            star = textBox4.Text;

            MessageBox.Show(words + userName + "\r\n" +
                "英文名字: " + englishName + "\r\n" +
                "性別: " + Gender + "\r\n" +
                "星座: " + star + "#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string words = "Hi, 我叫: ";
            string userName, englishName, Gender, star;
            userName = textBox1.Text;
            englishName = textBox2.Text;
            Gender = textBox3.Text;
            star = textBox4.Text;

            MessageBox.Show(words + userName + "\r\n" +
                "英文名字: " + englishName + "\r\n" +
                "性別: " + Gender + "\r\n" +
                "星座: " + star + "#");
        }
    }
}
