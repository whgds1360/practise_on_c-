namespace CarManager
{
    partial class DelRecordForm
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
            DelTextBox = new TextBox();
            DelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 0;
            label1.Text = "VIN";
            // 
            // DelTextBox
            // 
            DelTextBox.Location = new Point(69, 25);
            DelTextBox.MaxLength = 17;
            DelTextBox.Name = "DelTextBox";
            DelTextBox.Size = new Size(180, 23);
            DelTextBox.TabIndex = 1;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(361, 12);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(173, 50);
            DelButton.TabIndex = 2;
            DelButton.Text = "Удалить";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DeleteData;
            // 
            // DelRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 74);
            Controls.Add(DelButton);
            Controls.Add(DelTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DelRecordForm";
            Text = "DelRecordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DelTextBox;
        private Button DelButton;
    }
}