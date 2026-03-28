using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Form1 : FormCreator
    {
        private Label myLabel;
        private Button ButtonClick;
        private Button ButtonNext;
        private Button ExitButton;

        public Form1()
        {
            CreateAllElements();
            CreateControls();
        }

        protected override void CreateControls()
        {
            this.Controls.Add(myLabel);
            this.Controls.Add(ButtonClick);
            this.Controls.Add(ButtonNext);
            this.Controls.Add(ExitButton);
        }

        private void CreateAllElements()
        {
            myLabel = this.CreateLabel(text: "Кто сделал этот проект?", location: new Point(350, 100));
            ButtonClick = this.CreateButton(text: "Нажми меня", location: new Point(350, 200), handler: ButtonClickHandler);
            ExitButton = this.CreateButton(text: "Выход", location: new Point(350, 500), handler: ExitHandler);

            var buttons = this.CreateNavigation(
                location: new Point(500, 500),
                handler1: NextFormHandler);

            ButtonNext = buttons[0];


        }
        private void ButtonClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Шильников Максим Юрьевич");
        }

        private void NextFormHandler(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void ExitHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}