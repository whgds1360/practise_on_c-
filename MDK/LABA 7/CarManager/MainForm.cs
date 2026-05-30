namespace CarManager;

public partial class MainForm : Form
{
    public DataBaseForm dataBaseForm = new DataBaseForm();
    public RecordForm recordForm = new RecordForm();

    public string Port;
    public string Host;
    public string DataBaseName;
    public string UserName;
    public string Password;

    public MainForm()
    {
        InitializeComponent();
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

    private void ShowMenuRecord(object sender, EventArgs e)
    {
        recordForm.TopLevel = false;
        recordForm.Dock = DockStyle.Fill;

        foreach (Control widget in panel3.Controls)
        {
            widget.Hide();
        }

        panel3.Controls.Add(recordForm);
        recordForm.Show();
    }
}
