namespace iSpan_作業練習平台
{
    public partial class Seventh_Calc : Form
    {
        public Seventh_Calc()
        {
            InitializeComponent();
        }
        delegate double Calc(double x, double y);//指定Delegate
        Calc calc;//建立Delegate 物件
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text); 
            calc = CalcPlus;
            textBox3.Text = Math.Round(calc(x, y), 4).ToString();
            
        }
        public double CalcPlus(double x, double y) 
        {
            return x + y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            calc = CalcMinus;
            textBox3.Text = Math.Round(calc(x, y), 4).ToString();
        }
        public double CalcMinus(double x, double y)
        {
            return x - y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            calc = CalcTimes;
            textBox3.Text = Math.Round(calc(x, y), 4).ToString();
        }
        public double CalcTimes(double x, double y)
        {
            return x * y;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            calc = CalcDivid;
            textBox3.Text = Math.Round(calc(x, y), 4).ToString();//?
        }
        public double CalcDivid(double x, double y)
        {
            return (x / y);
        }
    }
}
