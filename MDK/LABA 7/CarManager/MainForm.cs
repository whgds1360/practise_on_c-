namespace CarManager;

public partial class MainForm : Form
{
    public DataBaseForm dataBaseForm = new DataBaseForm();
    public AddRecordForm addrecordForm = new AddRecordForm();
    public DelRecordForm delrecordForm = new DelRecordForm();

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
}
