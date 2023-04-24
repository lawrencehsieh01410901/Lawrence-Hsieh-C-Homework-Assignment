using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan_作業練習平台
{
    public partial class Fiftheenth_Guess : Form
    {
        public int rndNumber;
        public int FirstNumber = 1;
        public int SecondNumber = 100;
        public Fiftheenth_Guess()
        {
            InitializeComponent();
            rndNumber = RandomNumber();//直接在一開始就初始化
        }
        public int RandomNumber() 
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
        /*A field initializer cannot reference the non-static field, method, or property 'name'.
          Instance fields cannot be used to initialize other instance fields outside a method.*/

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rndNumber.ToString());
            do 
            {
                string UserInput = Interaction.InputBox("Please Enter Number: ");
                if (string.IsNullOrEmpty(UserInput))
                {
                    break;
                }
                else if (Convert.ToInt32(UserInput) > 100 || Convert.ToInt32(UserInput) <= 0) 
                {
                    MessageBox.Show("Number Must between 1 ~ 100", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int UserNumber = Convert.ToInt32(UserInput);
                    if (UserNumber < rndNumber)
                    {
                        FirstNumber = UserNumber;
                        label2.Text = string.Format("Too Small, Number is Between: {0} and {1}", FirstNumber, SecondNumber);
                    }
                    else if (UserNumber > rndNumber)
                    {
                        SecondNumber = UserNumber;
                        label2.Text = string.Format("Too Large, Number is Between: {0} and {1}", FirstNumber, SecondNumber);
                    }
                    else if (UserNumber == rndNumber)
                    {
                        MessageBox.Show(string.Format("You Guessed it, answer is: {0}", rndNumber));
                        break;
                    }
                }
            }
            while (true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Number is: {0}", rndNumber));
            rndNumber = RandomNumber();//新賦予隨機數字
        }
    }
}
