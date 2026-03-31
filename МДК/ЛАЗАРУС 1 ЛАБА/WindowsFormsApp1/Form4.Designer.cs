using System.Drawing;
using WindowsFormsApp1;
using System;


namespace WindowsFormsApp1
{
    partial class Form4
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
        private void CreateAllElements()
        {
            LabelA = this.CreateLabel(text: "А", location: new Point(100, 100));
            LabelB = this.CreateLabel(text: "B", location: new Point(200, 100));
            LabelH = this.CreateLabel(text: "H", location: new Point(300, 100));
            LabelResult = this.CreateLabel(text: "Результат", location: new Point(400, 100));

            TextBoxA = this.CreateTextBox(text: "", location: new Point(100, 150));
            TextBoxB = this.CreateTextBox(text: "", location: new Point(200, 150));
            TextBoxH = this.CreateTextBox(text: "", location: new Point(300, 150));
            TextBoxResult = this.CreateTextBox(text: "", location: new Point(400, 150), heigth: 200);
            TextBoxResult.Multiline = true;

            ButtonExecute = this.CreateButton(text: "Вычислить", new Point(450, 400), handler: ExecuteHandler);

            var buttons = this.CreateNavigation(
                location: new Point(400, 650),
                handler1: null,
                handler2: BackFormHandler);

            ButtonBack = buttons[1];
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

        #endregion
    }
}