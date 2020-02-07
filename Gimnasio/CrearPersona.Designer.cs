namespace Gimnasio
{
    partial class CrearPersona
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(529, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3);
            this.btnAgregar.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(836, 522);
            this.btnModificar.Size = new System.Drawing.Size(10, 10);
            this.btnModificar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(836, 511);
            this.btnEliminar.Size = new System.Drawing.Size(10, 10);
            this.btnEliminar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crear persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escriba los datos correspondientes a su persona:";
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Location = new System.Drawing.Point(243, 160);
            this.txtIdPersona.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(223, 22);
            this.txtIdPersona.TabIndex = 0;
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPersona.Location = new System.Drawing.Point(25, 156);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(105, 26);
            this.lblIdPersona.TabIndex = 8;
            this.lblIdPersona.Text = "Id persona:";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(243, 203);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(223, 22);
            this.txtNombrePersona.TabIndex = 1;
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersona.Location = new System.Drawing.Point(25, 199);
            this.lblNombrePersona.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(204, 26);
            this.lblNombrePersona.TabIndex = 10;
            this.lblNombrePersona.Text = "Nombre de la persona:";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(529, 196);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(118, 30);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // CrearPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 270);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.lblNombrePersona);
            this.Controls.Add(this.txtIdPersona);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear persona";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblIdPersona, 0);
            this.Controls.SetChildIndex(this.txtIdPersona, 0);
            this.Controls.SetChildIndex(this.lblNombrePersona, 0);
            this.Controls.SetChildIndex(this.txtNombrePersona, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnMod, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.Button btnMod;
    }
}