namespace WinFormsApp1.Presentation
{
    internal class UsernameEntry : TextBox
    {
        public UsernameEntry(int pointX, int pointY, Form form )
        {
            AutoSize = true;
            Name = "usernameEntry";
            Location = new Point ( form.Width / 2 - Size.Width / 2, pointY );
            TabIndex = 0;
        }
    }
}
