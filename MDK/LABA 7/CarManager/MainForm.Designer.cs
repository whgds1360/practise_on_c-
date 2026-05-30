namespace CarManager;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panel1 = new Panel();
        menuStrip1 = new MenuStrip();
        бДToolStripMenuItem = new ToolStripMenuItem();
        подключитьБДToolStripMenuItem = new ToolStripMenuItem();
        запToolStripMenuItem = new ToolStripMenuItem();
        новаяЗаписьToolStripMenuItem = new ToolStripMenuItem();
        panel2 = new Panel();
        dataGridView1 = new DataGridView();
        panel3 = new Panel();
        panel4 = new Panel();
        StatusLabel = new Label();
        label1 = new Label();
        panel5 = new Panel();
        toolStrip1 = new ToolStrip();
        toolStripButton1 = new ToolStripButton();
        toolStripButton2 = new ToolStripButton();
        panel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel4.SuspendLayout();
        panel5.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ControlDark;
        panel1.Controls.Add(menuStrip1);
        panel1.Location = new Point(114, 12);
        panel1.Name = "panel1";
        panel1.Size = new Size(98, 33);
        panel1.TabIndex = 0;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { бДToolStripMenuItem, запToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(98, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // бДToolStripMenuItem
        // 
        бДToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { подключитьБДToolStripMenuItem });
        бДToolStripMenuItem.Name = "бДToolStripMenuItem";
        бДToolStripMenuItem.Size = new Size(34, 20);
        бДToolStripMenuItem.Text = "БД";
        // 
        // подключитьБДToolStripMenuItem
        // 
        подключитьБДToolStripMenuItem.Name = "подключитьБДToolStripMenuItem";
        подключитьБДToolStripMenuItem.Size = new Size(162, 22);
        подключитьБДToolStripMenuItem.Text = "Подключить БД";
        подключитьБДToolStripMenuItem.Click += ShowMenuDataBase;
        // 
        // запToolStripMenuItem
        // 
        запToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новаяЗаписьToolStripMenuItem });
        запToolStripMenuItem.Name = "запToolStripMenuItem";
        запToolStripMenuItem.Size = new Size(58, 20);
        запToolStripMenuItem.Text = "Запись";
        // 
        // новаяЗаписьToolStripMenuItem
        // 
        новаяЗаписьToolStripMenuItem.Name = "новаяЗаписьToolStripMenuItem";
        новаяЗаписьToolStripMenuItem.Size = new Size(180, 22);
        новаяЗаписьToolStripMenuItem.Text = "Новая запись";
        новаяЗаписьToolStripMenuItem.Click += ShowMenuRecord;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ControlDark;
        panel2.Controls.Add(dataGridView1);
        panel2.Location = new Point(226, 131);
        panel2.Name = "panel2";
        panel2.Size = new Size(562, 307);
        panel2.TabIndex = 1;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(3, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(556, 301);
        dataGridView1.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ControlDark;
        panel3.Location = new Point(226, 12);
        panel3.Name = "panel3";
        panel3.Size = new Size(562, 113);
        panel3.TabIndex = 2;
        // 
        // panel4
        // 
        panel4.BackColor = SystemColors.ControlDark;
        panel4.Controls.Add(StatusLabel);
        panel4.Controls.Add(label1);
        panel4.Location = new Point(12, 64);
        panel4.Name = "panel4";
        panel4.Size = new Size(200, 374);
        panel4.TabIndex = 3;
        // 
        // StatusLabel
        // 
        StatusLabel.ForeColor = Color.Maroon;
        StatusLabel.Location = new Point(3, 36);
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(194, 27);
        StatusLabel.TabIndex = 1;
        StatusLabel.Text = "Не подключена";
        StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Location = new Point(3, 9);
        label1.Name = "label1";
        label1.Size = new Size(194, 27);
        label1.TabIndex = 0;
        label1.Text = "СТАТУС БД";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel5
        // 
        panel5.BackColor = SystemColors.ControlDark;
        panel5.Controls.Add(toolStrip1);
        panel5.Location = new Point(12, 13);
        panel5.Name = "panel5";
        panel5.Size = new Size(82, 32);
        panel5.TabIndex = 4;
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(82, 25);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(23, 22);
        toolStripButton1.Text = "toolStripButton1";
        // 
        // toolStripButton2
        // 
        toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
        toolStripButton2.ImageTransparentColor = Color.Magenta;
        toolStripButton2.Name = "toolStripButton2";
        toolStripButton2.Size = new Size(23, 22);
        toolStripButton2.Text = "toolStripButton2";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel5);
        Controls.Add(panel4);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        MainMenuStrip = menuStrip1;
        Name = "MainForm";
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel4.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem бДToolStripMenuItem;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private ToolStripMenuItem запToolStripMenuItem;
    private ToolStripMenuItem подключитьБДToolStripMenuItem;
    private ToolStripMenuItem новаяЗаписьToolStripMenuItem;
    private Panel panel5;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButton2;
    private Label label1;
    public static DataGridView dataGridView1;
    public static Label StatusLabel;
}
