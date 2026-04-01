namespace MDK_LABA_2_3
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            LabelTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ButtonStart = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = false;
            LabelTime.BackColor = Color.Transparent;
            LabelTime.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTime.ForeColor = Color.White;
            LabelTime.Location = new Point(0, 0);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(100, 24);
            LabelTime.TabIndex = 0;
            LabelTime.Text = null;
            // 
            // ButtonStart
            // 
            ButtonStart.CustomizableEdges = customizableEdges1;
            ButtonStart.DisabledState.BorderColor = Color.DarkGray;
            ButtonStart.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonStart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonStart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonStart.FillColor = Color.White;
            ButtonStart.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold);
            ButtonStart.ForeColor = Color.Black;
            ButtonStart.Location = new Point(153, 148);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonStart.Size = new Size(180, 45);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "ЗАПУСТИТЬ";
            ButtonStart.Click += StartHandler;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(487, 312);
            Controls.Add(ButtonStart);
            Controls.Add(LabelTime);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelTime;
        private Guna.UI2.WinForms.Guna2Button ButtonStart;
    }
}