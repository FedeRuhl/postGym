﻿namespace Gimnasio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unirEjercicioDataSet = new Gimnasio.unirEjercicioDataSet();
            this.unirEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unirEjercicioTableAdapter = new Gimnasio.unirEjercicioDataSetTableAdapters.unirEjercicioTableAdapter();
            this.unirEjercicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nombrePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEjercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEjercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaDePesosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.listBox1.DataSource = this.unirEjercicioBindingSource1;
            this.listBox1.DisplayMember = "fecha";
            this.listBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormatString = "G";
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(264, 93);
            this.listBox1.Size = new System.Drawing.Size(445, 184);
            this.listBox1.ValueMember = "fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(448, 283);
            // 
            // lblFechaConsultas
            // 
            this.lblFechaConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaConsultas.ForeColor = System.Drawing.Color.White;
            this.lblFechaConsultas.Location = new System.Drawing.Point(418, 49);
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
            this.nombrePersonaDataGridViewTextBoxColumn,
            this.idEjercicioDataGridViewTextBoxColumn,
            this.nombreEjercicioDataGridViewTextBoxColumn,
            this.cantidadSeriesDataGridViewTextBoxColumn,
            this.listaDePesosDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.unirEjercicioBindingSource1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(900, 361);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView3_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(55, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 361);
            this.panel1.TabIndex = 5;
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
            // unirEjercicioBindingSource1
            // 
            this.unirEjercicioBindingSource1.DataMember = "unirEjercicio";
            this.unirEjercicioBindingSource1.DataSource = this.unirEjercicioDataSet;
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
            // idEjercicioDataGridViewTextBoxColumn
            // 
            this.idEjercicioDataGridViewTextBoxColumn.DataPropertyName = "idEjercicio";
            this.idEjercicioDataGridViewTextBoxColumn.HeaderText = "idEjercicio";
            this.idEjercicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEjercicioDataGridViewTextBoxColumn.Name = "idEjercicioDataGridViewTextBoxColumn";
            this.idEjercicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEjercicioDataGridViewTextBoxColumn.Width = 126;
            // 
            // nombreEjercicioDataGridViewTextBoxColumn
            // 
            this.nombreEjercicioDataGridViewTextBoxColumn.DataPropertyName = "nombreEjercicio";
            this.nombreEjercicioDataGridViewTextBoxColumn.HeaderText = "nombreEjercicio";
            this.nombreEjercicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreEjercicioDataGridViewTextBoxColumn.Name = "nombreEjercicioDataGridViewTextBoxColumn";
            this.nombreEjercicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEjercicioDataGridViewTextBoxColumn.Width = 177;
            // 
            // cantidadSeriesDataGridViewTextBoxColumn
            // 
            this.cantidadSeriesDataGridViewTextBoxColumn.DataPropertyName = "cantidadSeries";
            this.cantidadSeriesDataGridViewTextBoxColumn.HeaderText = "cantidadSeries";
            this.cantidadSeriesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadSeriesDataGridViewTextBoxColumn.Name = "cantidadSeriesDataGridViewTextBoxColumn";
            this.cantidadSeriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadSeriesDataGridViewTextBoxColumn.Width = 162;
            // 
            // listaDePesosDataGridViewTextBoxColumn
            // 
            this.listaDePesosDataGridViewTextBoxColumn.DataPropertyName = "Lista de pesos";
            this.listaDePesosDataGridViewTextBoxColumn.HeaderText = "Lista de pesos";
            this.listaDePesosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listaDePesosDataGridViewTextBoxColumn.Name = "listaDePesosDataGridViewTextBoxColumn";
            this.listaDePesosDataGridViewTextBoxColumn.ReadOnly = true;
            this.listaDePesosDataGridViewTextBoxColumn.Width = 158;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaDataGridViewTextBoxColumn.Width = 84;
            // 
            // ConsultasDetallesEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1035, 734);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultasDetallesEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasEjercicios";
            this.Load += new System.EventHandler(this.ConsultasEjercicios_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblFechaConsultas, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private unirEjercicioDataSet unirEjercicioDataSet;
        private System.Windows.Forms.BindingSource unirEjercicioBindingSource;
        private unirEjercicioDataSetTableAdapters.unirEjercicioTableAdapter unirEjercicioTableAdapter;
        private System.Windows.Forms.BindingSource unirEjercicioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEjercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEjercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaDePesosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}