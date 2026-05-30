namespace CarManager
{
    partial class DataBaseForm
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
            PortLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            DataBasePortTextBox = new TextBox();
            HostLabel = new Label();
            NameOfDataBaseLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            HostTextBox = new TextBox();
            NameDBTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // PortLabel
            // 
            PortLabel.Location = new Point(12, 6);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(54, 21);
            PortLabel.TabIndex = 0;
            PortLabel.Text = "Порт БД";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DataBasePortTextBox
            // 
            DataBasePortTextBox.Location = new Point(98, 3);
            DataBasePortTextBox.Name = "DataBasePortTextBox";
            DataBasePortTextBox.Size = new Size(100, 23);
            DataBasePortTextBox.TabIndex = 2;
            // 
            // HostLabel
            // 
            HostLabel.AutoSize = true;
            HostLabel.Location = new Point(12, 41);
            HostLabel.Name = "HostLabel";
            HostLabel.Size = new Size(32, 15);
            HostLabel.TabIndex = 3;
            HostLabel.Text = "Хост";
            // 
            // NameOfDataBaseLabel
            // 
            NameOfDataBaseLabel.AutoSize = true;
            NameOfDataBaseLabel.Location = new Point(12, 74);
            NameOfDataBaseLabel.Name = "NameOfDataBaseLabel";
            NameOfDataBaseLabel.Size = new Size(49, 15);
            NameOfDataBaseLabel.TabIndex = 4;
            NameOfDataBaseLabel.Text = "Имя БД";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 12);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 41);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // HostTextBox
            // 
            HostTextBox.Location = new Point(98, 33);
            HostTextBox.Name = "HostTextBox";
            HostTextBox.Size = new Size(100, 23);
            HostTextBox.TabIndex = 8;
            // 
            // NameDBTextBox
            // 
            NameDBTextBox.Location = new Point(98, 71);
            NameDBTextBox.Name = "NameDBTextBox";
            NameDBTextBox.Size = new Size(100, 23);
            NameDBTextBox.TabIndex = 9;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(308, 6);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(100, 23);
            UserNameTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(308, 38);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(308, 67);
            button1.Name = "button1";
            button1.Size = new Size(229, 34);
            button1.TabIndex = 12;
            button1.Text = "Подключить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConnectToDataBase;
            // 
            // DataBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 113);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(NameDBTextBox);
            Controls.Add(HostTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameOfDataBaseLabel);
            Controls.Add(HostLabel);
            Controls.Add(DataBasePortTextBox);
            Controls.Add(PortLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataBaseForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PortLabel;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox DataBasePortTextBox;
        private Label HostLabel;
        private Label NameOfDataBaseLabel;
        private Label label3;
        private Label label4;
        private TextBox HostTextBox;
        private TextBox NameDBTextBox;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button button1;
    }
}