namespace WinFormsApp1.Presentation
{
    internal class PasswordLabel : Label
    {
        public PasswordLabel(int pointX, int pointY, Form form )
        {
            AutoSize = true;
            Location = new Point(pointX, pointY);
            Name = "passwordLabel";
            Size = new Size(99, 30);
            TabIndex = 0;
            Text = "Password";
        }
    }
}
