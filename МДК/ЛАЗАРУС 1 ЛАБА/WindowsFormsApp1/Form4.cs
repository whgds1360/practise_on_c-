using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : FormCreator
    {
        private Label LabelA;
        private Label LabelB;
        private Label LabelH;
        private Label LabelResult;

        private TextBox TextBoxA;
        private TextBox TextBoxB;
        private TextBox TextBoxH;
        private TextBox TextBoxResult;

        private Button ButtonExecute;

        private Button ButtonBack;

        public Form4()
        {
            CreateAllElements();
            CreateControls();
        }

        protected override void CreateControls()
        {
            this.Controls.Add(LabelA);
            this.Controls.Add(LabelB);
            this.Controls.Add(LabelH);
            this.Controls.Add(LabelResult);

            this.Controls.Add(TextBoxA);
            this.Controls.Add(TextBoxB);
            this.Controls.Add(TextBoxH);
            this.Controls.Add(TextBoxResult);

            this.Controls.Add(ButtonExecute);

            this.Controls.Add(ButtonBack);
        }

        private void CreateAllElements()
        {
            LabelA = this.CreateLabel(text: "А", location: new Point(100, 100));
            LabelB = this.CreateLabel(text: "B", location: new Point(200, 100));
            LabelH = this.CreateLabel(text: "H", location: new Point(300, 100));
            LabelResult = this.CreateLabel(text: "Результат", location: new Point(400, 100));

            TextBoxA = this.CreateTextBox(text: "", location: new Point(100, 150));
            TextBoxB = this.CreateTextBox(text: "", location: new Point(200, 150));
            TextBoxH = this.CreateTextBox(text: "", location: new Point(300, 150));
            TextBoxResult = this.CreateTextBox(text: "", location: new Point(400, 150), heigth: 600);

            ButtonExecute = this.CreateButton(text: "Вычислить", new Point(450, 400), handler: ExecuteHandler);

            var buttons = this.CreateNavigation(
                location: new Point(400, 650),
                handler1: null,
                handler2: BackFormHandler);

            ButtonBack = buttons[1];
        }

        private void ExecuteHandler(object sender, EventArgs e)
        {
            StringBuilder data = new StringBuilder();

            for (int i = int.Parse(TextBoxB.Text); i <= int.Parse(TextBoxB.Text); i += int.Parse(TextBoxH.Text))
            {
                int x = i;

                int.TryParse(Math.Pow(x, 2).ToString(), out int y);

                string result =  $"X = {x} Y = {y.ToString()}";

                data.AppendLine(result);
            }

            TextBoxResult.Text = data.ToString();
        }

        private void BackFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
        }
    }   
}
