using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarManager
{
    public partial class SortForm : Form
    {
        public static string? Port;

        public static string? Host;

        public static string? DataBaseName;

        public static string? UserName;

        public static string? Password;

        public SortForm()
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

        private void SortOrderBy(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
            {
                try
                {
                    var sortData = context.Cars
                        .OrderBy(Car => Car.Cost)
                        .ToList();

                    MainForm.dataGridView1.DataSource = sortData;
                }
                catch (Exception error)
                {
                    System.Diagnostics.Debug.WriteLine($"С сортом лажа: {error.Message}");
                }
            }

        }

        private void SortOrderByDescending(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext(port: Port!, host: Host!, dbname: DataBaseName!, username: UserName!, password: Password!))
            {
                try
                {
                    var sortData = context.Cars
                        .OrderByDescending(Car => Car.Cost)
                        .ToList();

                    MainForm.dataGridView1.DataSource = sortData;
                }
                catch (Exception error)
                {
                    System.Diagnostics.Debug.WriteLine($"С сортом лажа: {error.Message}");
                }
            }

        }
    }
}