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

        private void ExecuteHandler(object sender, EventArgs e)
        {
            StringBuilder data = new StringBuilder();

            int.TryParse(TextBoxA.Text, out int TextA);
            int.TryParse(TextBoxB.Text, out int TextB);
            int.TryParse(TextBoxH.Text, out int TextH);

            for (int i = TextA; i <= TextB; i += TextH)
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
