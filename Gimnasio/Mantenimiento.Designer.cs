namespace Gimnasio
{
    partial class Mantenimiento
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(538, 240);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.btnSalir.Size = new System.Drawing.Size(118, 30);
            this.btnSalir.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(538, 42);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(538, 108);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(538, 174);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 349);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
    }
}