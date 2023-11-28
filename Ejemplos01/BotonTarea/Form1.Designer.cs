namespace BotonTarea
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
            button1 = new Button();
            textBox1 = new TextBox();
            tamArray = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textRes = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 316);
            textBox1.TabIndex = 1;
            // 
            // tamArray
            // 
            tamArray.Location = new Point(57, 39);
            tamArray.Name = "tamArray";
            tamArray.Size = new Size(100, 23);
            tamArray.TabIndex = 2;
            tamArray.Text = "50000";
            // 
            // button2
            // 
            button2.Location = new Point(379, 39);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 3;
            button2.Text = "Añade texto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(379, 80);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 4;
            button3.Text = "Mensaje";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textRes
            // 
            textRes.Location = new Point(583, 61);
            textRes.Multiline = true;
            textRes.Name = "textRes";
            textRes.Size = new Size(100, 335);
            textRes.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textRes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tamArray);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox tamArray;
        private Button button2;
        private Button button3;
        private TextBox textRes;
    }
}