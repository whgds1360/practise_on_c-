using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDK_LABA_2_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void ExecuteHandler(object sender, EventArgs e)
        {
            double.TryParse(TextBoxA.Text, out double A);
            double.TryParse(TextBoxC.Text, out double C);

            double ResultS = C / 2 * Math.Cos(A);
            double Resulta = Math.Pow(C, 2) / 4 * Math.Tan(A);

            TextBoxResultS.Text = ResultS.ToString();
            TextBoxResulta.Text = Resulta.ToString();
        }
    }
}
