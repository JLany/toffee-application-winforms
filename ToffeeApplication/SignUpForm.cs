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

namespace ToffeeApplication
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            this.signUpButton.Click += SignUpButton_Click;
            this.FormClosed += SignUpForm_FormClosed;
        }

        private void SignUpForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ShowLoginForm();
        }

        private void SignUpButton_Click(object? sender, EventArgs e)
        {
            // TODO - validate fields


            bool succeed = Program.AccountComponent.SignUpCustomer(
                this.usernameTextBox.Text,
                this.passwordTextBox.Text,
                this.emailTextBox.Text,
                this.addressTextBox.Text);

            if (succeed)
            {
                // redirect to login form
                this.Close();
            }
            else
            {
                // Show error to user
            }
        }

        private void ShowLoginForm()
        {
            (new LoginForm()).Show();
        }
    }
}
