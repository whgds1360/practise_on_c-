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