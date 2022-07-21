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
    public partial class LogoForm : Form
    {
        public LogoForm()
        {
            InitializeComponent();
        }

        private void GoToLogin_Onclick(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MoveToLogin_onEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.pictureBox1, "Click");

            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
