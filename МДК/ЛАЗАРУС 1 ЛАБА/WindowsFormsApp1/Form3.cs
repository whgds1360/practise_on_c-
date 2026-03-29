using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : FormCreator
    {
        private Label Label1;
        private Label Label2;

        private TextBox Number;
        private TextBox Degree;
        private TextBox Result;

        private Button ButtonExecute;

        private Button ButtonNext;
        private Button ButtonBack;

        public Form3()
        {
            CreateAllElement();
            CreateControls();
        }

        protected override void CreateControls()
        {
            this.Controls.Add(Label1);
            this.Controls.Add(Label2);

            this.Controls.Add(Number);
            this.Controls.Add(Degree);
            this.Controls.Add(Result);

            this.Controls.Add(ButtonExecute);

            this.Controls.Add(ButtonNext);
            this.Controls.Add(ButtonBack);
        }

        private void CreateAllElement()
        {
            Label1 = this.CreateLabel(text: "Первое число", location: new Point(350, 200));
            Label2 = this.CreateLabel(text: "Второе число", location: new Point(450, 200));

            Number = this.CreateTextBox(text: "", location: new Point(350, 300));
            Degree = this.CreateTextBox(text: "", location: new Point(450, 300));
            Result = this.CreateTextBox(text: "Результат", location: new Point(550, 300));

            ButtonExecute = this.CreateButton(text: "Выполнить", location: new Point(400, 500), handler: ExecuteHandler);

            var buttons = this.CreateNavigation(
                location: new Point(400, 650),
                handler1: NextFormHandler,
                handler2: BackFormHandler);

            ButtonNext = buttons[0];
            ButtonBack = buttons[1];
        }

        private void ExecuteHandler(object sender, EventArgs e)
        {   
            Result.Text = (Math.Pow(double.Parse(Number.Text), double.Parse(Degree.Text))).ToString(); 
        }

        private void NextFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
        }

        private void BackFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

    }
}
