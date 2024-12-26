namespace WinFormsApp1.Presentation
{
    internal class LoginButton : Button
    {
        public LoginButton(int pointX, int pointY, Form form )
        {
            AutoSize = true;
            Location = new Point(pointX, pointY);
            Name = "loginButton";
            TabIndex = 3;
            Text = "Login";
            UseVisualStyleBackColor = true;
        }

        public void AddClickEvent(EventHandler eventHandler)
        {
            Click += eventHandler;
        }


    }
}
