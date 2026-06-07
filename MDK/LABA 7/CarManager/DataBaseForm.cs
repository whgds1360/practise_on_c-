namespace CarManager
{
    public partial class DataBaseForm : Form
    {
        public string Port;

        public string Host;

        public string DataBaseName;

        public string UserName;

        public string Password;



        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void ConnectToDataBase(object sender, EventArgs e)
        {
            Port = DataBasePortTextBox.Text;
            Host = HostTextBox.Text;
            DataBaseName = NameDBTextBox.Text;
            UserName = UserNameTextBox.Text;
            Password = PasswordTextBox.Text;

            using (var context = new ApplicationContext(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password))
            {
                if (context.Database.CanConnect())
                {
                    MainForm.StatusLabel.Text = "Подключение установлено";
                    MainForm.StatusLabel.ForeColor = Color.Green;

                    context.Ensure();

                    MainForm.ParsingData(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password);
                    AddRecordForm.ParsingData(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password);
                    DelRecordForm.ParsingData(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password);
                    SearchForm.ParsingData(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password);
                    SortForm.ParsingData(port: Port, host: Host, dbname: DataBaseName, username: UserName, password: Password);

                    MainForm.dataGridView1.DataSource = context.Cars.ToList();
                }
                else 
                {
                    MainForm.StatusLabel.Text = "Ошибка подключения";
                    MainForm.StatusLabel.ForeColor = Color.Orange;
                }
            }
        }
    }
}
