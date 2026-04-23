namespace MDK_LABA_2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackLigthTask3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackLigthTask2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackLigthTask1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ButtonTask3 = new Guna.UI2.WinForms.Guna2Button();
            ButtonTask2 = new Guna.UI2.WinForms.Guna2Button();
            ButtonTask1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Black;
            guna2Panel1.Controls.Add(ButtonExit);
            guna2Panel1.CustomizableEdges = customizableEdges13;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel1.Size = new Size(700, 39);
            guna2Panel1.TabIndex = 0;
            // 
            // ButtonExit
            // 
            ButtonExit.BackColor = Color.White;
            ButtonExit.CustomizableEdges = customizableEdges11;
            ButtonExit.DefaultAutoSize = true;
            ButtonExit.DisabledState.BorderColor = Color.DarkGray;
            ButtonExit.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonExit.FillColor = Color.Black;
            ButtonExit.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonExit.ForeColor = Color.White;
            ButtonExit.Location = new Point(657, 1);
            ButtonExit.Margin = new Padding(3, 2, 3, 2);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ButtonExit.Size = new Size(43, 34);
            ButtonExit.TabIndex = 0;
            ButtonExit.Text = "🗙";
            ButtonExit.TextAlign = HorizontalAlignment.Left;
            ButtonExit.Click += ExitHandeler;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Black;
            guna2Panel2.Controls.Add(guna2HtmlLabel2);
            guna2Panel2.Controls.Add(BackLigthTask3);
            guna2Panel2.Controls.Add(BackLigthTask2);
            guna2Panel2.Controls.Add(BackLigthTask1);
            guna2Panel2.Controls.Add(ButtonTask3);
            guna2Panel2.Controls.Add(ButtonTask2);
            guna2Panel2.Controls.Add(ButtonTask1);
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.Controls.Add(guna2HtmlLabel1);
            guna2Panel2.CustomizableEdges = customizableEdges9;
            guna2Panel2.Dock = DockStyle.Left;
            guna2Panel2.Location = new Point(0, 39);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel2.Size = new Size(213, 299);
            guna2Panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.BackgroundImage = (Image)resources.GetObject("guna2HtmlLabel2.BackgroundImage");
            guna2HtmlLabel2.Location = new Point(57, 0);
            guna2HtmlLabel2.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(94, 99);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = null;
            // 
            // BackLigthTask3
            // 
            BackLigthTask3.AutoSize = false;
            BackLigthTask3.BackColor = Color.Black;
            BackLigthTask3.ForeColor = Color.White;
            BackLigthTask3.Location = new Point(0, 232);
            BackLigthTask3.Margin = new Padding(3, 2, 3, 2);
            BackLigthTask3.Name = "BackLigthTask3";
            BackLigthTask3.Size = new Size(13, 42);
            BackLigthTask3.TabIndex = 5;
            BackLigthTask3.Text = null;
            BackLigthTask3.Click += BackLigthTask3_Click;
            // 
            // BackLigthTask2
            // 
            BackLigthTask2.AutoSize = false;
            BackLigthTask2.BackColor = Color.Black;
            BackLigthTask2.ForeColor = Color.White;
            BackLigthTask2.Location = new Point(0, 189);
            BackLigthTask2.Margin = new Padding(3, 2, 3, 2);
            BackLigthTask2.Name = "BackLigthTask2";
            BackLigthTask2.Size = new Size(13, 42);
            BackLigthTask2.TabIndex = 4;
            BackLigthTask2.Text = null;
            // 
            // BackLigthTask1
            // 
            BackLigthTask1.AutoSize = false;
            BackLigthTask1.BackColor = Color.Black;
            BackLigthTask1.ForeColor = Color.White;
            BackLigthTask1.Location = new Point(0, 143);
            BackLigthTask1.Margin = new Padding(3, 2, 3, 2);
            BackLigthTask1.Name = "BackLigthTask1";
            BackLigthTask1.Size = new Size(13, 42);
            BackLigthTask1.TabIndex = 0;
            BackLigthTask1.Text = null;
            // 
            // ButtonTask3
            // 
            ButtonTask3.CustomizableEdges = customizableEdges3;
            ButtonTask3.DisabledState.BorderColor = Color.DarkGray;
            ButtonTask3.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonTask3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonTask3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonTask3.FillColor = Color.Black;
            ButtonTask3.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTask3.ForeColor = Color.White;
            ButtonTask3.Location = new Point(0, 232);
            ButtonTask3.Margin = new Padding(3, 2, 3, 2);
            ButtonTask3.Name = "ButtonTask3";
            ButtonTask3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ButtonTask3.Size = new Size(213, 42);
            ButtonTask3.TabIndex = 3;
            ButtonTask3.Text = "ЗАДАНИЕ 3";
            ButtonTask3.Click += ClickTask3Handler;
            ButtonTask3.MouseEnter += EnterMouse;
            ButtonTask3.MouseLeave += LeaveMouse;
            // 
            // ButtonTask2
            // 
            ButtonTask2.CustomizableEdges = customizableEdges5;
            ButtonTask2.DisabledState.BorderColor = Color.DarkGray;
            ButtonTask2.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonTask2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonTask2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonTask2.FillColor = Color.Black;
            ButtonTask2.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTask2.ForeColor = Color.White;
            ButtonTask2.Location = new Point(0, 189);
            ButtonTask2.Margin = new Padding(3, 2, 3, 2);
            ButtonTask2.Name = "ButtonTask2";
            ButtonTask2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ButtonTask2.Size = new Size(213, 42);
            ButtonTask2.TabIndex = 2;
            ButtonTask2.Text = "ЗАДАНИЕ 2";
            ButtonTask2.Click += ClickTask2Handler;
            ButtonTask2.MouseEnter += EnterMouse;
            ButtonTask2.MouseLeave += LeaveMouse;
            // 
            // ButtonTask1
            // 
            ButtonTask1.CustomizableEdges = customizableEdges7;
            ButtonTask1.DisabledState.BorderColor = Color.DarkGray;
            ButtonTask1.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonTask1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonTask1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonTask1.FillColor = Color.Black;
            ButtonTask1.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTask1.ForeColor = Color.White;
            ButtonTask1.Location = new Point(0, 143);
            ButtonTask1.Margin = new Padding(3, 2, 3, 2);
            ButtonTask1.Name = "ButtonTask1";
            ButtonTask1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ButtonTask1.Size = new Size(213, 42);
            ButtonTask1.TabIndex = 0;
            ButtonTask1.Text = "ЗАДАНИЕ 1";
            ButtonTask1.Click += ClickTask1Handler;
            ButtonTask1.MouseEnter += EnterMouse;
            ButtonTask1.MouseLeave += LeaveMouse;
            // 
            // label1
            // 
            label1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 101);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 0;
            label1.Text = "whgds1360";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(38, 25);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = null;
            // 
            // CenterPanel
            // 
            CenterPanel.BackColor = Color.Black;
            CenterPanel.CustomizableEdges = customizableEdges1;
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(213, 39);
            CenterPanel.Margin = new Padding(3, 2, 3, 2);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CenterPanel.Size = new Size(487, 299);
            CenterPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(CenterPanel);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button ButtonExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel BackLigthTask1;
        private Guna.UI2.WinForms.Guna2Button ButtonTask3;
        private Guna.UI2.WinForms.Guna2Button ButtonTask2;
        private Guna.UI2.WinForms.Guna2Button ButtonTask1;
        private Guna.UI2.WinForms.Guna2HtmlLabel BackLigthTask3;
        private Guna.UI2.WinForms.Guna2HtmlLabel BackLigthTask2;
    }
}
