﻿namespace Gimnasio
{
    partial class ActualizarPersona
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
            this.txtPesoPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlturaPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personaDataSet = new Gimnasio.PersonaDataSet();
            this.tablaPersonaBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaTableAdapter = new Gimnasio.PersonaDataSetTableAdapters.tablaPersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(527, 117);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(952, 621);
            this.btnModificar.Size = new System.Drawing.Size(10, 10);
            this.btnModificar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(952, 621);
            this.btnEliminar.Size = new System.Drawing.Size(10, 10);
            this.btnEliminar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(527, 164);
            // 
            // txtPesoPersona
            // 
            this.txtPesoPersona.Location = new System.Drawing.Point(242, 237);
            this.txtPesoPersona.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.txtPesoPersona.Name = "txtPesoPersona";
            this.txtPesoPersona.Size = new System.Drawing.Size(223, 22);
            this.txtPesoPersona.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso de la persona:";
            // 
            // txtAlturaPersona
            // 
            this.txtAlturaPersona.Location = new System.Drawing.Point(242, 181);
            this.txtAlturaPersona.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.txtAlturaPersona.Name = "txtAlturaPersona";
            this.txtAlturaPersona.Size = new System.Drawing.Size(223, 22);
            this.txtAlturaPersona.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Altura de la persona:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Foto de la persona:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre de la persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Actualizar datos correspondientes a la persona";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tablaPersonaBindingSource7;
            this.comboBox1.DisplayMember = "nombrePersona";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 66);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(17, 3, 3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "nombrePersona";
            // 
            // tablaPersonaBindingSource6
            // 
            this.tablaPersonaBindingSource6.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource6.DataSource = this.tablaPersonaBindingSource5;
            // 
            // tablaPersonaBindingSource1
            // 
            this.tablaPersonaBindingSource1.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource1.DataSource = this.tablaPersonaBindingSource;
            // 
            // tablaPersonaBindingSource2
            // 
            this.tablaPersonaBindingSource2.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource2.DataSource = this.tablaPersonaBindingSource;
            // 
            // tablaPersonaBindingSource3
            // 
            this.tablaPersonaBindingSource3.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource3.DataSource = this.tablaPersonaBindingSource;
            // 
            // tablaPersonaBindingSource4
            // 
            this.tablaPersonaBindingSource4.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource4.DataSource = this.tablaPersonaBindingSource;
            // 
            // personaDataSet
            // 
            this.personaDataSet.DataSetName = "PersonaDataSet";
            this.personaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaPersonaBindingSource7
            // 
            this.tablaPersonaBindingSource7.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource7.DataSource = this.personaDataSet;
            // 
            // tablaPersonaTableAdapter
            // 
            this.tablaPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // ActualizarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 297);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlturaPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "ActualizarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarPersona";
            this.Load += new System.EventHandler(this.ActualizarPersona_Load_1);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtAlturaPersona, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPesoPersona, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesoPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlturaPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource1;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource2;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource3;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource4;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource6;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource5;
        private System.Windows.Forms.BindingSource tablaPersonaDSBindingSource;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private PersonaDataSet personaDataSet;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource7;
        private PersonaDataSetTableAdapters.tablaPersonaTableAdapter tablaPersonaTableAdapter;
    }
}