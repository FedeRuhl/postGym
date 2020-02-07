namespace Gimnasio
{
    partial class ConsultasDetallesPerfil
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
            this.gimnasioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unirPersonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaDataSet = new Gimnasio.unirPersonaDataSet();
            this.gimnasioDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.unirPersonaTableAdapter = new Gimnasio.unirPersonaDataSetTableAdapters.unirPersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.listBox1.DataSource = this.unirPersonaBindingSource1;
            this.listBox1.DisplayMember = "fecha";
            this.listBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(64, 90);
            this.listBox1.Size = new System.Drawing.Size(445, 148);
            this.listBox1.ValueMember = "fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(245, 244);
            this.btnBuscar.Size = new System.Drawing.Size(79, 28);
            // 
            // lblFechaConsultas
            // 
            this.lblFechaConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaConsultas.ForeColor = System.Drawing.Color.White;
            this.lblFechaConsultas.Location = new System.Drawing.Point(59, 46);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeight = 45;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonaDataGridViewTextBoxColumn,
            this.idDetallesDataGridViewTextBoxColumn,
            this.nombrePersonaDataGridViewTextBoxColumn,
            this.alturaPersonaDataGridViewTextBoxColumn,
            this.pesoPersonaDataGridViewTextBoxColumn,
            this.fotoPersonaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.unirPersonaBindingSource1;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView3.Location = new System.Drawing.Point(12, 297);
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
            this.dataGridView3.Size = new System.Drawing.Size(996, 371);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            this.dataGridView3.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellEnter);
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
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            this.nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "nombrePersona";
            this.nombrePersonaDataGridViewTextBoxColumn.HeaderText = "nombrePersona";
            this.nombrePersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            this.nombrePersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePersonaDataGridViewTextBoxColumn.Width = 174;
            // 
            // alturaPersonaDataGridViewTextBoxColumn
            // 
            this.alturaPersonaDataGridViewTextBoxColumn.DataPropertyName = "alturaPersona";
            this.alturaPersonaDataGridViewTextBoxColumn.HeaderText = "alturaPersona";
            this.alturaPersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alturaPersonaDataGridViewTextBoxColumn.Name = "alturaPersonaDataGridViewTextBoxColumn";
            this.alturaPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alturaPersonaDataGridViewTextBoxColumn.Width = 153;
            // 
            // pesoPersonaDataGridViewTextBoxColumn
            // 
            this.pesoPersonaDataGridViewTextBoxColumn.DataPropertyName = "pesoPersona";
            this.pesoPersonaDataGridViewTextBoxColumn.HeaderText = "pesoPersona";
            this.pesoPersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pesoPersonaDataGridViewTextBoxColumn.Name = "pesoPersonaDataGridViewTextBoxColumn";
            this.pesoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoPersonaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fotoPersonaDataGridViewTextBoxColumn
            // 
            this.fotoPersonaDataGridViewTextBoxColumn.DataPropertyName = "fotoPersona";
            this.fotoPersonaDataGridViewTextBoxColumn.HeaderText = "fotoPersona";
            this.fotoPersonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fotoPersonaDataGridViewTextBoxColumn.Name = "fotoPersonaDataGridViewTextBoxColumn";
            this.fotoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fotoPersonaDataGridViewTextBoxColumn.Width = 138;
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
            // unirPersonaBindingSource1
            // 
            this.unirPersonaBindingSource1.DataMember = "unirPersona";
            this.unirPersonaBindingSource1.DataSource = this.unirPersonaDataSetBindingSource;
            // 
            // unirPersonaDataSetBindingSource
            // 
            this.unirPersonaDataSetBindingSource.DataSource = this.unirPersonaDataSet;
            this.unirPersonaDataSetBindingSource.Position = 0;
            // 
            // unirPersonaDataSet
            // 
            this.unirPersonaDataSet.DataSetName = "unirPersonaDataSet";
            this.unirPersonaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unirPersonaBindingSource
            // 
            this.unirPersonaBindingSource.DataMember = "unirPersona";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(414, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "CALCULAR IMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(693, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // unirPersonaTableAdapter
            // 
            this.unirPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultasDetallesPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1031, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "ConsultasDetallesPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasPersona";
            this.Load += new System.EventHandler(this.ConsultasPersona_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblFechaConsultas, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource;
       // private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource1;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource2;
        private System.Windows.Forms.BindingSource unirPersonaBindingSource;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource3;
        private System.Windows.Forms.BindingSource unirPersonaDSBindingSource;
        private System.Windows.Forms.BindingSource tablaPersonaDSBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource unirPersonaDataSetBindingSource;
        private unirPersonaDataSet unirPersonaDataSet;
        private System.Windows.Forms.BindingSource unirPersonaBindingSource1;
        private unirPersonaDataSetTableAdapters.unirPersonaTableAdapter unirPersonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}