namespace ToffeeApplication
{
    partial class LoginForm
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
            headerLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            signUpLink = new LinkLabel();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(229, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Toffee Sweets";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(103, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(103, 176);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 30);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(215, 132);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(244, 35);
            emailTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(215, 173);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(244, 35);
            passwordTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(230, 231);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(103, 47);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // signUpLink
            // 
            signUpLink.AutoSize = true;
            signUpLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signUpLink.Location = new Point(249, 291);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(61, 21);
            signUpLink.TabIndex = 7;
            signUpLink.TabStop = true;
            signUpLink.Text = "sign up";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(562, 332);
            Controls.Add(signUpLink);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LoginForm";
            Text = "Toffee Sweets - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private LinkLabel signUpLink;
    }
}