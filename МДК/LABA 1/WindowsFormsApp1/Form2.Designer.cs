using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form2
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

        #endregion
    }
}