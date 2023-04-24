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
    public partial class Eleventh_ScreenSaver : Form
    {
        public Eleventh_ScreenSaver()
        {
            InitializeComponent();
            
        }
        int xSpeed = 4;
        int ySpeed = 4;

        private void Eleventh_ScreenSaver_Load(object sender, EventArgs e)
        {
            CatGIF.Top = 0;
            CatGIF.Left = 0;
            timer1.Start();
        }
        private void Eleventh_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Eleventh_ScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CatGIF.Left += xSpeed;
            if (CatGIF.Location.X + CatGIF.Width > this.ClientSize.Width || CatGIF.Location.X < 0)
            {
                xSpeed = -xSpeed + 400;
            }

            CatGIF.Top += ySpeed;
            if (CatGIF.Location.Y + CatGIF.Height > this.ClientSize.Height || CatGIF.Location.Y < 0)
            {
                ySpeed = -ySpeed + 400;
            }
            CatGIF.Refresh();
        }
    }
}
