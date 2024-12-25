namespace WinFormsApp1.Presentation
{
    public partial class LoginForm : Form
    {
        private UsernameLabel   usernameLabel;
        private PasswordLabel   passwordLabel;
        private UsernameEntry   usernameEntry;
        private PasswordEntry   passwordEntry;
        private LoginButton     loginButton;

        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(!IsUsernameValid(usernameEntry.Text) && !IsPasswordValid(passwordEntry.Text)) 
            {
                MessageBox.Show("Enter a valid username and password");
                usernameEntry.Clear();
                passwordEntry.Clear();
                return;
            }

            if (!IsUsernameValid(usernameEntry.Text)) 
            { 
                MessageBox.Show("Enter a valid username");
                usernameEntry.Clear();
                return;
            }

            if (!IsPasswordValid(passwordEntry.Text)) 
            {
                MessageBox.Show("Enter a valid password");
                passwordEntry.Clear();
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
