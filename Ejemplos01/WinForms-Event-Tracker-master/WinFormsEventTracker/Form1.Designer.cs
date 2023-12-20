namespace WinFormsEventTracker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyboard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test keyboard events here:";
            // 
            // textBoxKeyboard
            // 
            this.textBoxKeyboard.Location = new System.Drawing.Point(157, 13);
            this.textBoxKeyboard.Name = "textBoxKeyboard";
            this.textBoxKeyboard.Size = new System.Drawing.Size(631, 20);
            this.textBoxKeyboard.TabIndex = 1;
            this.textBoxKeyboard.TextChanged += new System.EventHandler(this.textBoxKeyboard_TextChanged);
            this.textBoxKeyboard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyboard_KeyDown);
            this.textBoxKeyboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyboard_KeyPress);
            this.textBoxKeyboard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyboard_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test mouse events here:";
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.Location = new System.Drawing.Point(157, 51);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(631, 76);
            this.pictureBoxMouse.TabIndex = 3;
            this.pictureBoxMouse.TabStop = false;
            this.pictureBoxMouse.Click += new System.EventHandler(this.pictureBoxMouse_Click);
            this.pictureBoxMouse.DoubleClick += new System.EventHandler(this.pictureBoxMouse_DoubleClick);
            this.pictureBoxMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMouse_MouseDown);
            this.pictureBoxMouse.MouseEnter += new System.EventHandler(this.pictureBoxMouse_MouseEnter);
            this.pictureBoxMouse.MouseLeave += new System.EventHandler(this.pictureBoxMouse_MouseLeave);
            this.pictureBoxMouse.MouseHover += new System.EventHandler(this.pictureBoxMouse_MouseHover);
            this.pictureBoxMouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMouse_MouseUp);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 141);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(776, 303);
            this.listBoxLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.pictureBoxMouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKeyboard);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WinFormsEventTracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

