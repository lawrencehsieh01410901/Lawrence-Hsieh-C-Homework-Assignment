using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace iSpan_作業練習平台
{
    public partial class Sixteenth_Alarm : Form
    {
        System.Timers.Timer timer;
        SoundPlayer player = new SoundPlayer();
        public Sixteenth_Alarm()
        {
            InitializeComponent();
        }

        private void Sixteenth_Alarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            DateTime currentTime =  DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour &&
                currentTime.Minute == userTime.Minute &&
                currentTime.Second == userTime.Second) 
            {
                timer.Stop();
                try 
                {
                    
                    player.SoundLocation = @"C:\Users\User\Desktop\iSpan C#\作業\iSpan_作業練習平台\Alarm\preview.wav";
                    player.PlayLooping();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, " Message: ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            label1.Text = "Running...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "Stop...";
            player.Stop();
        }
    }
}
