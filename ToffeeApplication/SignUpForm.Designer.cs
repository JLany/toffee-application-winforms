namespace ToffeeApplication
{
    partial class SignUpForm
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
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(142, 18);
            headerLabel.Margin = new Padding(5, 0, 5, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(389, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Sgin Up a New Account";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(255, 118);
            usernameTextBox.Margin = new Padding(5, 6, 5, 6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(261, 35);
            usernameTextBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(139, 121);
            usernameLabel.Margin = new Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(106, 30);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(255, 166);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(261, 35);
            passwordTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(139, 169);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 30);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(255, 218);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(261, 35);
            emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(139, 221);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(255, 271);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(261, 35);
            addressTextBox.TabIndex = 12;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(139, 274);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(87, 30);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address";
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(276, 346);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(103, 47);
            signUpButton.TabIndex = 13;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(655, 454);
            Controls.Add(signUpButton);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SignUpForm";
            Text = "Sign Up ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private Button signUpButton;
    }
}