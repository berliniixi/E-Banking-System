namespace SteliosPrototype
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.Password_CheckBox = new System.Windows.Forms.CheckBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Register_Picture = new System.Windows.Forms.PictureBox();
            this.Location_Picture = new System.Windows.Forms.PictureBox();
            this.ContactUs_Picture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactUs_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(-1, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.usernameLbl.Location = new System.Drawing.Point(12, 472);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(129, 27);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username ";
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameText.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameText.Location = new System.Drawing.Point(12, 502);
            this.usernameText.Name = "usernameText";
            this.usernameText.PlaceholderText = "Enter username..";
            this.usernameText.Size = new System.Drawing.Size(153, 21);
            this.usernameText.TabIndex = 3;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameTxt_TxtChange);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.passwordLbl.Location = new System.Drawing.Point(12, 553);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(117, 27);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordText.Location = new System.Drawing.Point(12, 583);
            this.passwordText.Name = "passwordText";
            this.passwordText.PlaceholderText = "Enter password.. ";
            this.passwordText.Size = new System.Drawing.Size(141, 21);
            this.passwordText.TabIndex = 5;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordTxt_changeColor);
            this.passwordText.Enter += new System.EventHandler(this.PasswordChar_CheckedChanged);
            // 
            // Password_CheckBox
            // 
            this.Password_CheckBox.AutoSize = true;
            this.Password_CheckBox.BackColor = System.Drawing.Color.White;
            this.Password_CheckBox.CausesValidation = false;
            this.Password_CheckBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_CheckBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Password_CheckBox.Location = new System.Drawing.Point(176, 582);
            this.Password_CheckBox.Name = "Password_CheckBox";
            this.Password_CheckBox.Size = new System.Drawing.Size(141, 26);
            this.Password_CheckBox.TabIndex = 6;
            this.Password_CheckBox.Text = "Show Password";
            this.Password_CheckBox.UseVisualStyleBackColor = false;
            this.Password_CheckBox.CheckedChanged += new System.EventHandler(this.PasswordChar_CheckedChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.ForeColor = System.Drawing.Color.CadetBlue;
            this.Login_Button.Location = new System.Drawing.Point(148, 654);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(169, 41);
            this.Login_Button.TabIndex = 8;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.GoToMenu_OnClick);
            // 
            // Register_Picture
            // 
            this.Register_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Register_Picture.Image")));
            this.Register_Picture.Location = new System.Drawing.Point(12, 735);
            this.Register_Picture.Name = "Register_Picture";
            this.Register_Picture.Size = new System.Drawing.Size(54, 50);
            this.Register_Picture.TabIndex = 9;
            this.Register_Picture.TabStop = false;
            this.Register_Picture.Click += new System.EventHandler(this.RegisterPicture_onClick);
            // 
            // Location_Picture
            // 
            this.Location_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Location_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Location_Picture.Image")));
            this.Location_Picture.Location = new System.Drawing.Point(397, 735);
            this.Location_Picture.Name = "Location_Picture";
            this.Location_Picture.Size = new System.Drawing.Size(49, 50);
            this.Location_Picture.TabIndex = 11;
            this.Location_Picture.TabStop = false;
            this.Location_Picture.Click += new System.EventHandler(this.ExitBtn_onClick);
            // 
            // ContactUs_Picture
            // 
            this.ContactUs_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactUs_Picture.Image = ((System.Drawing.Image)(resources.GetObject("ContactUs_Picture.Image")));
            this.ContactUs_Picture.Location = new System.Drawing.Point(209, 737);
            this.ContactUs_Picture.Name = "ContactUs_Picture";
            this.ContactUs_Picture.Size = new System.Drawing.Size(49, 48);
            this.ContactUs_Picture.TabIndex = 12;
            this.ContactUs_Picture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(20, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your No.1 Choice in E-Banking";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 797);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactUs_Picture);
            this.Controls.Add(this.Location_Picture);
            this.Controls.Add(this.Register_Picture);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_CheckBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOD-DIYs E-Banking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactUs_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label usernameLbl;
        private TextBox usernameText;
        private Label passwordLbl;
        private TextBox passwordText;
        private CheckBox Password_CheckBox;
        private Button Login_Button;
        private PictureBox Register_Picture;
        private PictureBox Location_Picture;
        private PictureBox ContactUs_Picture;
        private Label label3;
    }
}