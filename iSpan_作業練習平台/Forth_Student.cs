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
    public partial class Forth_Student : Form
    {
        public Forth_Student()
        {
            InitializeComponent();
        }

        public struct StudentData 
        {
            public string Name;
            public int ChineseScore;
            public int EnglishScore;
            public int MathScore;
        }
        StudentData sd;//建立Struct
        private void Forth_Student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sd.Name = textBox1.Text;
            sd.ChineseScore = Convert.ToInt32(textBox2.Text);
            sd.EnglishScore = Convert.ToInt32(textBox3.Text);
            sd.MathScore = Convert.ToInt32(textBox4.Text);
            MessageBox.Show("除存成功!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "姓名: " + sd.Name + "\r\n" +
                "國文: " + sd.ChineseScore + "\r\n" +
                "英文: " + sd.EnglishScore + "\r\n" +
                "數學: " + sd.MathScore + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>() {
                {"國文", sd.ChineseScore}, {"英文", sd.EnglishScore}, {"數學", sd.MathScore}
            };
            //------>Max
            var maxValueKey = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            var maxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
            //------>Max
            //------>Min
            var minValueKey = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
  
            var minValue = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
            //------>Min
            textBox6.Text = "最高科目成績為: " + maxValueKey + maxValue + "分\r\n" +
                "最低科目成績為: " + minValueKey + minValue + "分\r\n";
            /*
            var maxScore = dict.MaxBy(kvp => kvp.Value);
            var minScore = dict.MinBy(kvp => kvp.Value);

            var subjectMax = maxScore.Key;
            var scoreMax = maxScore.Value;

            var subjectMin = minScore.Key;
            var scoreMin = minScore.Value;

            textBox6.Text = "最高科目成績為: " + subjectMax + scoreMax + "分\r\n" +
                 "最低科目成績為: " + subjectMin + scoreMin + "分\r\n";
             */
        }
    }
}
