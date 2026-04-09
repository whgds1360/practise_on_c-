using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
        #endregion
    }
}