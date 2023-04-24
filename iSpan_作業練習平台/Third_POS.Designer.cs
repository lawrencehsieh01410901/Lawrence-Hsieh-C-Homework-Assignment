namespace iSpan_作業練習平台
{
    partial class Third_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Third_POS));
            this.Menu = new System.Windows.Forms.GroupBox();
            this.Wine = new System.Windows.Forms.Button();
            this.Whisky = new System.Windows.Forms.Button();
            this.Tequila = new System.Windows.Forms.Button();
            this.Beer = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditCard = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Button();
            this.ShoppingBox = new System.Windows.Forms.GroupBox();
            this.RemoveList = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.Price.SuspendLayout();
            this.Payment.SuspendLayout();
            this.ShoppingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Wine);
            this.Menu.Controls.Add(this.Whisky);
            this.Menu.Controls.Add(this.Tequila);
            this.Menu.Controls.Add(this.Beer);
            this.Menu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Location = new System.Drawing.Point(24, 53);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(299, 335);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu 菜單";
            // 
            // Wine
            // 
            this.Wine.BackColor = System.Drawing.Color.White;
            this.Wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wine.BackgroundImage")));
            this.Wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Wine.Location = new System.Drawing.Point(158, 177);
            this.Wine.Name = "Wine";
            this.Wine.Size = new System.Drawing.Size(102, 135);
            this.Wine.TabIndex = 3;
            this.Wine.Text = "紅酒 Wine NT$320";
            this.Wine.UseVisualStyleBackColor = false;
            this.Wine.Click += new System.EventHandler(this.Wine_Click);
            // 
            // Whisky
            // 
            this.Whisky.BackColor = System.Drawing.Color.White;
            this.Whisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Whisky.BackgroundImage")));
            this.Whisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Whisky.Location = new System.Drawing.Point(50, 177);
            this.Whisky.Name = "Whisky";
            this.Whisky.Size = new System.Drawing.Size(102, 135);
            this.Whisky.TabIndex = 2;
            this.Whisky.Text = "威士忌 Whisky NT$350";
            this.Whisky.UseVisualStyleBackColor = false;
            this.Whisky.Click += new System.EventHandler(this.Whisky_Click);
            // 
            // Tequila
            // 
            this.Tequila.BackgroundImage = global::iSpan_作業練習平台.Properties.Resources.Tequila;
            this.Tequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tequila.Location = new System.Drawing.Point(158, 36);
            this.Tequila.Name = "Tequila";
            this.Tequila.Size = new System.Drawing.Size(102, 135);
            this.Tequila.TabIndex = 1;
            this.Tequila.Text = "龍舌蘭 Tequila NT$180";
            this.Tequila.UseVisualStyleBackColor = true;
            this.Tequila.Click += new System.EventHandler(this.Tequila_Click);
            // 
            // Beer
            // 
            this.Beer.BackgroundImage = global::iSpan_作業練習平台.Properties.Resources.beer3;
            this.Beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beer.Location = new System.Drawing.Point(50, 36);
            this.Beer.Name = "Beer";
            this.Beer.Size = new System.Drawing.Size(102, 135);
            this.Beer.TabIndex = 0;
            this.Beer.Text = "啤酒 Beer NT$120";
            this.Beer.UseVisualStyleBackColor = true;
            this.Beer.Click += new System.EventHandler(this.Beer_Click);
            // 
            // Price
            // 
            this.Price.Controls.Add(this.textBox1);
            this.Price.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(329, 53);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(249, 135);
            this.Price.TabIndex = 1;
            this.Price.TabStop = false;
            this.Price.Text = "Price 總金額";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(22, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "NT$";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.label1);
            this.Payment.Controls.Add(this.CreditCard);
            this.Payment.Controls.Add(this.Cash);
            this.Payment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment.Location = new System.Drawing.Point(329, 194);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(249, 149);
            this.Payment.TabIndex = 2;
            this.Payment.TabStop = false;
            this.Payment.Text = "Payment 付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折";
            // 
            // CreditCard
            // 
            this.CreditCard.Location = new System.Drawing.Point(134, 49);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(106, 37);
            this.CreditCard.TabIndex = 1;
            this.CreditCard.Text = "信用卡";
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            // 
            // Cash
            // 
            this.Cash.Location = new System.Drawing.Point(22, 49);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(106, 37);
            this.Cash.TabIndex = 0;
            this.Cash.Text = "現金";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // ShoppingBox
            // 
            this.ShoppingBox.Controls.Add(this.RemoveList);
            this.ShoppingBox.Controls.Add(this.textBox2);
            this.ShoppingBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShoppingBox.Location = new System.Drawing.Point(584, 53);
            this.ShoppingBox.Name = "ShoppingBox";
            this.ShoppingBox.Size = new System.Drawing.Size(284, 342);
            this.ShoppingBox.TabIndex = 3;
            this.ShoppingBox.TabStop = false;
            this.ShoppingBox.Text = "Shopping Box 購物車";
            // 
            // RemoveList
            // 
            this.RemoveList.Location = new System.Drawing.Point(108, 282);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(126, 39);
            this.RemoveList.TabIndex = 3;
            this.RemoveList.Text = "清除清單";
            this.RemoveList.UseVisualStyleBackColor = true;
            this.RemoveList.Click += new System.EventHandler(this.RemoveList_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(272, 248);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "目前清單為空:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Third_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.ShoppingBox);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Menu);
            this.Name = "Third_POS";
            this.Text = "Third_POS";
            this.Menu.ResumeLayout(false);
            this.Price.ResumeLayout(false);
            this.Price.PerformLayout();
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            this.ShoppingBox.ResumeLayout(false);
            this.ShoppingBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Menu;
        private Button Wine;
        private Button Whisky;
        private Button Tequila;
        private Button Beer;
        private GroupBox Price;
        private GroupBox Payment;
        private GroupBox ShoppingBox;
        private TextBox textBox1;
        private Label label1;
        private Button CreditCard;
        private Button Cash;
        private TextBox textBox2;
        private Button RemoveList;
    }
}