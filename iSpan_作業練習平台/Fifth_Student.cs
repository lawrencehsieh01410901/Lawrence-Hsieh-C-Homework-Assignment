using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iSpan_作業練習平台
{
    public partial class Fifth_Student : Form
    {
        int Total = 0;//宣告變數
        int Avg = 0;//宣告變數
        string minSubject = string.Empty;//宣告變數
        string maxSubject = string.Empty;//宣告變數
        int IDNumber = 1;

        public Fifth_Student()
        {
            InitializeComponent();
            ValueInit();
        }
        public void ValueInit() 
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
           Random rand = new Random();
           int randomChinese = rand.Next(0, 100);
           int randomEnglish = rand.Next(0, 100);
           int randomMath = rand.Next(0, 100);
           int randomTotal = (randomChinese + randomEnglish + randomMath);
           int randomAvg = randomTotal / 3;
           Dictionary<string, int> randomdict = new Dictionary<string, int>() {
               {"國文", randomChinese}, {"英文", randomEnglish}, {"數學", randomMath}
           };
           //------>Max
           var maxValueKey = randomdict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
           var maxValue = randomdict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
           //------>Max
           //------>Min
           var minValueKey = randomdict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
           var minValue = randomdict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
           //-->
           string[] randomrow = { IDNumber.ToString(), randomChinese.ToString(), randomEnglish.ToString(), randomMath.ToString(),
                   randomTotal.ToString(), randomAvg.ToString(), minValueKey + minValue, maxValueKey + maxValue };
           var listViewItem = new ListViewItem(randomrow);

           listView1.Items.Add(listViewItem);
           IDNumber += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)
                || (Convert.ToInt32(textBox2.Text) > 100 || Convert.ToInt32(textBox2.Text) < 0)
                || (Convert.ToInt32(textBox3.Text) > 100 || Convert.ToInt32(textBox3.Text) < 0) 
                || (Convert.ToInt32(textBox4.Text) > 100 || Convert.ToInt32(textBox4.Text) < 0))
            {
                MessageBox.Show("請輸入正確資料!!!");
            }
            else 
            {
                Total = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));//宣告變數+計算
                Avg = Total / 3;//宣告變數+計算
                Dictionary<string, int> dict = new Dictionary<string, int>() {
                {"國文", Convert.ToInt32(textBox2.Text)}, {"英文", Convert.ToInt32(textBox3.Text)}, {"數學", Convert.ToInt32(textBox4.Text)}
            };
                //------>Max
                var maxValueKey = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                var maxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
                //------>Max
                //------>Min
                var minValueKey = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                var minValue = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
                //------>Min

                string[] row = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue };

                //List<string> listRow = new List<string>() {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                //    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue };
                //會造成如果輸入直都是0，listView1.Items會顯示都是System...list而不是0, 0, 0, 0, 0, 0, 0, 0;
                var listViewItem = new ListViewItem(row);//List為何listRowToString()就可以放入ListViewItem()之內???

                listView1.Items.Add(listViewItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++) //因為你的編號: IDNumber是從0開始，故<20;
            {
                Random rand = new Random();
                int randomChinese = rand.Next(0, 100);
                int randomEnglish = rand.Next(0, 100);
                int randomMath = rand.Next(0, 100);
                int randomTotal = (randomChinese + randomEnglish + randomMath);
                int randomAvg = randomTotal / 3;
                Dictionary<string, int> randomdict = new Dictionary<string, int>() 
                    {
                    {"國文", randomChinese}, {"英文", randomEnglish}, {"數學", randomMath}
                     };
                //------>Max
                var maxValueKey = randomdict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                var maxValue = randomdict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
                //------>Max
                //------>Min
                var minValueKey = randomdict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                var minValue = randomdict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
                //-->
                string[] randomrow = { IDNumber.ToString(), 
                    randomChinese.ToString(), randomEnglish.ToString(), randomMath.ToString(),
                    randomTotal.ToString(), randomAvg.ToString(), minValueKey + minValue, maxValueKey + maxValue };
                var listViewItem = new ListViewItem(randomrow);

                listView1.Items.Add(listViewItem);
                IDNumber += 1;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int chineseScore = 0;
            int englishScore = 0;
            int mathScore = 0;
            int devided_Number = listView1.Items.Count;
            int chineseAvg = 0, englishAvg = 0, mathAvg = 0;

            List<int> chineseList = new List<int>();
            List<int> englishList = new List<int>();
            List<int> mathList = new List<int>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                chineseScore += Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
                englishScore += Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                mathScore += Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                chineseList.Add(chineseScore);
                englishList.Add(englishScore);
                mathList.Add(mathScore);
            }
            chineseAvg = chineseScore / devided_Number;
            englishAvg = englishScore / devided_Number;
            mathAvg = mathScore / devided_Number;

            var chineseMaxScore = chineseList.Max();//-->國文最高分
            var chineseMinScore = chineseList.Min();//-->國文最低分
            var englishMaxScore = englishList.Max();//-->英文最高分
            var englishMinScore = englishList.Min();//-->英文最低分
            var mathMaxScore = mathList.Max();//-->數學最高分
            var mathMinScore = mathList.Min();//-->數學最低分

            string[] row1 = { "總分:", chineseScore.ToString(), englishScore.ToString(), mathScore.ToString() };
            string[] row2 = { "平均", chineseAvg.ToString(), englishAvg.ToString(), mathAvg.ToString() };
            string[] row3 = { "最高分", chineseMaxScore.ToString(), englishMaxScore.ToString(), mathMaxScore.ToString() };
            string[] row4 = { "最低分", chineseMinScore.ToString(), englishMinScore.ToString(), mathMinScore.ToString() };
            var listViewItem1 = new ListViewItem(row1);
            var listViewItem2 = new ListViewItem(row2);
            var listViewItem3 = new ListViewItem(row3);
            var listViewItem4 = new ListViewItem(row4);
            listView2.Items.Add(listViewItem1);
            listView2.Items.Add(listViewItem2);
            listView2.Items.Add(listViewItem3);
            listView2.Items.Add(listViewItem4);

            //-->All button1 ~ 4 disable
            button1.Enabled= false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            //for (int i = 0; i < listView2.Items.Count; i++) 
            //{
            //    MessageBox.Show("This is ListView, Items: " + listView2.Items[i]);
            //    for (int j = 0; j < listView2.Items[i].SubItems.Count; j++) 
            //    {
            //        MessageBox.Show("This is ListView, SubItems: " + listView2.Items[i].SubItems[j].Text);
            //    }
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            IDNumber = 1;//讓所有隨機資料從編號從頭開始
        }

        private void Fifth_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
