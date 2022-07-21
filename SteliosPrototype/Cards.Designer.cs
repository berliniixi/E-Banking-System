namespace SteliosPrototype
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.AccountBtn = new System.Windows.Forms.PictureBox();
            this.CardsBtn = new System.Windows.Forms.PictureBox();
            this.TransfersBtn = new System.Windows.Forms.PictureBox();
            this.ShowMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ShowAccount = new System.Windows.Forms.ToolTip(this.components);
            this.ShowCards = new System.Windows.Forms.ToolTip(this.components);
            this.ShowTransfers = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(28, 718);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(50, 52);
            this.HomeBtn.TabIndex = 21;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.GoToHome_onClick);
            this.HomeBtn.MouseEnter += new System.EventHandler(this.showHome_onMouseEnter);
            // 
            // AccountBtn
            // 
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccountBtn.Image")));
            this.AccountBtn.Location = new System.Drawing.Point(141, 718);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(47, 52);
            this.AccountBtn.TabIndex = 22;
            this.AccountBtn.TabStop = false;
            this.AccountBtn.Click += new System.EventHandler(this.GoToAcounts_onClick);
            this.AccountBtn.MouseEnter += new System.EventHandler(this.showAccount_onMouseEnter);
            // 
            // CardsBtn
            // 
            this.CardsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardsBtn.Image = ((System.Drawing.Image)(resources.GetObject("CardsBtn.Image")));
            this.CardsBtn.Location = new System.Drawing.Point(273, 721);
            this.CardsBtn.Name = "CardsBtn";
            this.CardsBtn.Size = new System.Drawing.Size(49, 49);
            this.CardsBtn.TabIndex = 23;
            this.CardsBtn.TabStop = false;
            this.CardsBtn.Click += new System.EventHandler(this.GoToCards_onClick);
            this.CardsBtn.MouseEnter += new System.EventHandler(this.showCards_onMouseEnter);
            // 
            // TransfersBtn
            // 
            this.TransfersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransfersBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransfersBtn.Image")));
            this.TransfersBtn.Location = new System.Drawing.Point(372, 721);
            this.TransfersBtn.Name = "TransfersBtn";
            this.TransfersBtn.Size = new System.Drawing.Size(47, 49);
            this.TransfersBtn.TabIndex = 24;
            this.TransfersBtn.TabStop = false;
            this.TransfersBtn.MouseEnter += new System.EventHandler(this.showTransfers_onMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cards";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 222);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(2, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 94);
            this.panel2.TabIndex = 30;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.CadetBlue;
            this.label8.Location = new System.Drawing.Point(19, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "CARD MANEGEMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(2, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 185);
            this.panel1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(86, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "Freeze Card";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "View PIN";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 46);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "My Cards";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(273, 775);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 10);
            this.panel7.TabIndex = 32;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 797);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransfersBtn);
            this.Controls.Add(this.CardsBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.HomeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cards";
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox HomeBtn;
        private PictureBox AccountBtn;
        private PictureBox CardsBtn;
        private PictureBox TransfersBtn;
        private ToolTip ShowMenu;
        private ToolTip toolTip1;
        private ToolTip ShowAccount;
        private ToolTip ShowCards;
        private ToolTip ShowTransfers;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox infoBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label10;
        private Panel panel7;
    }
}