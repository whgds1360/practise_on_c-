namespace MDK_LABA_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickTask1Handler(object sender, EventArgs e)
        {
            var form2 = new Form2();

            // Настройки для встраивания
            form2.TopLevel = false;        // "верхнеуровневость" убирает
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;    // Растягиваем на всю панель

            CenterPanel.Controls.Clear();

            CenterPanel.Controls.Add(form2);
            form2.Show();
        }

        private void ClickTask2Handler(object sender, EventArgs e)
        {
            var form3 = new Form3();

            // Настройки для встраивания
            form3.TopLevel = false;        // "верхнеуровневость" убирает
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;    // Растягиваем на всю панель

            CenterPanel.Controls.Clear();

            CenterPanel.Controls.Add(form3);
            form3.Show();
        }

        private void ClickTask3Handler(object sender, EventArgs e)
        {
            var form4 = new Form4();

            // Настройки для встраивания
            form4.TopLevel = false;        // "верхнеуровневость" убирает
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;    // Растягиваем на всю панель

            CenterPanel.Controls.Clear();

            CenterPanel.Controls.Add(form4);
            form4.Show();
        }

        private void EnterMouse(object sender, EventArgs e)
        {
            if (sender == ButtonTask1)
            {
                BackLigthTask1.BackColor = Color.Purple;
            }

            else if (sender == ButtonTask2)
            {
                BackLigthTask2.BackColor = Color.Purple;
            }

            else if (sender == ButtonTask3)
            {
                BackLigthTask3.BackColor = Color.Purple;
            }
        }

        private void LeaveMouse(object sender, EventArgs e)
        {
            if (sender == ButtonTask1)
            {
                BackLigthTask1.BackColor = Color.Black;
            }

            else if (sender == ButtonTask2)
            {
                BackLigthTask2.BackColor = Color.Black;
            }

            else if (sender == ButtonTask3)
            {
                BackLigthTask3.BackColor = Color.Black;
            }
        }

        private void ExitHandeler(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackLigthTask3_Click(object sender, EventArgs e)
        {

        }
    }
}
