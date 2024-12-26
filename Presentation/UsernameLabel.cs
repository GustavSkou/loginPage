namespace WinFormsApp1.Presentation
{
    internal class UsernameLabel : Label
    {
        public UsernameLabel(int pointX, int pointY, Form form )
        {
            AutoSize = true;
            Location = new Point(pointX, pointY);
            Name = "usernameLabel";
            Size = new Size(110, 30);
            TabIndex = 0;
            Text = "UserName";
        }
    }
}
