using Guna.UI2.WinForms;

namespace Weather
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            OutPutLabel = new Guna2HtmlLabel();
            guna2Panel1 = new Guna2Panel();
            InPutTextBox = new Guna2TextBox();
            ExecuteButton = new Guna2Button();
            CloseButton = new Guna2Button();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // OutPutLabel
            // 
            OutPutLabel.AutoSize = false;
            OutPutLabel.BackColor = Color.Transparent;
            OutPutLabel.BackgroundImage = (Image)resources.GetObject("OutPutLabel.BackgroundImage");
            OutPutLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OutPutLabel.ForeColor = Color.White;
            OutPutLabel.Location = new Point(29, 99);
            OutPutLabel.Name = "OutPutLabel";
            OutPutLabel.Size = new Size(426, 88);
            OutPutLabel.TabIndex = 2;
            OutPutLabel.Text = null;
            OutPutLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = (Image)resources.GetObject("guna2Panel1.BackgroundImage");
            guna2Panel1.BorderColor = Color.Transparent;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 110;
            guna2Panel1.Controls.Add(InPutTextBox);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.ForeColor = Color.Transparent;
            guna2Panel1.Location = new Point(30, 296);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(425, 89);
            guna2Panel1.TabIndex = 3;
            // 
            // InPutTextBox
            // 
            InPutTextBox.BackColor = Color.Transparent;
            InPutTextBox.BackgroundImage = (Image)resources.GetObject("InPutTextBox.BackgroundImage");
            InPutTextBox.BorderColor = Color.Transparent;
            InPutTextBox.BorderRadius = 30;
            InPutTextBox.CustomizableEdges = customizableEdges3;
            InPutTextBox.DefaultText = "";
            InPutTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            InPutTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            InPutTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            InPutTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            InPutTextBox.FillColor = Color.LightSteelBlue;
            InPutTextBox.FocusedState.BorderColor = Color.Transparent;
            InPutTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            InPutTextBox.ForeColor = Color.White;
            InPutTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            InPutTextBox.Location = new Point(16, 12);
            InPutTextBox.Margin = new Padding(16, 20, 16, 20);
            InPutTextBox.Name = "InPutTextBox";
            InPutTextBox.PlaceholderText = "";
            InPutTextBox.SelectedText = "";
            InPutTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            InPutTextBox.Size = new Size(393, 66);
            InPutTextBox.TabIndex = 4;
            // 
            // ExecuteButton
            // 
            ExecuteButton.BackColor = Color.Transparent;
            ExecuteButton.BackgroundImage = (Image)resources.GetObject("ExecuteButton.BackgroundImage");
            ExecuteButton.BorderColor = Color.Transparent;
            ExecuteButton.CustomizableEdges = customizableEdges7;
            ExecuteButton.DisabledState.BorderColor = Color.DarkGray;
            ExecuteButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExecuteButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExecuteButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExecuteButton.FillColor = Color.Transparent;
            ExecuteButton.Font = new Font("Segoe UI", 9F);
            ExecuteButton.ForeColor = Color.White;
            ExecuteButton.Location = new Point(59, 409);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ExecuteButton.Size = new Size(381, 72);
            ExecuteButton.TabIndex = 0;
            ExecuteButton.Click += ExecuteHandler;
            // 
            // CloseButton
            // 
            CloseButton.CustomizableEdges = customizableEdges1;
            CloseButton.DisabledState.BorderColor = Color.DarkGray;
            CloseButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CloseButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CloseButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CloseButton.FillColor = Color.Teal;
            CloseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.ImageSize = new Size(45, 45);
            CloseButton.Location = new Point(433, 9);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CloseButton.Size = new Size(38, 35);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "✖";
            CloseButton.Click += guna2Button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(480, 800);
            Controls.Add(CloseButton);
            Controls.Add(OutPutLabel);
            Controls.Add(guna2Panel1);
            Controls.Add(ExecuteButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(480, 800);
            MinimumSize = new Size(480, 800);
            Name = "MainForm";
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel OutPutLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox InPutTextBox;
        private Guna.UI2.WinForms.Guna2Button ExecuteButton;
        private Guna2Button CloseButton;
    }
}
