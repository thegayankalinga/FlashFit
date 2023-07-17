using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFitWinFormUI
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void loginLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLoginForm loginForm = new UserLoginForm();
            this.Hide();
            loginForm.Show();
            this.Close();

        }
    }
}
