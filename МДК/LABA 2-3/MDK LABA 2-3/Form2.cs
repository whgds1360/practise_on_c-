using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDK_LABA_2_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       private void ExecuteHandler(object sender, EventArgs e)
        {
            double.TryParse(TextBoxA.Text, out double A);
            double.TryParse(TextBoxB.Text, out double B);
            double.TryParse(TextBoxT.Text, out double T);

            double Result = Math.Pow(Math.E, B*T*-1) * Math.Sin(A*T + B) - Math.Sqrt(Math.Abs(B*T+A));

            TextBoxResult.Text = Result.ToString();
        }
    }
}
