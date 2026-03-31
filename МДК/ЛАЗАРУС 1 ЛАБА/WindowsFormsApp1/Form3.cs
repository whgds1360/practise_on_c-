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
        private void ExecuteHandler(object sender, EventArgs e)
        {   
            double.TryParse(Number.Text, out double number);
            double.TryParse(Degree.Text, out double degree);

            Result.Text = (Math.Pow(number, degree)).ToString(); 
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
