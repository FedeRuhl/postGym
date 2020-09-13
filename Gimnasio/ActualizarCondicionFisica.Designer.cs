namespace Gimnasio
{
    partial class ActualizarCondicionFisica
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
            this.cbPersonas = new System.Windows.Forms.ComboBox();
            this.lPersona = new System.Windows.Forms.Label();
            this.lPeso = new System.Windows.Forms.Label();
            this.lFoto = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lCheck = new System.Windows.Forms.Label();
            this.dtpActualizacion = new System.Windows.Forms.DateTimePicker();
            this.lDiaActualizacion = new System.Windows.Forms.Label();
            this.tbPeso = new Gimnasio.TextBoxPersonalizado();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actualizando condición física";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPersonas
            // 
            this.cbPersonas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbPersonas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbPersonas.ForeColor = System.Drawing.Color.White;
            this.cbPersonas.FormattingEnabled = true;
            this.cbPersonas.Location = new System.Drawing.Point(277, 115);
            this.cbPersonas.Name = "cbPersonas";
            this.cbPersonas.Size = new System.Drawing.Size(223, 28);
            this.cbPersonas.TabIndex = 15;
            // 
            // lPersona
            // 
            this.lPersona.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPersona.AutoSize = true;
            this.lPersona.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPersona.ForeColor = System.Drawing.Color.White;
            this.lPersona.Location = new System.Drawing.Point(334, 86);
            this.lPersona.Name = "lPersona";
            this.lPersona.Size = new System.Drawing.Size(87, 26);
            this.lPersona.TabIndex = 14;
            this.lPersona.Text = "Persona";
            // 
            // lPeso
            // 
            this.lPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPeso.AutoSize = true;
            this.lPeso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeso.ForeColor = System.Drawing.Color.White;
            this.lPeso.Location = new System.Drawing.Point(352, 245);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(55, 26);
            this.lPeso.TabIndex = 20;
            this.lPeso.Text = "Peso";
            // 
            // lFoto
            // 
            this.lFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lFoto.AutoSize = true;
            this.lFoto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFoto.ForeColor = System.Drawing.Color.White;
            this.lFoto.Location = new System.Drawing.Point(351, 324);
            this.lFoto.Name = "lFoto";
            this.lFoto.Size = new System.Drawing.Size(70, 26);
            this.lFoto.TabIndex = 22;
            this.lFoto.Text = "Foto/s";
            this.lFoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(276, 353);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(223, 31);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(245, 418);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 31);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lCheck
            // 
            this.lCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lCheck.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lCheck.ForeColor = System.Drawing.Color.White;
            this.lCheck.Location = new System.Drawing.Point(505, 353);
            this.lCheck.Name = "lCheck";
            this.lCheck.Size = new System.Drawing.Size(38, 31);
            this.lCheck.TabIndex = 25;
            this.lCheck.Text = "✔";
            this.lCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lCheck.Visible = false;
            // 
            // dtpActualizacion
            // 
            this.dtpActualizacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpActualizacion.CalendarForeColor = System.Drawing.Color.White;
            this.dtpActualizacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dtpActualizacion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dtpActualizacion.Location = new System.Drawing.Point(276, 203);
            this.dtpActualizacion.Name = "dtpActualizacion";
            this.dtpActualizacion.Size = new System.Drawing.Size(223, 22);
            this.dtpActualizacion.TabIndex = 27;
            this.dtpActualizacion.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            // 
            // lDiaActualizacion
            // 
            this.lDiaActualizacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDiaActualizacion.AutoSize = true;
            this.lDiaActualizacion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiaActualizacion.ForeColor = System.Drawing.Color.White;
            this.lDiaActualizacion.Location = new System.Drawing.Point(339, 168);
            this.lDiaActualizacion.Name = "lDiaActualizacion";
            this.lDiaActualizacion.Size = new System.Drawing.Size(68, 26);
            this.lDiaActualizacion.TabIndex = 26;
            this.lDiaActualizacion.Text = "Fecha";
            // 
            // tbPeso
            // 
            this.tbPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbPeso.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.tbPeso.ForeColor = System.Drawing.Color.White;
            this.tbPeso.Location = new System.Drawing.Point(276, 274);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(223, 25);
            this.tbPeso.TabIndex = 21;
            this.tbPeso.Text = "Pesaje (kg.)";
            this.tbPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(394, 418);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 31);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ActualizarCondicionFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpActualizacion);
            this.Controls.Add(this.lDiaActualizacion);
            this.Controls.Add(this.lCheck);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lFoto);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lPeso);
            this.Controls.Add(this.cbPersonas);
            this.Controls.Add(this.lPersona);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarCondicionFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarCondicionFisica";
            this.Load += new System.EventHandler(this.ActualizarCondicionFisica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonas;
        private System.Windows.Forms.Label lPersona;
        private System.Windows.Forms.Label lPeso;
        private TextBoxPersonalizado tbPeso;
        private System.Windows.Forms.Label lFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lCheck;
        private System.Windows.Forms.DateTimePicker dtpActualizacion;
        private System.Windows.Forms.Label lDiaActualizacion;
        private System.Windows.Forms.Button btnLimpiar;
    }
}