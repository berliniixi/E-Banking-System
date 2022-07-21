namespace SteliosPrototype
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameTxt_TxtChange(object sender, EventArgs e)
        {
            usernameText.ForeColor = Color.Black;
        }

        private void passwordTxt_changeColor(object sender, EventArgs e)
        {
            passwordText.ForeColor = Color.Black;
            passwordText.MaxLength = 20;
        }

        private void PasswordChar_CheckedChanged(object sender, EventArgs e)
        {
            if (Password_CheckBox.Checked)
            {
                passwordText.UseSystemPasswordChar = false;
            }
            else
            {
                passwordText.UseSystemPasswordChar= true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            passwordText.UseSystemPasswordChar = true;
        }

        private void RegisterPicture_onClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

        }

        private void ExitBtn_onClick(object sender, EventArgs e)
        {
            DialogResult exitQuestion = MessageBox.Show("Do you want to Exit ?", "Exit", MessageBoxButtons.YesNo , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (exitQuestion == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (exitQuestion == DialogResult.No)
            {
                base.OnClosed(e);
            }
        }

        private void GoToMenu_OnClick(object sender, EventArgs e)
        {
            this.Hide();
            UserAccount userAccount = new UserAccount();
            userAccount.Show();
        }
    }
}