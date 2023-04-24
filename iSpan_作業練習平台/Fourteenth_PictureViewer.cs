using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iSpan_作業練習平台
{
    public partial class Fourteenth_PictureViewer : Form //Partial???
    {
        public Fourteenth_PictureViewer()
        {
            InitializeComponent();
            //Load_Pic();
        }
       
        private void Fourteenth_PictureViewer_Load(object sender, EventArgs e)
        {
            Load_Pic();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        void Load_Pic()
        {
            string[] fileEntries = Directory.GetFiles(@"C:\Users\User\Desktop\iSpan C#\作業\iSpan_作業練習平台\Picture Viewer");
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            foreach (string files in fileEntries)
            {
                //MessageBox.Show(files.ToString());
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files);
                pic.Location = new Point(x, y);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                x += pic.Width + 10;
                maxHeight = Math.Max(pic.Height, maxHeight);
                if (x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHeight + 10;
                }
                this.panelImages.Controls.Add(pic);
            }
        }
    }
}
