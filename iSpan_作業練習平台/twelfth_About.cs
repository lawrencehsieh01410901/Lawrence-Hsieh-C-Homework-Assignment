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
    public partial class twelfth_About : Form
    {
        public twelfth_About()
        {
            InitializeComponent();
            label2.Text = "此版本為謝天晟在資策會C#的NotePad++作業1.0版本，\r\n敬請安心使用";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
