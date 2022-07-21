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
    public partial class Accounts : Form
    {

        public Accounts()
        {
            InitializeComponent();
        }

        private void GoToHome_onClick(object sender, EventArgs e)
        {
            this.Close();
            UserAccount userAccount = new UserAccount();
            userAccount.Show();
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

        private void ShowAll_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip showAll = new ToolTip();
            showAll.SetToolTip(this.ShowAllTransactions, "All");
        }

        private void showCurrentTransactions(object sender, EventArgs e)
        {
            ToolTip showCurrentTransactions = new ToolTip();
            showCurrentTransactions.SetToolTip(this.CurrentTransactions, "Current");
        }

        private void showAllSaving_onMouseEnter(object sender, EventArgs e)
        {
            ToolTip showSaving = new ToolTip();
            showSaving.SetToolTip(this.piggyBank, "Savings");
        }

        private void SelectShowAllTransactions_onClick(object sender, EventArgs e)
        {
            piggyPicture.Hide();
            cardPicture.Hide();
            walletPicture.Show();
            panel3.BackColor = Color.DarkCyan;
            panel4.BackColor = Color.CadetBlue;
            panel5.BackColor = Color.CadetBlue;
            label2.Text = "All";
            panel6.Show();

        }

        private void SelectCurrenttransactions_onClick(object sender, EventArgs e)
        {
            piggyPicture.Hide();
            walletPicture.Hide();
            cardPicture.Show();
            panel3.BackColor = Color.CadetBlue;
            panel4.BackColor = Color.DarkCyan;
            panel5.BackColor = Color.CadetBlue;
            label2.Text = "Current";
            panel6.Hide();

        }

        private void SelectPiggyBank_onClick(object sender, EventArgs e)
        {
            panel6.Hide();
            panel3.BackColor = Color.CadetBlue;
            panel4.BackColor = Color.CadetBlue;
            panel5.BackColor = Color.DarkCyan;
            label2.Text = "Savings";
            piggyPicture.Show();

        }

        private void GoToCards_onClick(object sender, EventArgs e)
        {
            this.Hide();
            Cards cards = new Cards();
            cards.Show();

        }

        private void GoToAcounts_onClick(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accounts = new Accounts();
            accounts.Show();
            panel3.Show();

        }
    }
}
