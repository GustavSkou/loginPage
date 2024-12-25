namespace WinFormsApp1.Presentation
{
    internal class PasswordEntry : TextBox
    {
        public PasswordEntry(int pointX, int pointY)
        {
            AutoSize = true;
            Location = new Point(pointX, pointY);
            Name = "passwordEntry";
            Size = new Size(216, 35);
            TabIndex = 1;
            UseSystemPasswordChar = true;
        }
    }
}
