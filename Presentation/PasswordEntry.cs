namespace WinFormsApp1.Presentation
{
    internal class PasswordEntry : TextBox
    {
        public PasswordEntry(int pointX, int pointY, Form form )
        {
            AutoSize = true;
            Name = "passwordEntry";
            TabIndex = 1;
            UseSystemPasswordChar = true;
        }
    }
}
