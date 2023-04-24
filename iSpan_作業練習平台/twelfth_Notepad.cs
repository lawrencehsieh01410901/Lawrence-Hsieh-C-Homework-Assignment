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
    public partial class twelfth_Notepad : Form
    {
        public static twelfth_Notepad sform1;//???
        public twelfth_Notepad()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Title = "Save";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Title = "Save";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Title = "Save";
            openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cancelUndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selfEditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fontDialog = new ColorDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text.ToLower();
        }

        private void nextLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\r\n";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            twelfth_Notepad.sform1.OpenAbout();
        }
        public void OpenAbout()
        {
            //this.splitContainer2.Panel2.Controls.Clear();//*****
            //this.IsMdiContainer = true;
            twelfth_About about = new twelfth_About();
            //about.MdiParent = this;
            //fLoan.Parent = splitContainer2.Panel2;
            //fLoan.TopLevel = false;
            //this.splitContainer2.Panel2.Controls.Add(fLoan);
            about.Show();//如何指Show一個?

            about.BringToFront();
        }

        private void twelfth_Notepad_Load(object sender, EventArgs e)
        {
            sform1 = this;
        }
    }
}
