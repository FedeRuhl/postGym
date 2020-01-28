namespace Gimnasio
{
    partial class ConsultasPerfiles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaDataSet = new Gimnasio.PersonaDataSet();
            this.tablaPersonaTableAdapter = new Gimnasio.PersonaDataSetTableAdapters.tablaPersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 401);
            this.btnSalir.Size = new System.Drawing.Size(96, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonaDataGridViewTextBoxColumn,
            this.nombrePersonaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablaPersonaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            this.idPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            this.nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "nombrePersona";
            this.nombrePersonaDataGridViewTextBoxColumn.HeaderText = "nombrePersona";
            this.nombrePersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            this.nombrePersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePersonaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablaPersonaBindingSource
            // 
            this.tablaPersonaBindingSource.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource.DataSource = this.personaDataSet;
            // 
            // personaDataSet
            // 
            this.personaDataSet.DataSetName = "PersonaDataSet";
            this.personaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaPersonaTableAdapter
            // 
            this.tablaPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultasPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultasPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasPerfiles";
            this.Load += new System.EventHandler(this.ConsultasPerfiles_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonaDataSet personaDataSet;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource;
        private PersonaDataSetTableAdapters.tablaPersonaTableAdapter tablaPersonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
    }
}