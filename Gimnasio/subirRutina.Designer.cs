namespace Gimnasio
{
    partial class subirRutina
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
            this.btnGuardarEjercicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.unirEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tablaPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaDataSet = new Gimnasio.PersonaDataSet();
            this.tablaPersonaTableAdapter = new Gimnasio.PersonaDataSetTableAdapters.tablaPersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesEjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarEjercicio
            // 
            this.btnGuardarEjercicio.Location = new System.Drawing.Point(462, 156);
            this.btnGuardarEjercicio.Name = "btnGuardarEjercicio";
            this.btnGuardarEjercicio.Size = new System.Drawing.Size(105, 33);
            this.btnGuardarEjercicio.TabIndex = 2;
            this.btnGuardarEjercicio.Text = "Guardar";
            this.btnGuardarEjercicio.UseVisualStyleBackColor = true;
            this.btnGuardarEjercicio.Click += new System.EventHandler(this.btnGuardarEjercicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Indique los datos correspondientes a su ejercicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ejercicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // unirEjercicioBindingSource
            // 
            this.unirEjercicioBindingSource.DataMember = "unirEjercicio";
            this.unirEjercicioBindingSource.DataSource = this.detallesEjercicioBindingSource;
            // 
            // tablaDetallesBindingSource
            // 
            this.tablaDetallesBindingSource.DataMember = "tablaDetalles";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.unirEjercicioBindingSource;
            this.comboBox1.DisplayMember = "nombreEjercicio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar serie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(12, 242);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(56, 26);
            this.labelPeso.TabIndex = 22;
            this.labelPeso.Text = "Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Persona:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tablaPersonaBindingSource;
            this.comboBox2.DisplayMember = "nombrePersona";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 24);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "nombrePersona";
            // 
            // tablaPersonaBindingSource
            // 
            this.tablaPersonaBindingSource.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource.DataSource = this.personaDataSet;
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
            // subirRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarEjercicio);
            this.Name = "subirRutina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "subirRutina";
            this.Load += new System.EventHandler(this.SubirRutina_Load);
            this.Controls.SetChildIndex(this.btnGuardarEjercicio, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.labelPeso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource tablaDetallesBindingSource;
        private System.Windows.Forms.BindingSource detallesEjercicioBindingSource;
        private System.Windows.Forms.BindingSource unirEjercicioBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private PersonaDataSet personaDataSet;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource;
        private PersonaDataSetTableAdapters.tablaPersonaTableAdapter tablaPersonaTableAdapter;
    }
}