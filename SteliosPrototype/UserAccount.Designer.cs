namespace SteliosPrototype
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CurrentAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountBtn = new System.Windows.Forms.PictureBox();
            this.CardsBtn = new System.Windows.Forms.PictureBox();
            this.TransfersBtn = new System.Windows.Forms.PictureBox();
            this.ShowMenu = new System.Windows.Forms.ToolTip(this.components);
            this.ShowAccount = new System.Windows.Forms.ToolTip(this.components);
            this.ShowCards = new System.Windows.Forms.ToolTip(this.components);
            this.ShowTransfers = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.LogOut_onClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 111);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CurrentAmount
            // 
            this.CurrentAmount.AutoSize = true;
            this.CurrentAmount.BackColor = System.Drawing.Color.CadetBlue;
            this.CurrentAmount.Location = new System.Drawing.Point(165, 138);
            this.CurrentAmount.Name = "CurrentAmount";
            this.CurrentAmount.Size = new System.Drawing.Size(140, 25);
            this.CurrentAmount.TabIndex = 5;
            this.CurrentAmount.Text = "Current Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(201, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "€96,63";
            // 
            // AccountBtn
            // 
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccountBtn.Image")));
            this.AccountBtn.Location = new System.Drawing.Point(146, 715);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(47, 52);
            this.AccountBtn.TabIndex = 8;
            this.AccountBtn.TabStop = false;
            this.AccountBtn.Click += new System.EventHandler(this.GoToAcounts_onClick);
            this.AccountBtn.MouseEnter += new System.EventHandler(this.showAccount_onMouseEnter);
            // 
            // CardsBtn
            // 
            this.CardsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardsBtn.Image = ((System.Drawing.Image)(resources.GetObject("CardsBtn.Image")));
            this.CardsBtn.Location = new System.Drawing.Point(273, 715);
            this.CardsBtn.Name = "CardsBtn";
            this.CardsBtn.Size = new System.Drawing.Size(49, 49);
            this.CardsBtn.TabIndex = 9;
            this.CardsBtn.TabStop = false;
            this.CardsBtn.Click += new System.EventHandler(this.GoToCards_onClick);
            this.CardsBtn.MouseEnter += new System.EventHandler(this.showCards_onMouseEnter);
            // 
            // TransfersBtn
            // 
            this.TransfersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransfersBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransfersBtn.Image")));
            this.TransfersBtn.Location = new System.Drawing.Point(376, 715);
            this.TransfersBtn.Name = "TransfersBtn";
            this.TransfersBtn.Size = new System.Drawing.Size(47, 49);
            this.TransfersBtn.TabIndex = 10;
            this.TransfersBtn.TabStop = false;
            this.TransfersBtn.MouseEnter += new System.EventHandler(this.showTransfers_onMouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(434, 234);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(117, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Have";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(201, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Owe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(284, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(61, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Net Worth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "€100,23";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "€0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "€96,63";
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(28, 718);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(50, 52);
            this.HomeBtn.TabIndex = 19;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.GoToHome_onClikc);
            this.HomeBtn.MouseEnter += new System.EventHandler(this.showHome_onMouseEnter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(28, 775);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 10);
            this.panel3.TabIndex = 26;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 797);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TransfersBtn);
            this.Controls.Add(this.CardsBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentAmount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label CurrentAmount;
        private Label label2;
        private PictureBox AccountBtn;
        private PictureBox CardsBtn;
        private PictureBox TransfersBtn;
        private ToolTip ShowMenu;
        private ToolTip ShowAccount;
        private ToolTip ShowCards;
        private ToolTip ShowTransfers;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox HomeBtn;
        private Panel panel3;
    }
}