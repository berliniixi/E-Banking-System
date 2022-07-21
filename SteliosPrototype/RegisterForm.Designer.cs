namespace SteliosPrototype
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.RegistrationLbl = new System.Windows.Forms.Label();
            this.BirthdayLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.BankIDLbl = new System.Windows.Forms.Label();
            this.BankIdTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.MaxCharacterLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Password_CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 727);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BackBtn_onClick);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.NameLbl.Location = new System.Drawing.Point(18, 130);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(82, 27);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name ";
            // 
            // NameTxt
            // 
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTxt.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.NameTxt.Location = new System.Drawing.Point(166, 133);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PlaceholderText = "Enter your name..";
            this.NameTxt.Size = new System.Drawing.Size(127, 21);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.TextChanged += new System.EventHandler(this.ChangeColor);
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.SurnameLbl.Location = new System.Drawing.Point(18, 178);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(117, 27);
            this.SurnameLbl.TabIndex = 4;
            this.SurnameLbl.Text = "Surname ";
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTxt.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SurnameTxt.Location = new System.Drawing.Point(163, 178);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.PlaceholderText = "Enter surname..";
            this.SurnameTxt.Size = new System.Drawing.Size(130, 21);
            this.SurnameTxt.TabIndex = 5;
            this.SurnameTxt.TextChanged += new System.EventHandler(this.ChangeColor);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.GenderLbl.Location = new System.Drawing.Point(18, 279);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(100, 27);
            this.GenderLbl.TabIndex = 6;
            this.GenderLbl.Text = "Gender ";
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaleRadioBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.MaleRadioBtn.Location = new System.Drawing.Point(163, 279);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(67, 26);
            this.MaleRadioBtn.TabIndex = 8;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FemaleRadioBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(248, 279);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(99, 25);
            this.FemaleRadioBtn.TabIndex = 9;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female ";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrationLbl
            // 
            this.RegistrationLbl.AutoSize = true;
            this.RegistrationLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrationLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.RegistrationLbl.Location = new System.Drawing.Point(141, 32);
            this.RegistrationLbl.Name = "RegistrationLbl";
            this.RegistrationLbl.Size = new System.Drawing.Size(161, 43);
            this.RegistrationLbl.TabIndex = 10;
            this.RegistrationLbl.Text = "Register";
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.AutoSize = true;
            this.BirthdayLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthdayLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.BirthdayLbl.Location = new System.Drawing.Point(18, 330);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(101, 27);
            this.BirthdayLbl.TabIndex = 11;
            this.BirthdayLbl.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 28);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.EmailLbl.Location = new System.Drawing.Point(18, 378);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(165, 27);
            this.EmailLbl.TabIndex = 13;
            this.EmailLbl.Text = "Email address";
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTxt.Location = new System.Drawing.Point(219, 379);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PlaceholderText = "name@example.com ";
            this.EmailTxt.Size = new System.Drawing.Size(192, 24);
            this.EmailTxt.TabIndex = 14;
            // 
            // BankIDLbl
            // 
            this.BankIDLbl.AutoSize = true;
            this.BankIDLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankIDLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.BankIDLbl.Location = new System.Drawing.Point(18, 226);
            this.BankIDLbl.Name = "BankIDLbl";
            this.BankIDLbl.Size = new System.Drawing.Size(97, 27);
            this.BankIDLbl.TabIndex = 15;
            this.BankIDLbl.Text = "Bank ID";
            // 
            // BankIdTxt
            // 
            this.BankIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankIdTxt.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankIdTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.BankIdTxt.Location = new System.Drawing.Point(166, 225);
            this.BankIdTxt.Name = "BankIdTxt";
            this.BankIdTxt.PlaceholderText = "Enter Bank id..";
            this.BankIdTxt.Size = new System.Drawing.Size(152, 21);
            this.BankIdTxt.TabIndex = 16;
            this.BankIdTxt.TextChanged += new System.EventHandler(this.BankIdTxt_TextChanged);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.PasswordLbl.Location = new System.Drawing.Point(18, 487);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(124, 27);
            this.PasswordLbl.TabIndex = 17;
            this.PasswordLbl.Text = "Password ";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordText.Location = new System.Drawing.Point(166, 490);
            this.passwordText.Name = "passwordText";
            this.passwordText.PlaceholderText = "Enter password..";
            this.passwordText.Size = new System.Drawing.Size(189, 21);
            this.passwordText.TabIndex = 18;
            this.passwordText.TextChanged += new System.EventHandler(this.ChangeColor);
            this.passwordText.Enter += new System.EventHandler(this.PasswordChar_CheckedChanged);
            // 
            // MaxCharacterLbl
            // 
            this.MaxCharacterLbl.AutoSize = true;
            this.MaxCharacterLbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxCharacterLbl.Location = new System.Drawing.Point(313, 530);
            this.MaxCharacterLbl.Name = "MaxCharacterLbl";
            this.MaxCharacterLbl.Size = new System.Drawing.Size(133, 22);
            this.MaxCharacterLbl.TabIndex = 19;
            this.MaxCharacterLbl.Text = "Max Character : 20";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.CountryLbl.Location = new System.Drawing.Point(18, 435);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(104, 27);
            this.CountryLbl.TabIndex = 21;
            this.CountryLbl.Text = "Country ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Russia",
            "Germany",
            "United Kingdom\t",
            "France",
            "Italy",
            "Spain",
            "Ukraine",
            "Poland",
            "Romania",
            "Netherlands",
            "Belgium",
            "Greece",
            "Cyprus"});
            this.comboBox1.Location = new System.Drawing.Point(166, 429);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 33);
            this.comboBox1.TabIndex = 22;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit_Button.ForeColor = System.Drawing.Color.CadetBlue;
            this.Submit_Button.Location = new System.Drawing.Point(141, 617);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(169, 41);
            this.Submit_Button.TabIndex = 23;
            this.Submit_Button.Text = "Submit ";
            this.Submit_Button.UseVisualStyleBackColor = true;
            // 
            // Password_CheckBox
            // 
            this.Password_CheckBox.AutoSize = true;
            this.Password_CheckBox.BackColor = System.Drawing.Color.White;
            this.Password_CheckBox.CausesValidation = false;
            this.Password_CheckBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_CheckBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Password_CheckBox.Location = new System.Drawing.Point(163, 530);
            this.Password_CheckBox.Name = "Password_CheckBox";
            this.Password_CheckBox.Size = new System.Drawing.Size(141, 26);
            this.Password_CheckBox.TabIndex = 24;
            this.Password_CheckBox.Text = "Show Password";
            this.Password_CheckBox.UseVisualStyleBackColor = false;
            this.Password_CheckBox.CheckedChanged += new System.EventHandler(this.PasswordChar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Max Character : 16";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 797);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_CheckBox);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.MaxCharacterLbl);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.BankIdTxt);
            this.Controls.Add(this.BankIDLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BirthdayLbl);
            this.Controls.Add(this.RegistrationLbl);
            this.Controls.Add(this.FemaleRadioBtn);
            this.Controls.Add(this.MaleRadioBtn);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label NameLbl;
        private TextBox NameTxt;
        private Label SurnameLbl;
        private TextBox SurnameTxt;
        private Label GenderLbl;
        private RadioButton MaleRadioBtn;
        private RadioButton FemaleRadioBtn;
        private Label RegistrationLbl;
        private Label BirthdayLbl;
        private DateTimePicker dateTimePicker1;
        private Label EmailLbl;
        private TextBox EmailTxt;
        private Label BankIDLbl;
        private TextBox BankIdTxt;
        private Label PasswordLbl;
        private TextBox passwordText;
        private Label MaxCharacterLbl;
        private Label CountryLbl;
        private ComboBox comboBox1;
        private Button Submit_Button;
        private CheckBox Password_CheckBox;
        private Label label1;
    }
}