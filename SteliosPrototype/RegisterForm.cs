using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteliosPrototype
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            NameTxt.ForeColor = Color.Black;
            SurnameTxt.ForeColor = Color.Black;
            BankIdTxt.ForeColor = Color.Black;
            BankIdTxt.MaxLength = 16;
            EmailTxt.ForeColor = Color.Black;
            passwordText.ForeColor = Color.Black;
            passwordText.MaxLength = 20;
        }

        private void BackBtn_onClick(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm BackBtn = new LoginForm();
            BackBtn.Show();

        }

        private void PasswordChar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Password_CheckBox.Checked)
            {
                passwordText.UseSystemPasswordChar = false;
            }
            else
            {
                passwordText.UseSystemPasswordChar = true;
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passwordText.UseSystemPasswordChar = true;
        }


        private void BankIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(BankIdTxt.Text, "[^0-9]"))
            {
                DialogResult errorMessage = MessageBox.Show("Please enter only numbers." , "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BankIdTxt.Text = BankIdTxt.Text.Remove(BankIdTxt.Text.Length - 1);
            }

        }

    }
}
