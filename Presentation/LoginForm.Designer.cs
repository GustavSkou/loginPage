using System.Windows.Forms;

namespace WinFormsApp1.Presentation
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private int clientHeight = 600, clientWidth = 700;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent ()
        {
            SuspendLayout ();

            // LoginForm 
            AutoScaleDimensions = new SizeF ( 12F, 30F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( clientWidth, clientHeight );
            StartPosition = FormStartPosition.CenterScreen;
            Name = "loginForm";
            Text = "Login Page";

            usernameLabel = new UsernameLabel ( 50, 50, this );
            usernameEntry = new UsernameEntry ( clientWidth / 2, 80, this );
            passwordLabel = new PasswordLabel ( 50, 150, this );
            passwordEntry = new PasswordEntry ( clientWidth / 2, 180, this );
            loginButton = new LoginButton ( 50, 250, this );

            Controls.AddRange ( new Control[] {
                usernameLabel, usernameEntry,
                passwordLabel, passwordEntry,
                loginButton
            } );

            ResumeLayout ( false );
            PerformLayout ();

            loginButton.AddClickEvent ( new EventHandler ( LoginButton_Click ) );

            Resize += new EventHandler (LoginForm_Resize);
           

        }
        private void LoginForm_Resize ( object sender, EventArgs e )
        {
            usernameEntry.Size = new Size ( (int) ( Width / 1.5 ), 35 );
            usernameEntry.Location = new Point ( 100, 80 );
            passwordEntry.Size = new Size ( (int) ( Width / 1.5 ), 35 );
            passwordEntry.Location = new Point ( Width / 2 - passwordEntry.Width / 2, 180 );

        }
    }
}