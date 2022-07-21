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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void showHome_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip ShowMenu = new ToolTip();
            ShowMenu.SetToolTip(this.HomeBtn, "Home");
        }

        private void showAccount_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip ShowAccount = new ToolTip();
            ShowAccount.SetToolTip(this.AccountBtn, "Accounts");
        }

        private void showCards_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip ShowCards = new ToolTip();
            ShowCards.SetToolTip(this.CardsBtn, "Cards");
        }

        private void showTransfers_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip ShowTransfers = new ToolTip();
            ShowTransfers.SetToolTip(this.TransfersBtn, "Transfers");
        }

        private void LogOut_onClick(object sender, EventArgs e)
        {
            DialogResult exitQuestion = MessageBox.Show("Do you want to Logout ?", "Logout"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2);

            if (exitQuestion == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
            else if (exitQuestion == DialogResult.No)
            {
                base.OnClosed(e);
            }

        }

        private void GoToAcounts_onClick(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accounts = new Accounts();
            accounts.Show();
        }

        private void GoToHome_onClikc(object sender, EventArgs e)
        {
            this.Hide();
            UserAccount userAccount = new UserAccount();
            userAccount.Show(); 
        }

        private void GoToCards_onClick(object sender, EventArgs e)
        {
            this.Hide();
            Cards cards = new Cards();
            cards.Show();
            panel3.Show();

        }
    }
}
