namespace CarManager
{
    partial class SortForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 45);
            button1.Name = "button1";
            button1.Size = new Size(191, 23);
            button1.TabIndex = 0;
            button1.Text = "По возрастанию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SortOrderBy;
            // 
            // button2
            // 
            button2.Location = new Point(344, 45);
            button2.Name = "button2";
            button2.Size = new Size(185, 23);
            button2.TabIndex = 1;
            button2.Text = "По убыванию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SortOrderByDescending;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 2;
            label1.Text = "Сортировка логично по цене";
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 113);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SortForm";
            Text = "SortForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}