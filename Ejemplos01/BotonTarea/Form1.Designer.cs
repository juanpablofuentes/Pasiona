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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(246, 51);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 107);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 420);
            textBox1.TabIndex = 1;
            // 
            // tamArray
            // 
            tamArray.Location = new Point(65, 52);
            tamArray.Margin = new Padding(3, 4, 3, 4);
            tamArray.Name = "tamArray";
            tamArray.Size = new Size(114, 27);
            tamArray.TabIndex = 2;
            tamArray.Text = "50000";
            // 
            // button2
            // 
            button2.Location = new Point(433, 52);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 3;
            button2.Text = "Añade texto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 107);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 31);
            button3.TabIndex = 4;
            button3.Text = "Mensaje";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textRes
            // 
            textRes.Location = new Point(635, 54);
            textRes.Margin = new Padding(3, 4, 3, 4);
            textRes.Multiline = true;
            textRes.Name = "textRes";
            textRes.Size = new Size(254, 620);
            textRes.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(433, 156);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 47);
            button4.TabIndex = 6;
            button4.Text = "Encolar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(433, 244);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(114, 84);
            button5.TabIndex = 7;
            button5.Text = "Procesos paralelos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(431, 353);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(119, 79);
            button6.TabIndex = 8;
            button6.Text = "Añadir elemento";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 705);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textRes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tamArray);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button4;
        private Button button5;
        private Button button6;
    }
}