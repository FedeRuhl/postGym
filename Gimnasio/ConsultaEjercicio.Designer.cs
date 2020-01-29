namespace Gimnasio
{
    partial class ConsultaEjercicio
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idEjercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEjercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaEjercicio = new Gimnasio.tablaEjercicio();
            this.tablaEjercicioTableAdapter = new Gimnasio.tablaEjercicioTableAdapters.tablaEjercicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(232, 395);
            this.btnSalir.Size = new System.Drawing.Size(105, 33);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEjercicioDataGridViewTextBoxColumn,
            this.nombreEjercicioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tablaEjercicioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(75, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(458, 342);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView2_KeyPress);
            // 
            // idEjercicioDataGridViewTextBoxColumn
            // 
            this.idEjercicioDataGridViewTextBoxColumn.DataPropertyName = "idEjercicio";
            this.idEjercicioDataGridViewTextBoxColumn.HeaderText = "idEjercicio";
            this.idEjercicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEjercicioDataGridViewTextBoxColumn.Name = "idEjercicioDataGridViewTextBoxColumn";
            this.idEjercicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEjercicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreEjercicioDataGridViewTextBoxColumn
            // 
            this.nombreEjercicioDataGridViewTextBoxColumn.DataPropertyName = "nombreEjercicio";
            this.nombreEjercicioDataGridViewTextBoxColumn.HeaderText = "nombreEjercicio";
            this.nombreEjercicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreEjercicioDataGridViewTextBoxColumn.Name = "nombreEjercicioDataGridViewTextBoxColumn";
            this.nombreEjercicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEjercicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablaEjercicioBindingSource
            // 
            this.tablaEjercicioBindingSource.DataMember = "tablaEjercicio";
            this.tablaEjercicioBindingSource.DataSource = this.tablaEjercicio;
            // 
            // tablaEjercicio
            // 
            this.tablaEjercicio.DataSetName = "tablaEjercicio";
            this.tablaEjercicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaEjercicioTableAdapter
            // 
            this.tablaEjercicioTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 448);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ConsultaEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEjercicio";
            this.Load += new System.EventHandler(this.ConsultaEjercicio_Load);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private tablaEjercicio tablaEjercicio;
        private System.Windows.Forms.BindingSource tablaEjercicioBindingSource;
        private tablaEjercicioTableAdapters.tablaEjercicioTableAdapter tablaEjercicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEjercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEjercicioDataGridViewTextBoxColumn;
    }
}