namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(!IsUsernameValid(usernameEntry.Text) && !IsPasswordValid(passwordEntry.Text)) 
            {
                MessageBox.Show("Enter a valid username and password");
                return;
            }

            if (!IsUsernameValid(usernameEntry.Text)) 
            { 
                MessageBox.Show("Enter a valid username");
                return;
            }

            if (!IsPasswordValid(passwordEntry.Text)) 
            {
                MessageBox.Show("Enter a valid password");
                return;
            }
            MessageBox.Show("Login button clicked!");   
        }

        private bool IsUsernameValid(string username)
        {
            return username.Length > 0;
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length > 0;
        }
    }
}
