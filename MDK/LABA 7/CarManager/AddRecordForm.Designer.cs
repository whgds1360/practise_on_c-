namespace CarManager
{
    partial class AddRecordForm
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
            label1 = new Label();
            Label56 = new Label();
            Label = new Label();
            label4 = new Label();
            VINTextBox = new TextBox();
            MadeTextBox = new TextBox();
            ModelTextBox = new TextBox();
            CostTextBox = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "VIN";
            // 
            // Label56
            // 
            Label56.AutoSize = true;
            Label56.Location = new Point(15, 36);
            Label56.Name = "Label56";
            Label56.Size = new Size(66, 15);
            Label56.TabIndex = 1;
            Label56.Text = "Произв-ль";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(250, 7);
            Label.Name = "Label";
            Label.Size = new Size(50, 15);
            Label.TabIndex = 2;
            Label.Text = "Модель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 36);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Стоимость";
            // 
            // VINTextBox
            // 
            VINTextBox.Location = new Point(47, 4);
            VINTextBox.MaxLength = 17;
            VINTextBox.Name = "VINTextBox";
            VINTextBox.Size = new Size(184, 23);
            VINTextBox.TabIndex = 4;
            // 
            // MadeTextBox
            // 
            MadeTextBox.Location = new Point(87, 33);
            MadeTextBox.MaxLength = 17;
            MadeTextBox.Name = "MadeTextBox";
            MadeTextBox.Size = new Size(140, 23);
            MadeTextBox.TabIndex = 5;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(299, 4);
            ModelTextBox.MaxLength = 17;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(103, 23);
            ModelTextBox.TabIndex = 6;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(323, 33);
            CostTextBox.MaxLength = 17;
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(445, 7);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(89, 55);
            AddButton.TabIndex = 8;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += CreateData;
            // 
            // RecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 74);
            Controls.Add(AddButton);
            Controls.Add(CostTextBox);
            Controls.Add(ModelTextBox);
            Controls.Add(MadeTextBox);
            Controls.Add(VINTextBox);
            Controls.Add(label4);
            Controls.Add(Label);
            Controls.Add(Label56);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordForm";
            Text = "RecordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label56;
        private Label Label;
        private Label label4;
        private TextBox VINTextBox;
        private TextBox MadeTextBox;
        private TextBox ModelTextBox;
        private TextBox CostTextBox;
        private Button AddButton;
    }
}