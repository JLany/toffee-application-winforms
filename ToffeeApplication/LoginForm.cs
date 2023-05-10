using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToffeeSystemPrototype.AccountComponent;
using ToffeeSystemPrototype.AccountComponent;

namespace ToffeeApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // this.FormClosed +=
            //     new FormClosedEventHandler(this.LoginForm_FormClosed);

            this.signUpLink.Click += SignUpLink_Click;
            this.loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            bool authenticated = Program.AccountComponent
                .AuthenticateAccount(this.emailTextBox.Text, this.passwordTextBox.Text);

            if (authenticated) // FOR DEBUGGING PURPOSES
            {
                (new PlaceOrderForm(new UserSession(this.emailTextBox.Text, DateTime.Now))).Show();
                this.Close();
            }
            else
            {
                // TODO - show error message
            }
        }

        private void LoginForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Application.Exit();
        }

        private void SignUpLink_Click(object? sender, EventArgs e)
        {
            (new SignUpForm()).Show();
            this.Close();
        }
    }
}
