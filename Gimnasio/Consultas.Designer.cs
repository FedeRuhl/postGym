namespace Gimnasio
{
    partial class Consultas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaConsultas = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tablaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gimnasioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 300);
            this.btnSalir.Size = new System.Drawing.Size(79, 33);
            this.btnSalir.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(133, 300);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblFechaConsultas
            // 
            this.lblFechaConsultas.AutoSize = true;
            this.lblFechaConsultas.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConsultas.Location = new System.Drawing.Point(59, 31);
            this.lblFechaConsultas.Name = "lblFechaConsultas";
            this.lblFechaConsultas.Size = new System.Drawing.Size(139, 26);
            this.lblFechaConsultas.TabIndex = 2;
            this.lblFechaConsultas.Text = "Elija una fecha:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 196);
            this.listBox1.TabIndex = 0;
            // 
            // tablaDetallesBindingSource
            // 
            this.tablaDetallesBindingSource.DataMember = "tablaDetalles";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(236, 300);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(108, 33);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(831, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 143);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1076, 735);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 7;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 680);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblFechaConsultas);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblFechaConsultas, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ListBox listBox1;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Label lblFechaConsultas;
        private System.Windows.Forms.BindingSource tablaDetallesBindingSource;
        protected System.Windows.Forms.Button btnSeleccionar;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource;
    }
}