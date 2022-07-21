namespace SteliosPrototype
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.piggyBank = new System.Windows.Forms.PictureBox();
            this.CurrentTransactions = new System.Windows.Forms.PictureBox();
            this.ShowAllTransactions = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.AccountBtn = new System.Windows.Forms.PictureBox();
            this.CardsBtn = new System.Windows.Forms.PictureBox();
            this.TransfersBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowMenu = new System.Windows.Forms.ToolTip(this.components);
            this.ShowAccount = new System.Windows.Forms.ToolTip(this.components);
            this.ShowCards = new System.Windows.Forms.ToolTip(this.components);
            this.ShowTransfers = new System.Windows.Forms.ToolTip(this.components);
            this.showAll = new System.Windows.Forms.ToolTip(this.components);
            this.CurrentTrasactions = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.walletPicture = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.piggyPicture = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piggyBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletPicture)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piggyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.piggyBank);
            this.panel1.Controls.Add(this.CurrentTransactions);
            this.panel1.Controls.Add(this.ShowAllTransactions);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 90);
            this.panel1.TabIndex = 0;
            // 
            // piggyBank
            // 
            this.piggyBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piggyBank.Image = ((System.Drawing.Image)(resources.GetObject("piggyBank.Image")));
            this.piggyBank.Location = new System.Drawing.Point(351, 9);
            this.piggyBank.Name = "piggyBank";
            this.piggyBank.Size = new System.Drawing.Size(47, 50);
            this.piggyBank.TabIndex = 24;
            this.piggyBank.TabStop = false;
            this.piggyBank.Click += new System.EventHandler(this.SelectPiggyBank_onClick);
            this.piggyBank.MouseEnter += new System.EventHandler(this.showAllSaving_onMouseEnter);
            // 
            // CurrentTransactions
            // 
            this.CurrentTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentTransactions.Image = ((System.Drawing.Image)(resources.GetObject("CurrentTransactions.Image")));
            this.CurrentTransactions.Location = new System.Drawing.Point(197, 11);
            this.CurrentTransactions.Name = "CurrentTransactions";
            this.CurrentTransactions.Size = new System.Drawing.Size(50, 50);
            this.CurrentTransactions.TabIndex = 1;
            this.CurrentTransactions.TabStop = false;
            this.CurrentTransactions.Click += new System.EventHandler(this.SelectCurrenttransactions_onClick);
            this.CurrentTransactions.MouseEnter += new System.EventHandler(this.showCurrentTransactions);
            // 
            // ShowAllTransactions
            // 
            this.ShowAllTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAllTransactions.Image = ((System.Drawing.Image)(resources.GetObject("ShowAllTransactions.Image")));
            this.ShowAllTransactions.Location = new System.Drawing.Point(50, 11);
            this.ShowAllTransactions.Name = "ShowAllTransactions";
            this.ShowAllTransactions.Size = new System.Drawing.Size(47, 48);
            this.ShowAllTransactions.TabIndex = 0;
            this.ShowAllTransactions.TabStop = false;
            this.ShowAllTransactions.Click += new System.EventHandler(this.SelectShowAllTransactions_onClick);
            this.ShowAllTransactions.MouseEnter += new System.EventHandler(this.ShowAll_onMouseEnter);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(351, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 10);
            this.panel5.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(197, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 10);
            this.panel4.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(50, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 10);
            this.panel3.TabIndex = 25;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(28, 718);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(50, 52);
            this.HomeBtn.TabIndex = 20;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.GoToHome_onClick);
            this.HomeBtn.MouseEnter += new System.EventHandler(this.showHome_onMouseEnter);
            // 
            // AccountBtn
            // 
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccountBtn.Image")));
            this.AccountBtn.Location = new System.Drawing.Point(146, 715);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(47, 52);
            this.AccountBtn.TabIndex = 21;
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
            this.CardsBtn.TabIndex = 22;
            this.CardsBtn.TabStop = false;
            this.CardsBtn.Click += new System.EventHandler(this.GoToCards_onClick);
            this.CardsBtn.MouseEnter += new System.EventHandler(this.showCards_onMouseEnter);
            // 
            // TransfersBtn
            // 
            this.TransfersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransfersBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransfersBtn.Image")));
            this.TransfersBtn.Location = new System.Drawing.Point(377, 715);
            this.TransfersBtn.Name = "TransfersBtn";
            this.TransfersBtn.Size = new System.Drawing.Size(47, 49);
            this.TransfersBtn.TabIndex = 23;
            this.TransfersBtn.TabStop = false;
            this.TransfersBtn.MouseEnter += new System.EventHandler(this.showTransfers_onMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.infoBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 94);
            this.panel2.TabIndex = 24;
            // 
            // infoBtn
            // 
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
            this.infoBtn.Location = new System.Drawing.Point(412, 30);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(32, 33);
            this.infoBtn.TabIndex = 5;
            this.infoBtn.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "€100.87";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "€100.87";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "*6969/TALIADOROS STELIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(59, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "All";
            // 
            // walletPicture
            // 
            this.walletPicture.Image = ((System.Drawing.Image)(resources.GetObject("walletPicture.Image")));
            this.walletPicture.Location = new System.Drawing.Point(15, 233);
            this.walletPicture.Name = "walletPicture";
            this.walletPicture.Size = new System.Drawing.Size(34, 34);
            this.walletPicture.TabIndex = 25;
            this.walletPicture.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CadetBlue;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(2, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(453, 94);
            this.panel6.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(412, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Available";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "€120.87";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "120.87";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(17, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "*6969/TALIADOROS STELIOS";
            // 
            // cardPicture
            // 
            this.cardPicture.Image = ((System.Drawing.Image)(resources.GetObject("cardPicture.Image")));
            this.cardPicture.Location = new System.Drawing.Point(19, 240);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(27, 27);
            this.cardPicture.TabIndex = 26;
            this.cardPicture.TabStop = false;
            // 
            // piggyPicture
            // 
            this.piggyPicture.Image = ((System.Drawing.Image)(resources.GetObject("piggyPicture.Image")));
            this.piggyPicture.Location = new System.Drawing.Point(14, 233);
            this.piggyPicture.Name = "piggyPicture";
            this.piggyPicture.Size = new System.Drawing.Size(32, 32);
            this.piggyPicture.TabIndex = 27;
            this.piggyPicture.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(146, 775);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 10);
            this.panel7.TabIndex = 28;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 797);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.piggyPicture);
            this.Controls.Add(this.cardPicture);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.walletPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransfersBtn);
            this.Controls.Add(this.CardsBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piggyBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAllTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletPicture)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piggyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox HomeBtn;
        private PictureBox AccountBtn;
        private PictureBox CardsBtn;
        private PictureBox TransfersBtn;
        private Label label1;
        private ToolTip ShowMenu;
        private ToolTip ShowAccount;
        private ToolTip ShowCards;
        private ToolTip ShowTransfers;
        private PictureBox ShowAllTransactions;
        private ToolTip showAll;
        private PictureBox CurrentTransactions;
        private ToolTip CurrentTrasactions;
        private PictureBox piggyBank;
        private Panel panel2;
        private Label label2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox walletPicture;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox infoBtn;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox cardPicture;
        private PictureBox piggyPicture;
        private Panel panel7;
    }
}