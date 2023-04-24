namespace iSpan_作業練習平台
{
    partial class Eleventh_ScreenSaver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleventh_ScreenSaver));
            this.CatGIF = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CatGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // CatGIF
            // 
            this.CatGIF.Image = ((System.Drawing.Image)(resources.GetObject("CatGIF.Image")));
            this.CatGIF.Location = new System.Drawing.Point(43, 46);
            this.CatGIF.Name = "CatGIF";
            this.CatGIF.Size = new System.Drawing.Size(222, 279);
            this.CatGIF.TabIndex = 0;
            this.CatGIF.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Eleventh_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CatGIF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eleventh_ScreenSaver";
            this.Text = "Eleventh_ScreenSaver";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Eleventh_ScreenSaver_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eleventh_ScreenSaver_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Eleventh_ScreenSaver_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.CatGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox CatGIF;
        private System.Windows.Forms.Timer timer1;
    }
}