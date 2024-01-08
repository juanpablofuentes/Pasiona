namespace WFDataGrid
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
            dataGridCursos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoBindingSource = new BindingSource(components);
            dataGridAlumnos = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alumnosBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCursos
            // 
            dataGridCursos.AutoGenerateColumns = false;
            dataGridCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCursos.Columns.AddRange(new DataGridViewColumn[] { Column1, tituloDataGridViewTextBoxColumn, creditosDataGridViewTextBoxColumn });
            dataGridCursos.DataSource = cursoBindingSource;
            dataGridCursos.Dock = DockStyle.Fill;
            dataGridCursos.Location = new Point(0, 0);
            dataGridCursos.Name = "dataGridCursos";
            dataGridCursos.RowHeadersWidth = 51;
            dataGridCursos.RowTemplate.Height = 29;
            dataGridCursos.Size = new Size(440, 357);
            dataGridCursos.TabIndex = 0;
            dataGridCursos.SelectionChanged += dataGridCursos_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
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
            cursoBindingSource.DataSource = typeof(TestDatos.Curso);
            cursoBindingSource.CurrentChanged += cursoBindingSource_CurrentChanged;
            // 
            // dataGridAlumnos
            // 
            dataGridAlumnos.AutoGenerateColumns = false;
            dataGridAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAlumnos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dataGridAlumnos.DataSource = alumnosBindingSource;
            dataGridAlumnos.Dock = DockStyle.Fill;
            dataGridAlumnos.Location = new Point(0, 0);
            dataGridAlumnos.Name = "dataGridAlumnos";
            dataGridAlumnos.RowHeadersWidth = 51;
            dataGridAlumnos.RowTemplate.Height = 29;
            dataGridAlumnos.Size = new Size(356, 357);
            dataGridAlumnos.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Código";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnosBindingSource
            // 
            alumnosBindingSource.DataMember = "Alumnos";
            alumnosBindingSource.DataSource = cursoBindingSource;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridCursos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridAlumnos);
            splitContainer1.Size = new Size(800, 357);
            splitContainer1.SplitterDistance = 440;
            splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(357, 363);
            button1.Name = "button1";
            button1.Size = new Size(169, 47);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCursos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private BindingSource cursoBindingSource;
        private DataGridView dataGridAlumnos;
        private SplitContainer splitContainer1;
        private BindingSource alumnosBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}