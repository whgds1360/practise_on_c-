using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract partial class FormCreator : Form
    {   
        protected const int DefaultWidth = 800;
        protected const int DefaultHeight = 800;

        public FormCreator()
        {
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected abstract void CreateControls();

        protected Button CreateButton(string text, Point location, EventHandler handler)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = location;
            button.AutoSize = true;
            button.Click += handler;

            return button;
        }

        protected Label CreateLabel(string text, Point location, bool autoSize = true)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = location;
            label.AutoSize = autoSize;

            return label;
        }

        protected TextBox CreateTextBox(string text, Point location, int width = 100)
        {
            TextBox textBox = new TextBox();
            textBox.Text = text;
            textBox.Location = location;
            textBox.Width = width;

            return textBox;
        }

        protected List<Button> CreateNavigation(Point location, EventHandler handler1 = null, EventHandler handler2 = null)
        {
            Button button1 = new Button();
            button1.Text = "Следующая";
            button1.Location = location;
            button1.AutoSize = true;
            button1.Click += handler1;

            Button button2 = new Button();
            button2.Text = "Предыдущая";
            button2.Location = new Point(location.X - 200, location.Y);
            button2.AutoSize = true;
            button2.Click += handler2;

            var data = new List<Button> { button1, button2 };

            return data;
        }

        protected void SwitchToForm(Form newForm, bool closeCurrent = true)
        {
            if (closeCurrent)
            {
                newForm.Show();
                this.Close();
            }
            else
            {
                newForm.Show();
                this.Hide();
            }
        }
    }
}