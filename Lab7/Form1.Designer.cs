namespace Lab7
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            trackBar1 = new TrackBar();
            button2 = new Button();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(51, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(51, 66);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(51, 101);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(51, 137);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(51, 178);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(618, 219);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(624, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 450);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 347);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(30, 381);
            trackBar1.Maximum = 30;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 8;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(38, 283);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 6;
            button2.Text = "Создать объект";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(56, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.Location = new Point(0, 225);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(618, 225);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private TrackBar trackBar1;
    }
}