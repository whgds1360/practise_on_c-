namespace AuthorizationWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginHandler(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();

                if (users.Any(user => user.Login == LoginTextBox.Text && user.Password == PasswordTextBox.Text))
                {
                    ResultLabel.Text = "Вход успешен!";
                }
                else
                {
                    ResultLabel.Text = "Некоретные данные для входа!";
                }
            }
        }

        private void RegHandler(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();

                if (users.Any(user => user.Login == LoginTextBox.Text))
                {
                    ResultLabel.Text = "Логин занят!";
                }
                else 
                {
                    User user = new User {Login = LoginTextBox.Text, Password = PasswordTextBox.Text};

                    db.Users.Add(user);
                    db.SaveChanges();

                    ResultLabel.Text = "Успешная регистрация!";
                }
            }
        }

        private void CloseHandelr(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
