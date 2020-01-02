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
            this.lblCantSeries = new System.Windows.Forms.Label();
            this.txtCantidadSeries = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unirEjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesEjercicioBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(462, 182);
            this.btnSalir.Size = new System.Drawing.Size(105, 33);
            // 
            // btnGuardarEjercicio
            // 
            this.btnGuardarEjercicio.Location = new System.Drawing.Point(462, 131);
            this.btnGuardarEjercicio.Name = "btnGuardarEjercicio";
            this.btnGuardarEjercicio.Size = new System.Drawing.Size(105, 33);
            this.btnGuardarEjercicio.TabIndex = 2;
            this.btnGuardarEjercicio.Text = "Guardar";
            this.btnGuardarEjercicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Indique los datos correspondientes a su ejercicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
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
            this.label7.Location = new System.Drawing.Point(12, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // unirEjercicioBindingSource
            // 
            this.unirEjercicioBindingSource.DataMember = "unirEjercicio";
            this.unirEjercicioBindingSource.DataSource = this.detallesEjercicioBindingSource;
            // 
            // detallesEjercicioBindingSource
            // 
            this.detallesEjercicioBindingSource.Position = 0;
            // 
            // detallesEjercicio
            // 
           
            // 
            // gimnasioDataSet
            // 
            
            // 
            // tablaDetallesBindingSource
            // 
            this.tablaDetallesBindingSource.DataMember = "tablaDetalles";

            // 
            // tablaDetallesTableAdapter
            // 

            // 
            // unirEjercicioTableAdapter
            // 

            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.unirEjercicioBindingSource;
            this.comboBox1.DisplayMember = "nombreEjercicio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // lblCantSeries
            // 
            this.lblCantSeries.AutoSize = true;
            this.lblCantSeries.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantSeries.Location = new System.Drawing.Point(12, 189);
            this.lblCantSeries.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lblCantSeries.Name = "lblCantSeries";
            this.lblCantSeries.Size = new System.Drawing.Size(171, 26);
            this.lblCantSeries.TabIndex = 19;
            this.lblCantSeries.Text = "Cantidad de series:";
            // 
            // txtCantidadSeries
            // 
            this.txtCantidadSeries.Location = new System.Drawing.Point(262, 193);
            this.txtCantidadSeries.Name = "txtCantidadSeries";
            this.txtCantidadSeries.Size = new System.Drawing.Size(157, 22);
            this.txtCantidadSeries.TabIndex = 18;
            this.txtCantidadSeries.TextChanged += new System.EventHandler(this.TxtCantidadSeries_TextChanged);
            this.txtCantidadSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadSeries_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // subirRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCantSeries);
            this.Controls.Add(this.txtCantidadSeries);
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
            this.Controls.SetChildIndex(this.txtCantidadSeries, 0);
            this.Controls.SetChildIndex(this.lblCantSeries, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
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
        private System.Windows.Forms.Label lblCantSeries;
        private System.Windows.Forms.TextBox txtCantidadSeries;
        private System.Windows.Forms.Button button1;
    }
}