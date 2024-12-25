using WinFormsApp1.Presentation;

namespace WinFormsApp1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            usernameLabel   = new UsernameLabel(50, 50);
            usernameEntry   = new UsernameEntry(50, 80);
            passwordLabel   = new PasswordLabel(50, 150);
            passwordEntry   = new PasswordEntry(50, 180);
            loginButton     = new LoginButton(50, 250);

            SuspendLayout();

            // LoginForm 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.AddRange([
                usernameLabel,  usernameEntry,
                passwordLabel,  passwordEntry,
                loginButton
            ]);
            Name = "loginForm";
            Text = "Login Page";

            ResumeLayout(false);
            PerformLayout();

            loginButton.AddClickEvent(new EventHandler(LoginButton_Click));
        }

        #endregion

        private UsernameLabel usernameLabel;
        private PasswordLabel passwordLabel;
        private UsernameEntry usernameEntry;
        private PasswordEntry passwordEntry;
        private LoginButton loginButton;
    }
}