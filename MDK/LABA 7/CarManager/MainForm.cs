namespace CarManager;

public partial class MainForm : Form
{
    public DataBaseForm dataBaseForm = new DataBaseForm();
    public AddRecordForm addrecordForm = new AddRecordForm();
    public DelRecordForm delrecordForm = new DelRecordForm();
    public SearchForm searchForm = new SearchForm();
    public SortForm sortForm = new SortForm();

    public static string? Port;

    public static string? Host;

    public static string? DataBaseName;

    public static string? UserName;

    public static string? Password;

    public MainForm()
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

    private void ShowMenuDataBase(object sender, EventArgs e)
    {
        dataBaseForm.TopLevel = false;
        dataBaseForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(dataBaseForm);
        dataBaseForm.Show();
    }

    private void ShowMenuAddRecord(object sender, EventArgs e)
    {
        addrecordForm.TopLevel = false;
        addrecordForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(addrecordForm);
        addrecordForm.Show();
    }

    private void ShowMenuDelRecord(object sender, EventArgs e)
    {
        delrecordForm.TopLevel = false;
        delrecordForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(delrecordForm);
        delrecordForm.Show();
    }

    private void ShowMenuSearch(object sender, EventArgs e)
    {
        searchForm.TopLevel = false;
        searchForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(searchForm);
        searchForm.Show();
    }

    private void ShowMenuSort(object sender, EventArgs e)
    {
        sortForm.TopLevel = false;
        sortForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(sortForm);
        sortForm.Show();
    }

    private void VisibleUpToDateData(object sender, EventArgs e)
    {
        using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
        {
            try
            {
                if (context.Cars.ToList() != null)
                {
                    dataGridView1.DataSource = context.Cars.ToList();
                }
            }

            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Что - то пошло не так при отображении актульных данных");
            }
        }
    }
}
