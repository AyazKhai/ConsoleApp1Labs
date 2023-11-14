namespace Lab_7
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
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            TimeLabel = new Label();
            domainUpDown1 = new DomainUpDown();
            QueueNText = new TextBox();
            button2 = new Button();
            DirectChoose = new CheckBox();
            sort_button = new Button();
            Shaker = new CheckBox();
            Shall = new CheckBox();
            Bubby = new CheckBox();
            DirectConnection = new CheckBox();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(1, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox2);
            splitContainer1.Size = new Size(594, 414);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(194, 414);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(390, 414);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem1 });
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(65, 20);
            оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            оПрограммеToolStripMenuItem1.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem1.Text = "О программе";
            оПрограммеToolStripMenuItem1.Click += оПрограммеToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TimeLabel);
            panel1.Controls.Add(domainUpDown1);
            panel1.Controls.Add(QueueNText);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(DirectChoose);
            panel1.Controls.Add(sort_button);
            panel1.Controls.Add(Shaker);
            panel1.Controls.Add(Shall);
            panel1.Controls.Add(Bubby);
            panel1.Controls.Add(DirectConnection);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 426);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 411);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 17;
            label1.Text = "Время сортировки: ";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(162, 411);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(13, 15);
            TimeLabel.TabIndex = 16;
            TimeLabel.Text = "0";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("id");
            domainUpDown1.Items.Add("Firm");
            domainUpDown1.Location = new Point(51, 259);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 15;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // QueueNText
            // 
            QueueNText.Location = new Point(51, 307);
            QueueNText.Name = "QueueNText";
            QueueNText.Size = new Size(100, 23);
            QueueNText.TabIndex = 14;
            QueueNText.Text = "0\r\n";
            QueueNText.MouseClick += QueueNText_MouseClick;
            QueueNText.TextChanged += QueueNText_TextChanged;
            QueueNText.KeyPress += QueueNText_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(51, 336);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 13;
            button2.Text = "Создать объект";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DirectChoose
            // 
            DirectChoose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DirectChoose.AutoSize = true;
            DirectChoose.Location = new Point(23, 23);
            DirectChoose.Name = "DirectChoose";
            DirectChoose.Size = new Size(97, 19);
            DirectChoose.TabIndex = 7;
            DirectChoose.Text = "DirectChoose";
            DirectChoose.UseVisualStyleBackColor = true;
            DirectChoose.CheckedChanged += DirectChooseId_CheckedChanged;
            // 
            // sort_button
            // 
            sort_button.Location = new Point(51, 230);
            sort_button.Name = "sort_button";
            sort_button.Size = new Size(100, 23);
            sort_button.TabIndex = 12;
            sort_button.Text = "Сортировать";
            sort_button.UseVisualStyleBackColor = true;
            sort_button.Click += sort_button_Click;
            // 
            // Shaker
            // 
            Shaker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Shaker.AutoSize = true;
            Shaker.Location = new Point(23, 98);
            Shaker.Name = "Shaker";
            Shaker.Size = new Size(61, 19);
            Shaker.TabIndex = 10;
            Shaker.Text = "Shaker";
            Shaker.UseVisualStyleBackColor = true;
            Shaker.CheckedChanged += Shaker_CheckedChanged;
            // 
            // Shall
            // 
            Shall.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Shall.AutoSize = true;
            Shall.Location = new Point(23, 123);
            Shall.Name = "Shall";
            Shall.Size = new Size(51, 19);
            Shall.TabIndex = 11;
            Shall.Text = "Shall";
            Shall.UseVisualStyleBackColor = true;
            Shall.CheckedChanged += Shall_CheckedChanged;
            // 
            // Bubby
            // 
            Bubby.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Bubby.AutoSize = true;
            Bubby.Location = new Point(23, 48);
            Bubby.Name = "Bubby";
            Bubby.Size = new Size(60, 19);
            Bubby.TabIndex = 8;
            Bubby.Text = "Bubby";
            Bubby.UseVisualStyleBackColor = true;
            Bubby.CheckedChanged += Bubby_CheckedChanged;
            // 
            // DirectConnection
            // 
            DirectConnection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DirectConnection.AutoSize = true;
            DirectConnection.Location = new Point(23, 73);
            DirectConnection.Name = "DirectConnection";
            DirectConnection.Size = new Size(119, 19);
            DirectConnection.TabIndex = 9;
            DirectConnection.Text = "DirectConnection";
            DirectConnection.UseVisualStyleBackColor = true;
            DirectConnection.CheckedChanged += DirectConnection_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Panel panel1;
        private TextBox QueueNText;
        private Button button2;
        private CheckBox DirectChoose;
        private CheckBox Shaker;
        private CheckBox Shall;
        private CheckBox Bubby;
        private CheckBox DirectConnection;
        private DomainUpDown domainUpDown1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Button sort_button;
        private Label TimeLabel;
        private Label label1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
    }
}