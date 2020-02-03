namespace Gimnasio
{
    partial class ConsultasDetallesEjercicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unirPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaDataSet = new Gimnasio.unirPersonaDataSet();
            this.consultasEjerciciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaTableAdapter = new Gimnasio.unirPersonaDataSetTableAdapters.unirPersonaTableAdapter();
            this.unirEjercicioDataSet = new Gimnasio.unirEjercicioDataSet();
            this.unirEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unirEjercicioTableAdapter = new Gimnasio.unirEjercicioDataSetTableAdapters.unirEjercicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasEjerciciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.listBox1.DataSource = this.unirEjercicioBindingSource;
            this.listBox1.DisplayMember = "fecha";
            this.listBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(64, 81);
            this.listBox1.Size = new System.Drawing.Size(445, 184);
            this.listBox1.ValueMember = "fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(233, 283);
            // 
            // lblFechaConsultas
            // 
            this.lblFechaConsultas.ForeColor = System.Drawing.Color.White;
            this.lblFechaConsultas.Location = new System.Drawing.Point(59, 34);
            // 
            // tablaDetallesBindingSource
            // 
            this.tablaDetallesBindingSource.DataMember = "tablaDetalles";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeight = 45;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonaDataGridViewTextBoxColumn,
            this.idDetallesDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.unirEjercicioBindingSource;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView3.Location = new System.Drawing.Point(35, 347);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(902, 467);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView3_KeyPress);
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            this.idPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonaDataGridViewTextBoxColumn.Width = 123;
            // 
            // idDetallesDataGridViewTextBoxColumn
            // 
            this.idDetallesDataGridViewTextBoxColumn.DataPropertyName = "idDetalles";
            this.idDetallesDataGridViewTextBoxColumn.HeaderText = "idDetalles";
            this.idDetallesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDetallesDataGridViewTextBoxColumn.Name = "idDetallesDataGridViewTextBoxColumn";
            this.idDetallesDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetallesDataGridViewTextBoxColumn.Width = 119;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 84;
            // 
            // unirPersonaBindingSource
            // 
            this.unirPersonaBindingSource.DataMember = "unirPersona";
            this.unirPersonaBindingSource.DataSource = this.unirPersonaDataSet;
            // 
            // unirPersonaDataSet
            // 
            this.unirPersonaDataSet.DataSetName = "unirPersonaDataSet";
            this.unirPersonaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasEjerciciosBindingSource
            // 
            this.consultasEjerciciosBindingSource.DataSource = typeof(Gimnasio.ConsultasDetallesEjercicio);
            // 
            // unirPersonaTableAdapter
            // 
            this.unirPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // unirEjercicioDataSet
            // 
            this.unirEjercicioDataSet.DataSetName = "unirEjercicioDataSet";
            this.unirEjercicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unirEjercicioBindingSource
            // 
            this.unirEjercicioBindingSource.DataMember = "unirEjercicio";
            this.unirEjercicioBindingSource.DataSource = this.unirEjercicioDataSet;
            // 
            // unirEjercicioTableAdapter
            // 
            this.unirEjercicioTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultasDetallesEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(965, 808);
            this.Controls.Add(this.dataGridView3);
            this.Name = "ConsultasDetallesEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasEjercicios";
            this.Load += new System.EventHandler(this.ConsultasEjercicios_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblFechaConsultas, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasEjerciciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tablaDetallesBindingSource;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource consultasEjerciciosBindingSource;
        private unirPersonaDataSet unirPersonaDataSet;
        private System.Windows.Forms.BindingSource unirPersonaBindingSource;
        private unirPersonaDataSetTableAdapters.unirPersonaTableAdapter unirPersonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private unirEjercicioDataSet unirEjercicioDataSet;
        private System.Windows.Forms.BindingSource unirEjercicioBindingSource;
        private unirEjercicioDataSetTableAdapters.unirEjercicioTableAdapter unirEjercicioTableAdapter;
    }
}