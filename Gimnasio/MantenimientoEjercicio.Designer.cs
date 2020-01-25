namespace Gimnasio
{
    partial class MantenimientoEjercicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdEjercicio = new System.Windows.Forms.Label();
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.txtIdEjercicio = new System.Windows.Forms.TextBox();
            this.txtNombreEjercicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(561, 76);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 33, 15, 3);
            this.btnAgregar.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(561, 208);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 33, 15, 3);
            this.btnModificar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(561, 142);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 33, 15, 3);
            this.btnEliminar.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(561, 274);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 33, 15, 3);
            this.btnSalir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escriba los datos correspondientes a su ejercicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mantenimiento ejercicio";
            // 
            // lblIdEjercicio
            // 
            this.lblIdEjercicio.AutoSize = true;
            this.lblIdEjercicio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEjercicio.Location = new System.Drawing.Point(29, 149);
            this.lblIdEjercicio.Name = "lblIdEjercicio";
            this.lblIdEjercicio.Size = new System.Drawing.Size(108, 26);
            this.lblIdEjercicio.TabIndex = 5;
            this.lblIdEjercicio.Text = "Id ejercicio:";
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEjercicio.Location = new System.Drawing.Point(29, 208);
            this.lblNombreEjercicio.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(161, 26);
            this.lblNombreEjercicio.TabIndex = 6;
            this.lblNombreEjercicio.Text = "Nombre ejercicio:";
            // 
            // txtIdEjercicio
            // 
            this.txtIdEjercicio.Location = new System.Drawing.Point(211, 152);
            this.txtIdEjercicio.Name = "txtIdEjercicio";
            this.txtIdEjercicio.Size = new System.Drawing.Size(223, 22);
            this.txtIdEjercicio.TabIndex = 0;
            // 
            // txtNombreEjercicio
            // 
            this.txtNombreEjercicio.Location = new System.Drawing.Point(211, 211);
            this.txtNombreEjercicio.Name = "txtNombreEjercicio";
            this.txtNombreEjercicio.Size = new System.Drawing.Size(223, 22);
            this.txtNombreEjercicio.TabIndex = 1;
            // 
            // MantenimientoEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 361);
            this.Controls.Add(this.txtNombreEjercicio);
            this.Controls.Add(this.txtIdEjercicio);
            this.Controls.Add(this.lblNombreEjercicio);
            this.Controls.Add(this.lblIdEjercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento ejercicio";
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblIdEjercicio, 0);
            this.Controls.SetChildIndex(this.lblNombreEjercicio, 0);
            this.Controls.SetChildIndex(this.txtIdEjercicio, 0);
            this.Controls.SetChildIndex(this.txtNombreEjercicio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdEjercicio;
        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.TextBox txtIdEjercicio;
        private System.Windows.Forms.TextBox txtNombreEjercicio;
    }
}