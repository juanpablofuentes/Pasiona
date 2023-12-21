namespace TestDatos
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoBindingSource = new BindingSource(components);
            button1 = new Button();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alumnosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, creditosDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cursoBindingSource;
            dataGridView1.Location = new Point(60, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(363, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            creditosDataGridViewTextBoxColumn.DataPropertyName = "Creditos";
            creditosDataGridViewTextBoxColumn.HeaderText = "Creditos";
            creditosDataGridViewTextBoxColumn.MinimumWidth = 6;
            creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            creditosDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Curso);
            // 
            // button1
            // 
            button1.Location = new Point(415, 361);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nombreDataGridViewTextBoxColumn, cursoIdDataGridViewTextBoxColumn, cursoDataGridViewTextBoxColumn });
            dataGridView2.DataSource = alumnosBindingSource;
            dataGridView2.Location = new Point(473, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(295, 312);
            dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursoIdDataGridViewTextBoxColumn
            // 
            cursoIdDataGridViewTextBoxColumn.DataPropertyName = "CursoId";
            cursoIdDataGridViewTextBoxColumn.HeaderText = "CursoId";
            cursoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            cursoIdDataGridViewTextBoxColumn.Name = "cursoIdDataGridViewTextBoxColumn";
            cursoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            cursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            cursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnosBindingSource
            // 
            alumnosBindingSource.DataMember = "Alumnos";
            alumnosBindingSource.DataSource = cursoBindingSource;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private BindingSource cursoBindingSource;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private BindingSource alumnosBindingSource;
    }
}