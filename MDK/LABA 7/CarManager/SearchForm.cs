namespace CarManager
{
    public partial class SearchForm : Form
    {
        public static string? Port;

        public static string? Host;

        public static string? DataBaseName;

        public static string? UserName;

        public static string? Password;

        public SearchForm()
        {
            InitializeComponent();
        }

        public static void ParsingData(string port, string host, string dbname, string username, string password)
        {
            Port = port;
            Host = host;
            DataBaseName = dbname;
            UserName = username;
            Password = password;
        }

        private void Search(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
            {
                try
                {
                    var searchData = context.Cars
                        .Where(Car => Car.Vin == VinTextBox.Text)
                        .ToList();

                    MainForm.dataGridView1.DataSource = searchData;
                }
                catch (Exception error)
                {
                    System.Diagnostics.Debug.WriteLine($"С поиском лажа: {error.Message}");
                }
            }
        }
    }
}
