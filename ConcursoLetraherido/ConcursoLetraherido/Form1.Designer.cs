namespace ConcursoLetraherido
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
            carpetaPdf = new TextBox();
            carpetaOK = new TextBox();
            label3 = new Label();
            carpetaKO = new TextBox();
            label4 = new Label();
            maxPalabras = new TextBox();
            label5 = new Label();
            fraseBuscar = new TextBox();
            label6 = new Label();
            carpetaStats = new TextBox();
            label7 = new Label();
            button1 = new Button();
            carpetaMaybe = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(703, 42);
            label1.TabIndex = 0;
            label1.Text = "Concurso Letraherido Validator 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 98);
            label2.Name = "label2";
            label2.Size = new Size(70, 13);
            label2.TabIndex = 1;
            label2.Text = "Carpeta pdfs:";
            // 
            // carpetaPdf
            // 
            carpetaPdf.Location = new Point(152, 94);
            carpetaPdf.Name = "carpetaPdf";
            carpetaPdf.Size = new Size(226, 23);
            carpetaPdf.TabIndex = 2;
            carpetaPdf.Text = "c:\\concurso2023";
            // 
            // carpetaOK
            // 
            carpetaOK.Location = new Point(152, 145);
            carpetaOK.Name = "carpetaOK";
            carpetaOK.Size = new Size(226, 23);
            carpetaOK.TabIndex = 4;
            carpetaOK.Text = "c:\\concurso2023\\buenos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 149);
            label3.Name = "label3";
            label3.Size = new Size(44, 13);
            label3.TabIndex = 3;
            label3.Text = "Validos:";
            label3.Click += label3_Click;
            // 
            // carpetaKO
            // 
            carpetaKO.Location = new Point(152, 185);
            carpetaKO.Name = "carpetaKO";
            carpetaKO.Size = new Size(226, 23);
            carpetaKO.TabIndex = 6;
            carpetaKO.Text = "c:\\concurso2023\\malos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 189);
            label4.Name = "label4";
            label4.Size = new Size(52, 13);
            label4.TabIndex = 5;
            label4.Text = "Invalidos:";
            // 
            // maxPalabras
            // 
            maxPalabras.Location = new Point(505, 94);
            maxPalabras.Name = "maxPalabras";
            maxPalabras.Size = new Size(226, 23);
            maxPalabras.TabIndex = 8;
            maxPalabras.Text = "2000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(411, 98);
            label5.Name = "label5";
            label5.Size = new Size(89, 13);
            label5.TabIndex = 7;
            label5.Text = "Palabras máximo:";
            label5.Click += label5_Click;
            // 
            // fraseBuscar
            // 
            fraseBuscar.Location = new Point(505, 145);
            fraseBuscar.Name = "fraseBuscar";
            fraseBuscar.Size = new Size(226, 23);
            fraseBuscar.TabIndex = 10;
            fraseBuscar.Text = "había llegado el ocaso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(411, 149);
            label6.Name = "label6";
            label6.Size = new Size(33, 13);
            label6.TabIndex = 9;
            label6.Text = "Frase";
            label6.Click += label6_Click;
            // 
            // carpetaStats
            // 
            carpetaStats.Location = new Point(505, 189);
            carpetaStats.Name = "carpetaStats";
            carpetaStats.Size = new Size(226, 23);
            carpetaStats.TabIndex = 12;
            carpetaStats.Text = "c:\\concurso2023\\tacada1.csv";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(411, 193);
            label7.Name = "label7";
            label7.Size = new Size(79, 13);
            label7.TabIndex = 11;
            label7.Text = "Excel resultado";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(311, 275);
            button1.Name = "button1";
            button1.Size = new Size(198, 59);
            button1.TabIndex = 13;
            button1.Text = "¡Dale caña!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // carpetaMaybe
            // 
            carpetaMaybe.Location = new Point(152, 231);
            carpetaMaybe.Name = "carpetaMaybe";
            carpetaMaybe.Size = new Size(226, 23);
            carpetaMaybe.TabIndex = 15;
            carpetaMaybe.Text = "c:\\concurso2023\\quizas";
            carpetaMaybe.TextChanged += textBox7_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(58, 235);
            label8.Name = "label8";
            label8.Size = new Size(42, 13);
            label8.TabIndex = 14;
            label8.Text = "Quizás:";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(carpetaMaybe);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(carpetaStats);
            Controls.Add(label7);
            Controls.Add(fraseBuscar);
            Controls.Add(label6);
            Controls.Add(maxPalabras);
            Controls.Add(label5);
            Controls.Add(carpetaKO);
            Controls.Add(label4);
            Controls.Add(carpetaOK);
            Controls.Add(label3);
            Controls.Add(carpetaPdf);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox carpetaPdf;
        private TextBox carpetaOK;
        private Label label3;
        private TextBox carpetaKO;
        private Label label4;
        private TextBox maxPalabras;
        private Label label5;
        private TextBox fraseBuscar;
        private Label label6;
        private TextBox carpetaStats;
        private Label label7;
        private Button button1;
        private TextBox carpetaMaybe;
        private Label label8;
    }
}