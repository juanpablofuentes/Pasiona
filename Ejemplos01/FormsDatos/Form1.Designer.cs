namespace FormsDatos
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
            targetModelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            upOperationsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            downOperationsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activeProviderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inicialBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inicialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { targetModelDataGridViewTextBoxColumn, upOperationsDataGridViewTextBoxColumn, downOperationsDataGridViewTextBoxColumn, activeProviderDataGridViewTextBoxColumn });
            dataGridView1.DataSource = inicialBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(329, 311);
            dataGridView1.TabIndex = 0;
            // 
            // targetModelDataGridViewTextBoxColumn
            // 
            targetModelDataGridViewTextBoxColumn.DataPropertyName = "TargetModel";
            targetModelDataGridViewTextBoxColumn.HeaderText = "TargetModel";
            targetModelDataGridViewTextBoxColumn.Name = "targetModelDataGridViewTextBoxColumn";
            targetModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // upOperationsDataGridViewTextBoxColumn
            // 
            upOperationsDataGridViewTextBoxColumn.DataPropertyName = "UpOperations";
            upOperationsDataGridViewTextBoxColumn.HeaderText = "UpOperations";
            upOperationsDataGridViewTextBoxColumn.Name = "upOperationsDataGridViewTextBoxColumn";
            upOperationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // downOperationsDataGridViewTextBoxColumn
            // 
            downOperationsDataGridViewTextBoxColumn.DataPropertyName = "DownOperations";
            downOperationsDataGridViewTextBoxColumn.HeaderText = "DownOperations";
            downOperationsDataGridViewTextBoxColumn.Name = "downOperationsDataGridViewTextBoxColumn";
            downOperationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeProviderDataGridViewTextBoxColumn
            // 
            activeProviderDataGridViewTextBoxColumn.DataPropertyName = "ActiveProvider";
            activeProviderDataGridViewTextBoxColumn.HeaderText = "ActiveProvider";
            activeProviderDataGridViewTextBoxColumn.Name = "activeProviderDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inicialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn targetModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn upOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn downOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activeProviderDataGridViewTextBoxColumn;
        private BindingSource inicialBindingSource;
        private BindingSource bindingSource1;
    }
}