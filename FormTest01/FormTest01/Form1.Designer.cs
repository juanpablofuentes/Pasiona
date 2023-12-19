namespace FormTest01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            aaaaaToolStripMenuItem = new ToolStripMenuItem();
            bbbbbToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursoBindingSource = new BindingSource(components);
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(372, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.DragEnter += button1_DragEnter;
            button1.MouseClick += button1_MouseClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Image = (Image)resources.GetObject("linkLabel1.Image");
            linkLabel1.LinkArea = new LinkArea(0, 12);
            linkLabel1.Location = new Point(384, 218);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(144, 21);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1 asdadsasdadas";
            linkLabel1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "aaa", "bbb", "ccc", "ddd", "eee", "fff" });
            textBox1.AutoCompleteMode = AutoCompleteMode.Append;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(319, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { aaaaaToolStripMenuItem, bbbbbToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 48);
            // 
            // aaaaaToolStripMenuItem
            // 
            aaaaaToolStripMenuItem.Name = "aaaaaToolStripMenuItem";
            aaaaaToolStripMenuItem.Size = new Size(109, 22);
            aaaaaToolStripMenuItem.Text = "aaaaa";
            aaaaaToolStripMenuItem.Click += aaaaaToolStripMenuItem_Click;
            // 
            // bbbbbToolStripMenuItem
            // 
            bbbbbToolStripMenuItem.Name = "bbbbbToolStripMenuItem";
            bbbbbToolStripMenuItem.Size = new Size(109, 22);
            bbbbbToolStripMenuItem.Text = "bbbbb";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, creditosDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cursoBindingSource;
            dataGridView1.Location = new Point(43, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(246, 215);
            dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // creditosDataGridViewTextBoxColumn
            // 
            creditosDataGridViewTextBoxColumn.DataPropertyName = "Creditos";
            creditosDataGridViewTextBoxColumn.HeaderText = "Creditos";
            creditosDataGridViewTextBoxColumn.Name = "creditosDataGridViewTextBoxColumn";
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(TestMVC.Models.Curso);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aaaaaToolStripMenuItem;
        private ToolStripMenuItem bbbbbToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditosDataGridViewTextBoxColumn;
        private BindingSource cursoBindingSource;
    }
}