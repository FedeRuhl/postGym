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
            this.gimnasioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gimnasioDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.unirPersonaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(64, 75);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(182, 301);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(600, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(284, 301);
            // 
            // tablaDetallesBindingSource
            // 
            this.tablaDetallesBindingSource.DataMember = "tablaDetalles";
            this.tablaDetallesBindingSource.DataSource = this.gimnasioDataSetBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(64, 370);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(842, 390);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            this.dataGridView3.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellEnter);
            // 
            // unirPersonaBindingSource
            // 
            this.unirPersonaBindingSource.DataMember = "unirPersona";
            // 
            // ConsultasPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 822);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ConsultasPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasPersona";
            this.Load += new System.EventHandler(this.ConsultasPersona_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblFechaConsultas, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unirPersonaDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaDSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource;
        private System.Windows.Forms.BindingSource tablaDetallesBindingSource;
       // private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource1;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource2;
        private System.Windows.Forms.BindingSource unirPersonaBindingSource;
        private System.Windows.Forms.BindingSource gimnasioDataSetBindingSource3;
        private System.Windows.Forms.BindingSource unirPersonaDSBindingSource;
        private System.Windows.Forms.BindingSource tablaPersonaDSBindingSource;
    }
}