namespace Gimnasio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarPersona));
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
            this.tablaPersonaBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.personaDataSet = new Gimnasio.PersonaDataSet();
            this.tablaPersonaTableAdapter = new Gimnasio.PersonaDataSetTableAdapters.tablaPersonaTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesoPersona
            // 
            this.txtPesoPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.txtPesoPersona.ForeColor = System.Drawing.Color.White;
            this.txtPesoPersona.Location = new System.Drawing.Point(252, 350);
            this.txtPesoPersona.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.txtPesoPersona.Name = "txtPesoPersona";
            this.txtPesoPersona.Size = new System.Drawing.Size(223, 22);
            this.txtPesoPersona.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso de la persona:";
            // 
            // txtAlturaPersona
            // 
            this.txtAlturaPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlturaPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.txtAlturaPersona.ForeColor = System.Drawing.Color.White;
            this.txtAlturaPersona.Location = new System.Drawing.Point(252, 294);
            this.txtAlturaPersona.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.txtAlturaPersona.Name = "txtAlturaPersona";
            this.txtAlturaPersona.Size = new System.Drawing.Size(223, 22);
            this.txtAlturaPersona.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Altura de la persona:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(252, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Foto de la persona:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre de la persona:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Actualizar datos correspondientes a la persona";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.comboBox1.DataSource = this.tablaPersonaBindingSource7;
            this.comboBox1.DisplayMember = "nombrePersona";
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 179);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(17, 3, 3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "nombrePersona";
            // 
            // tablaPersonaBindingSource7
            // 
            this.tablaPersonaBindingSource7.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource7.DataSource = this.personaDataSet;
            // 
            // personaDataSet
            // 
            this.personaDataSet.DataSetName = "PersonaDataSet";
            this.personaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaPersonaTableAdapter
            // 
            this.tablaPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(508, 259);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ActualizarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(638, 462);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlturaPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarPersona";
            this.Load += new System.EventHandler(this.ActualizarPersona_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).EndInit();
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
        private PersonaDataSet personaDataSet;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource7;
        private PersonaDataSetTableAdapters.tablaPersonaTableAdapter tablaPersonaTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
    }
}