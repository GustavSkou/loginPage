namespace WinFormsApp1.Presentation
{
    internal class UsernameEntry : TextBox
    {
        public UsernameEntry(int pointX, int pointY)
        {
            AutoSize = true;
            Location = new Point(pointX, pointY);
            Name = "usernameEntry";
            Size = new Size(216, 35);
            TabIndex = 0;
        }
    }
}
