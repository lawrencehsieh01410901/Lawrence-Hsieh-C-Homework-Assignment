using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iSpan_作業練習平台
{
    public partial class Sixth_Student : Form
    {
        public Sixth_Student()
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
        int Total = 0;//宣告變數
        int Avg = 0;//宣告變數
        string minSubject = string.Empty;//宣告變數
        string maxSubject = string.Empty;//宣告變數
        int IDNumber = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)
                || (Convert.ToInt32(textBox2.Text) > 100 || Convert.ToInt32(textBox2.Text) < 0)
                || (Convert.ToInt32(textBox3.Text) > 100 || Convert.ToInt32(textBox3.Text) < 0) || (Convert.ToInt32(textBox4.Text) > 100 || Convert.ToInt32(textBox4.Text) < 0))
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

                string[] row = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue };
                var listViewItem = new ListViewItem(row);

                listView1.Items.Add(listViewItem);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
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

                string[] row = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue };
                var listViewItem = new ListViewItem(row);

                listView1.Items.Add(listViewItem);//插入Insert，從第一列插入
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            button1.Enabled = true; button2.Enabled = true;
            button3.Enabled = true; button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int chineseScore = 0;
            int englishScore = 0;
            int mathScore = 0;
            int devided_Number = listView1.Items.Count;
            int chineseAvg = 0, englishAvg = 0, mathAvg = 0;

            List<int> chineseList = new List<int>();
            List<int> englishList = new List<int>();
            List<int> mathList = new List<int>();
            for (int i = 0; i < listView1.Items.Count; i++)//資料讀取(listView1.Items)進入點
            {
                chineseScore += Convert.ToInt32(listView1.Items[i].SubItems[1].Text);//row -> column
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
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0) 
            {
                listView1.Items.Remove(listView1.Items[listView1.Items.Count - 1]);//應該是要由後往前移除(從最後一個開始移除)
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();//先清空
            int num1 = Convert.ToInt32(textBox5.Text);
            int num2 = Convert.ToInt32(textBox6.Text);
            //-->反正只是去抓取計算好後的資料，一律用string
            string names = string.Empty;
            string chineseScore = string.Empty;
            string englishScore = string.Empty;
            string mathScore = string.Empty;
            string Total = string.Empty;
            string Avg = string.Empty;
            string Min = string.Empty;
            string Max = string.Empty;
            //1. Create a new ListView
            System.Windows.Forms.ListView data = new System.Windows.Forms.ListView();
            //2. Copy listView1.Items into new ListView
            foreach (ListViewItem item in listView1.Items)
            {
                data.Items.Add((ListViewItem)item.Clone());
            }//有成功拷貝進去!

            for (int i = 0; i < data.Items.Count; i++) 
            {
                string[] arr = new string[8];//確定是8個欄位，故長度為:8
                for (int j = 0; j < data.Items[i].SubItems.Count; j++) 
                {
                    names = data.Items[i].SubItems[0].Text;
                    chineseScore = data.Items[i].SubItems[1].Text;
                    englishScore = data.Items[i].SubItems[2].Text;
                    mathScore = data.Items[i].SubItems[3].Text;
                    Total = data.Items[i].SubItems[4].Text;
                    Avg = data.Items[i].SubItems[5].Text;
                    Min = data.Items[i].SubItems[6].Text;
                    Max = data.Items[i].SubItems[7].Text;

                    if (Convert.ToInt32(chineseScore) >= num1 && Convert.ToInt32(chineseScore) <= num2)
                    {
                        arr[0] = names;
                        arr[1] = chineseScore;
                        arr[2] = englishScore;
                        arr[3] = mathScore;
                        arr[4] = Total;
                        arr[5] = Avg;
                        arr[6] = Min;
                        arr[7] = Max;
                    }
                }

                if (arr[1] != null) //中文沒有從缺的才要將其new成Items並且加入listView3中
                {
                    var listViewItem3 = new ListViewItem(arr);
                    listView3.Items.Add(listViewItem3);
                }
            }
        }
    }
}