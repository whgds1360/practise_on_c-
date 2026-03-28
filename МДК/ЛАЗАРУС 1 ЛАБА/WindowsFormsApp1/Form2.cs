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
    public partial class Form2 : FormCreator
    {
        private Label Label1;
        private Label Label2;

        private TextBox TextBox1;
        private TextBox TextBox2;

        private Button ButtonSwap;
        private Button ButtonNext;
        private Button ButtonBack;
        public Form2()
        {
            CreateAllElement();
            CreateControls();
        }

        protected override void CreateControls()
        {
            this.Controls.Add(Label1);
            this.Controls.Add(Label2);

            this.Controls.Add(TextBox1);
            this.Controls.Add(TextBox2);

            this.Controls.Add(ButtonSwap);
            this.Controls.Add(ButtonNext);
            this.Controls.Add(ButtonBack);

        }

        private void CreateAllElement()
        {
            Label1 = this.CreateLabel(text: "Первое число", location: new Point(350, 200));
            Label2 = this.CreateLabel(text: "Второе число", location: new Point(450, 200));

            TextBox1 = this.CreateTextBox(text: "", location: new Point(350, 300));
            TextBox2 = this.CreateTextBox(text: "", location: new Point(450, 300));

            ButtonSwap = this.CreateButton(text: "Свапнуть", location: new Point(500, 400), handler: SwapHandler);
            
            var buttons = this.CreateNavigation(
                location: new Point(400, 650), 
                handler1: NextFormHandler, 
                handler2: BackFormHandler);

            ButtonNext = buttons[0];
            ButtonBack = buttons[1];
        }

        private void SwapHandler(object sender, EventArgs e)
        {
            (TextBox1.Text, TextBox2.Text) = (TextBox2.Text, TextBox1.Text);
        }

        private void NextFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
        }

        private void BackFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }
    }
}