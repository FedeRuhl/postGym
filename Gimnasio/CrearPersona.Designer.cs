﻿namespace Gimnasio
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crear persona";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escriba los datos correspondientes a su persona:";
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.txtIdPersona.ForeColor = System.Drawing.Color.White;
            this.txtIdPersona.Location = new System.Drawing.Point(238, 164);
            this.txtIdPersona.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(223, 22);
            this.txtIdPersona.TabIndex = 0;
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPersona.ForeColor = System.Drawing.Color.White;
            this.lblIdPersona.Location = new System.Drawing.Point(20, 160);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(105, 26);
            this.lblIdPersona.TabIndex = 8;
            this.lblIdPersona.Text = "Id persona:";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombrePersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.txtNombrePersona.ForeColor = System.Drawing.Color.White;
            this.txtNombrePersona.Location = new System.Drawing.Point(238, 207);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(223, 22);
            this.txtNombrePersona.TabIndex = 1;
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersona.ForeColor = System.Drawing.Color.White;
            this.lblNombrePersona.Location = new System.Drawing.Point(20, 203);
            this.lblNombrePersona.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(204, 26);
            this.lblNombrePersona.TabIndex = 10;
            this.lblNombrePersona.Text = "Nombre de la persona:";
            // 
            // btnMod
            // 
            this.btnMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMod.Location = new System.Drawing.Point(531, 200);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
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