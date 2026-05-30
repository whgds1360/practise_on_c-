namespace CarManager
{
    public partial class DelRecordForm : Form
    {
        public static string? Port;

        public static string? Host;

        public static string? DataBaseName;

        public static string? UserName;

        public static string? Password;

        public DelRecordForm()
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

        private void DeleteData(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
            {
                var dataToDel = context.Cars.Find(DelTextBox.Text);
                if (dataToDel != null)
                {
                    context.Cars.Remove(dataToDel);
                }

                context.SaveChanges();

                MainForm.dataGridView1.DataSource = context.Cars.ToList();
            }
        }
    }
}
