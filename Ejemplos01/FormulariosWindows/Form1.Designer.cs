namespace FormulariosWindows
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 44);
            label1.Name = "label1";
            label1.Size = new Size(234, 45);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            label1.MouseMove += label1_MouseMove;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Help;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(349, 356);
            label2.Name = "label2";
            label2.Size = new Size(131, 45);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 440);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 490);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(880, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 497);
            button1.TabIndex = 4;
            button1.Text = "Pulsa aquí";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(630, 136);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(68, 138);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 43);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.MouseMove += textBox2_MouseMove;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(96, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 42);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Elegir esto";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Indeterminate;
            checkBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(96, 297);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(168, 42);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Elegir esto";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Indeterminate;
            checkBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(96, 362);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(168, 42);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Elegir esto";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(50, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(49, 105);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(47, 161);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(593, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 217);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Location = new Point(422, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 174);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton7);
            panel2.Controls.Add(radioButton6);
            panel2.Location = new Point(181, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 121);
            panel2.TabIndex = 2;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(27, 79);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(117, 24);
            radioButton7.TabIndex = 1;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(27, 45);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(117, 24);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(41, 78);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(117, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(41, 34);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownWidth = 200;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "aaaa", "bbbb", "cccc", "dddd" });
            comboBox1.Location = new Point(340, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 15;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "aaaab", "bbba", "ccddd", "fffeee" });
            listBox1.Location = new Point(340, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(974, 497);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Esto es mi primer formulario";
            Activated += Form1_Activated;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            MouseMove += Form1_MouseMove;
            Resize += Form1_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Panel panel1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Panel panel2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}