namespace Gimnasio
{
    partial class CrearRutina
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
            this.lAltura = new System.Windows.Forms.Label();
            this.lDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.clbEjercicios = new System.Windows.Forms.CheckedListBox();
            this.clbDias = new System.Windows.Forms.CheckedListBox();
            this.clbMusculos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lAltura
            // 
            this.lAltura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lAltura.AutoSize = true;
            this.lAltura.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltura.ForeColor = System.Drawing.Color.White;
            this.lAltura.Location = new System.Drawing.Point(458, 155);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(104, 26);
            this.lAltura.TabIndex = 12;
            this.lAltura.Text = "Músculo/s";
            // 
            // lDia
            // 
            this.lDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(249, 155);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(59, 26);
            this.lDia.TabIndex = 11;
            this.lDia.Text = "Día/s";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Elige los ejercicios que trabajaras cada día";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "¡Crea una nueva rutina!";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(348, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ejercicios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(313, 815);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // clbEjercicios
            // 
            this.clbEjercicios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbEjercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.clbEjercicios.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.clbEjercicios.ForeColor = System.Drawing.Color.White;
            this.clbEjercicios.FormattingEnabled = true;
            this.clbEjercicios.Location = new System.Drawing.Point(162, 453);
            this.clbEjercicios.Name = "clbEjercicios";
            this.clbEjercicios.Size = new System.Drawing.Size(488, 356);
            this.clbEjercicios.TabIndex = 17;
            this.clbEjercicios.ThreeDCheckBoxes = true;
            // 
            // clbDias
            // 
            this.clbDias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.clbDias.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.clbDias.ForeColor = System.Drawing.Color.White;
            this.clbDias.FormattingEnabled = true;
            this.clbDias.Location = new System.Drawing.Point(162, 184);
            this.clbDias.Name = "clbDias";
            this.clbDias.Size = new System.Drawing.Size(228, 224);
            this.clbDias.TabIndex = 18;
            this.clbDias.ThreeDCheckBoxes = true;
            // 
            // clbMusculos
            // 
            this.clbMusculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbMusculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.clbMusculos.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.clbMusculos.ForeColor = System.Drawing.Color.White;
            this.clbMusculos.FormattingEnabled = true;
            this.clbMusculos.Location = new System.Drawing.Point(408, 184);
            this.clbMusculos.Name = "clbMusculos";
            this.clbMusculos.Size = new System.Drawing.Size(242, 224);
            this.clbMusculos.TabIndex = 19;
            this.clbMusculos.ThreeDCheckBoxes = true;
            // 
            // CrearRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 853);
            this.Controls.Add(this.clbMusculos);
            this.Controls.Add(this.clbDias);
            this.Controls.Add(this.clbEjercicios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearRutina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearRutina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckedListBox clbEjercicios;
        private System.Windows.Forms.CheckedListBox clbDias;
        private System.Windows.Forms.CheckedListBox clbMusculos;
    }
}