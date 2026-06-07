namespace CarManager
{
    partial class SearchForm
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
            SearchButton = new Button();
            label1 = new Label();
            VinTextBox = new TextBox();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(398, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(136, 50);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += Search;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "VIN";
            // 
            // VinTextBox
            // 
            VinTextBox.Location = new Point(64, 22);
            VinTextBox.MaxLength = 19;
            VinTextBox.Name = "VinTextBox";
            VinTextBox.Size = new Size(262, 23);
            VinTextBox.TabIndex = 2;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 74);
            Controls.Add(VinTextBox);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Label label1;
        private TextBox VinTextBox;
    }
}