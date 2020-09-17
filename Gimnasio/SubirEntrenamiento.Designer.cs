namespace Gimnasio
{
    partial class SubirEntrenamiento
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
            this.lPersona = new System.Windows.Forms.Label();
            this.cbPersonas = new System.Windows.Forms.ComboBox();
            this.lDiaEntrenamiento = new System.Windows.Forms.Label();
            this.dtpDiaEntrenamiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbRepOseg = new System.Windows.Forms.ComboBox();
            this.lPesoOrepeticiones = new System.Windows.Forms.Label();
            this.tbCantidadSeries = new System.Windows.Forms.TextBox();
            this.lCantidadSeries = new System.Windows.Forms.Label();
            this.cbEjercicios = new System.Windows.Forms.ComboBox();
            this.lEjercicio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelSubirRutina = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Subir entrenamiento!";
            // 
            // lPersona
            // 
            this.lPersona.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPersona.AutoSize = true;
            this.lPersona.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPersona.ForeColor = System.Drawing.Color.White;
            this.lPersona.Location = new System.Drawing.Point(343, 70);
            this.lPersona.Name = "lPersona";
            this.lPersona.Size = new System.Drawing.Size(87, 26);
            this.lPersona.TabIndex = 12;
            this.lPersona.Text = "Persona";
            // 
            // cbPersonas
            // 
            this.cbPersonas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbPersonas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbPersonas.ForeColor = System.Drawing.Color.White;
            this.cbPersonas.FormattingEnabled = true;
            this.cbPersonas.Location = new System.Drawing.Point(294, 103);
            this.cbPersonas.Name = "cbPersonas";
            this.cbPersonas.Size = new System.Drawing.Size(200, 28);
            this.cbPersonas.TabIndex = 1;
            // 
            // lDiaEntrenamiento
            // 
            this.lDiaEntrenamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDiaEntrenamiento.AutoSize = true;
            this.lDiaEntrenamiento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiaEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.lDiaEntrenamiento.Location = new System.Drawing.Point(280, 148);
            this.lDiaEntrenamiento.Name = "lDiaEntrenamiento";
            this.lDiaEntrenamiento.Size = new System.Drawing.Size(214, 26);
            this.lDiaEntrenamiento.TabIndex = 14;
            this.lDiaEntrenamiento.Text = "¿Qué día entrenaste?";
            // 
            // dtpDiaEntrenamiento
            // 
            this.dtpDiaEntrenamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDiaEntrenamiento.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDiaEntrenamiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dtpDiaEntrenamiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dtpDiaEntrenamiento.Location = new System.Drawing.Point(294, 183);
            this.dtpDiaEntrenamiento.Name = "dtpDiaEntrenamiento";
            this.dtpDiaEntrenamiento.Size = new System.Drawing.Size(200, 22);
            this.dtpDiaEntrenamiento.TabIndex = 2;
            this.dtpDiaEntrenamiento.Value = new System.DateTime(2020, 9, 10, 0, 0, 0, 0);
            this.dtpDiaEntrenamiento.ValueChanged += new System.EventHandler(this.dtpDiaEntrenamiento_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(101, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbRepOseg
            // 
            this.cbRepOseg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRepOseg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbRepOseg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRepOseg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbRepOseg.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbRepOseg.ForeColor = System.Drawing.Color.White;
            this.cbRepOseg.FormattingEnabled = true;
            this.cbRepOseg.Items.AddRange(new object[] {
            "Repeticiones",
            "Segundos"});
            this.cbRepOseg.Location = new System.Drawing.Point(401, 374);
            this.cbRepOseg.Name = "cbRepOseg";
            this.cbRepOseg.Size = new System.Drawing.Size(200, 28);
            this.cbRepOseg.TabIndex = 5;
            this.cbRepOseg.SelectedIndexChanged += new System.EventHandler(this.cbRepOseg_SelectedIndexChanged);
            // 
            // lPesoOrepeticiones
            // 
            this.lPesoOrepeticiones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPesoOrepeticiones.AutoSize = true;
            this.lPesoOrepeticiones.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPesoOrepeticiones.ForeColor = System.Drawing.Color.White;
            this.lPesoOrepeticiones.Location = new System.Drawing.Point(386, 336);
            this.lPesoOrepeticiones.Name = "lPesoOrepeticiones";
            this.lPesoOrepeticiones.Size = new System.Drawing.Size(262, 26);
            this.lPesoOrepeticiones.TabIndex = 21;
            this.lPesoOrepeticiones.Text = "¿Repeticiones o segundos?";
            // 
            // tbCantidadSeries
            // 
            this.tbCantidadSeries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCantidadSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tbCantidadSeries.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.tbCantidadSeries.ForeColor = System.Drawing.Color.White;
            this.tbCantidadSeries.Location = new System.Drawing.Point(184, 377);
            this.tbCantidadSeries.Name = "tbCantidadSeries";
            this.tbCantidadSeries.Size = new System.Drawing.Size(200, 25);
            this.tbCantidadSeries.TabIndex = 4;
            // 
            // lCantidadSeries
            // 
            this.lCantidadSeries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lCantidadSeries.AutoSize = true;
            this.lCantidadSeries.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidadSeries.ForeColor = System.Drawing.Color.White;
            this.lCantidadSeries.Location = new System.Drawing.Point(198, 336);
            this.lCantidadSeries.Name = "lCantidadSeries";
            this.lCantidadSeries.Size = new System.Drawing.Size(168, 26);
            this.lCantidadSeries.TabIndex = 18;
            this.lCantidadSeries.Text = "¿Cuántas series?";
            // 
            // cbEjercicios
            // 
            this.cbEjercicios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEjercicios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEjercicios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEjercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbEjercicios.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbEjercicios.ForeColor = System.Drawing.Color.White;
            this.cbEjercicios.FormattingEnabled = true;
            this.cbEjercicios.Location = new System.Drawing.Point(184, 275);
            this.cbEjercicios.Name = "cbEjercicios";
            this.cbEjercicios.Size = new System.Drawing.Size(417, 28);
            this.cbEjercicios.TabIndex = 3;
            // 
            // lEjercicio
            // 
            this.lEjercicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lEjercicio.AutoSize = true;
            this.lEjercicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEjercicio.ForeColor = System.Drawing.Color.White;
            this.lEjercicio.Location = new System.Drawing.Point(260, 232);
            this.lEjercicio.Name = "lEjercicio";
            this.lEjercicio.Size = new System.Drawing.Size(258, 26);
            this.lEjercicio.TabIndex = 17;
            this.lEjercicio.Text = "¿Qué ejercicio realizaste?";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(207, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 34);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelSubirRutina
            // 
            this.panelSubirRutina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSubirRutina.AutoScroll = true;
            this.panelSubirRutina.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.panelSubirRutina.ForeColor = System.Drawing.Color.White;
            this.panelSubirRutina.Location = new System.Drawing.Point(184, 420);
            this.panelSubirRutina.Name = "panelSubirRutina";
            this.panelSubirRutina.Size = new System.Drawing.Size(464, 317);
            this.panelSubirRutina.TabIndex = 6;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Location = new System.Drawing.Point(184, 760);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(432, 60);
            this.panelBotones.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(607, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Traer todos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubirEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 903);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelSubirRutina);
            this.Controls.Add(this.cbRepOseg);
            this.Controls.Add(this.lPesoOrepeticiones);
            this.Controls.Add(this.dtpDiaEntrenamiento);
            this.Controls.Add(this.tbCantidadSeries);
            this.Controls.Add(this.lDiaEntrenamiento);
            this.Controls.Add(this.lCantidadSeries);
            this.Controls.Add(this.cbPersonas);
            this.Controls.Add(this.cbEjercicios);
            this.Controls.Add(this.lPersona);
            this.Controls.Add(this.lEjercicio);
            this.Controls.Add(this.label1);
            this.Name = "SubirEntrenamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubirEntrenamiento";
            this.Load += new System.EventHandler(this.SubirEntrenamiento_Load);
            this.Enter += new System.EventHandler(this.SubirEntrenamiento_Enter);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lPersona;
        private System.Windows.Forms.ComboBox cbPersonas;
        private System.Windows.Forms.Label lDiaEntrenamiento;
        private System.Windows.Forms.DateTimePicker dtpDiaEntrenamiento;
        private System.Windows.Forms.TextBox tbCantidadSeries;
        private System.Windows.Forms.Label lCantidadSeries;
        private System.Windows.Forms.ComboBox cbEjercicios;
        private System.Windows.Forms.Label lEjercicio;
        private System.Windows.Forms.Label lPesoOrepeticiones;
        private System.Windows.Forms.ComboBox cbRepOseg;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.FlowLayoutPanel panelSubirRutina;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button button1;
    }
}