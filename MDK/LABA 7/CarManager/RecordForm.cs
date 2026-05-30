using Microsoft.VisualBasic.ApplicationServices;

namespace CarManager
{
    public partial class RecordForm : Form
    {
        public static string? Port;

        public static string? Host;

        public static string? DataBaseName;

        public static string? UserName;

        public static string? Password;

        public RecordForm()
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

        private void CreateData (object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
            {
                Car car = new Car { Vin = VINTextBox.Text, Manufacturer = MadeTextBox.Text, Model = ModelTextBox.Text, Cost = CostTextBox.Text };

                context.Cars.Add(car);
                context.SaveChanges();

                MainForm.dataGridView1.DataSource = context.Cars.ToList();
            }
        }
    }
}
