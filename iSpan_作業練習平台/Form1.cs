namespace iSpan_作業練習平台
{
    public partial class Form1 : Form
    {
       
        public static Form1 sform1;//???
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sform1 = this;
            //Initialize First Hello into Panel2(右邊)
            //this.IsMdiContainer = true;
            //First_Hello fHello = new First_Hello();
            //fHello.MdiParent = this;
            //fHello.Parent = splitContainer1.Panel2;
            //fHello.TopLevel = false;
            //this.splitContainer1.Panel2.Controls.Add(fHello);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm1();
        }
        public void OpenForm1()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;//取得或設定值，指出表單是否為多重文件介面 (MDI) 子表單的容器。
            First_Hello fHello = new First_Hello();//建立表單物件
            fHello.MdiParent = this;//取得或設定這個表單目前的多重文件介面(MDI)父表單，this指定目前這個方法
            fHello.Parent = splitContainer2.Panel2;//取得或設定控制項的父容器 -> splitContainer2.Panel2
            fHello.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fHello);
            fHello.Show();
            //fHello.ShowDialog();//無法將非最上層表單的表單顯示為強制回應對話方塊。呼叫 showDialog 前請先將表單從任何父表單移除
            fHello.BringToFront();//丟到前面來
            //fHello.Close();//如何ShowDialog()，Close Automatically when other buttons are Clicked?
        }
        public void OpenForm2()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Second_Loan fLoan = new Second_Loan();
            fLoan.MdiParent = this;
            fLoan.Parent = splitContainer2.Panel2;
            fLoan.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fLoan);
            fLoan.Show();//如何指Show一個?

            fLoan.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm3();
        }
        public void OpenForm3()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Third_POS fPOS = new Third_POS();
            fPOS.MdiParent = this;
            fPOS.Parent = splitContainer2.Panel2;
            fPOS.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fPOS);
            fPOS.Show();//如何指Show一個?

            fPOS.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm8();
        }
        public void OpenForm8()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Seventh_Calc fCalc = new Seventh_Calc();
            fCalc.MdiParent = this;
            fCalc.Parent = splitContainer2.Panel2;
            fCalc.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fCalc);
            fCalc.Show();//如何指Show一個?

            fCalc.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm4();
        }
        public void OpenForm4()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Forth_Student fStudentStruct = new Forth_Student();
            fStudentStruct.MdiParent = this;
            fStudentStruct.Parent = splitContainer2.Panel2;
            fStudentStruct.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fStudentStruct);
            fStudentStruct.Show();//如何指Show一個?

            fStudentStruct.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm5();
        }
        public void OpenForm5()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Fifth_Student fStudentStu = new Fifth_Student();
            fStudentStu.MdiParent = this;
            fStudentStu.Parent = splitContainer2.Panel2;
            fStudentStu.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fStudentStu);
            fStudentStu.Show();//如何指Show一個?

            fStudentStu.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm6();
        }
        public void OpenForm6()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Sixth_Student fStudentGradeList = new Sixth_Student();
            fStudentGradeList.MdiParent = this;
            fStudentGradeList.Parent = splitContainer2.Panel2;
            fStudentGradeList.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fStudentGradeList);
            fStudentGradeList.Show();//如何指Show一個?

            fStudentGradeList.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm9();
        }
        public void OpenForm9()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Seventh_Method fS_Method = new Seventh_Method();
            fS_Method.MdiParent = this;
            fS_Method.Parent = splitContainer2.Panel2;
            fS_Method.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fS_Method);
            fS_Method.Show();//如何指Show一個?

            fS_Method.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm10();
        }
        public void OpenForm10()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Ninth_ForDoWhile fForDoWhile = new Ninth_ForDoWhile();
            fForDoWhile.MdiParent = this;
            fForDoWhile.Parent = splitContainer2.Panel2;
            fForDoWhile.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(fForDoWhile);
            fForDoWhile.Show();//如何指Show一個?

            fForDoWhile.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm12();
        }
        public void OpenForm12()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            twelfth_Notepad Notepad = new twelfth_Notepad();
            Notepad.MdiParent = this;
            Notepad.Parent = splitContainer2.Panel2;
            Notepad.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(Notepad);
            Notepad.Show();//如何指Show一個?

            Notepad.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm14();
        }
        public void OpenForm14()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Fourteenth_PictureViewer PictureViewer = new Fourteenth_PictureViewer();
            PictureViewer.MdiParent = this;
            PictureViewer.Parent = splitContainer2.Panel2;
            PictureViewer.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(PictureViewer);
            PictureViewer.Show();//如何指Show一個?

            PictureViewer.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm15();  
        }
        public void OpenForm15()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Fiftheenth_Guess Guess = new Fiftheenth_Guess();
            Guess.MdiParent = this;
            Guess.Parent = splitContainer2.Panel2;
            Guess.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(Guess);
            Guess.Show();//如何指Show一個?

            Guess.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm11();
        }
        public void OpenForm11()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Eleventh_ScreenSaver sc = new Eleventh_ScreenSaver();
            sc.MdiParent = this;
            sc.Parent = splitContainer2.Panel2;
            sc.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(sc);
            sc.Show();//如何指Show一個?

            sc.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm16();
        }
        public void OpenForm16()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            Sixteenth_Alarm alarm = new Sixteenth_Alarm();
            alarm.MdiParent = this;
            alarm.Parent = splitContainer2.Panel2;
            alarm.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();//如何指Show一個?

            alarm.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenFormOXGame();
        }
        public void OpenFormOXGame()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            tenth_OXGame OX = new tenth_OXGame();
            OX.MdiParent = this;
            OX.Parent = splitContainer2.Panel2;
            OX.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(OX);
            OX.Show();//如何指Show一個?

            OX.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1.sform1.OpenForm13();
        }
        public void OpenForm13()
        {
            this.splitContainer2.Panel2.Controls.Clear();//*****
            this.IsMdiContainer = true;
            thirteenth_Painter Painter = new thirteenth_Painter();
            Painter.MdiParent = this;
            Painter.Parent = splitContainer2.Panel2;
            Painter.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(Painter);
            Painter.Show();//如何指Show一個?

            Painter.BringToFront();
        }
    }
}