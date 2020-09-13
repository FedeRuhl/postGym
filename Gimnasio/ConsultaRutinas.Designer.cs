namespace Gimnasio
{
    partial class ConsultaRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRutinas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lDia = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.dgbMusculos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgbEjercicios = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lMusculos = new System.Windows.Forms.Label();
            this.lEjercicios = new System.Windows.Forms.Label();
            this.cbOpcion = new System.Windows.Forms.ComboBox();
            this.lOpcion = new System.Windows.Forms.Label();
            this.btnEliminarRutina = new System.Windows.Forms.Button();
            this.btnAgregarMusculo = new System.Windows.Forms.Button();
            this.btnAgregarEjercicio = new System.Windows.Forms.Button();
            this.cbMusculos = new System.Windows.Forms.ComboBox();
            this.cbEjercicios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMusculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEjercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mis rutinas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDia
            // 
            this.lDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(326, 83);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(42, 26);
            this.lDia.TabIndex = 15;
            this.lDia.Text = "Día";
            // 
            // cbDias
            // 
            this.cbDias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDias.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbDias.ForeColor = System.Drawing.Color.White;
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbDias.Location = new System.Drawing.Point(277, 112);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(145, 28);
            this.cbDias.TabIndex = 1;
            this.cbDias.SelectedIndexChanged += new System.EventHandler(this.cbDias_SelectedIndexChanged);
            // 
            // dgbMusculos
            // 
            this.dgbMusculos.AllowUserToAddRows = false;
            this.dgbMusculos.AllowUserToDeleteRows = false;
            this.dgbMusculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgbMusculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbMusculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbMusculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbMusculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbMusculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbMusculos.ColumnHeadersHeight = 45;
            this.dgbMusculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbMusculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbMusculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgbMusculos.EnableHeadersVisualStyles = false;
            this.dgbMusculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbMusculos.Location = new System.Drawing.Point(12, 318);
            this.dgbMusculos.MultiSelect = false;
            this.dgbMusculos.Name = "dgbMusculos";
            this.dgbMusculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbMusculos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgbMusculos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgbMusculos.RowTemplate.Height = 24;
            this.dgbMusculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbMusculos.Size = new System.Drawing.Size(410, 293);
            this.dgbMusculos.TabIndex = 7;
            this.dgbMusculos.VirtualMode = true;
            this.dgbMusculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbMusculos_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // dgbEjercicios
            // 
            this.dgbEjercicios.AllowUserToAddRows = false;
            this.dgbEjercicios.AllowUserToDeleteRows = false;
            this.dgbEjercicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgbEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbEjercicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEjercicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEjercicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgbEjercicios.ColumnHeadersHeight = 45;
            this.dgbEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbEjercicios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgbEjercicios.EnableHeadersVisualStyles = false;
            this.dgbEjercicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbEjercicios.Location = new System.Drawing.Point(463, 318);
            this.dgbEjercicios.MultiSelect = false;
            this.dgbEjercicios.Name = "dgbEjercicios";
            this.dgbEjercicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgbEjercicios.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEjercicios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgbEjercicios.RowTemplate.Height = 24;
            this.dgbEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbEjercicios.Size = new System.Drawing.Size(425, 293);
            this.dgbEjercicios.TabIndex = 8;
            this.dgbEjercicios.VirtualMode = true;
            this.dgbEjercicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEjercicios_CellDoubleClick);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Eliminar";
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.MinimumWidth = 6;
            this.Borrar.Name = "Borrar";
            // 
            // lMusculos
            // 
            this.lMusculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMusculos.AutoSize = true;
            this.lMusculos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMusculos.ForeColor = System.Drawing.Color.White;
            this.lMusculos.Location = new System.Drawing.Point(192, 179);
            this.lMusculos.Name = "lMusculos";
            this.lMusculos.Size = new System.Drawing.Size(96, 26);
            this.lMusculos.TabIndex = 19;
            this.lMusculos.Text = "Músculos";
            // 
            // lEjercicios
            // 
            this.lEjercicios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lEjercicios.AutoSize = true;
            this.lEjercicios.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEjercicios.ForeColor = System.Drawing.Color.White;
            this.lEjercicios.Location = new System.Drawing.Point(632, 179);
            this.lEjercicios.Name = "lEjercicios";
            this.lEjercicios.Size = new System.Drawing.Size(103, 26);
            this.lEjercicios.TabIndex = 20;
            this.lEjercicios.Text = "Ejercicios";
            // 
            // cbOpcion
            // 
            this.cbOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbOpcion.ForeColor = System.Drawing.Color.White;
            this.cbOpcion.FormattingEnabled = true;
            this.cbOpcion.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbOpcion.Location = new System.Drawing.Point(463, 112);
            this.cbOpcion.Name = "cbOpcion";
            this.cbOpcion.Size = new System.Drawing.Size(145, 28);
            this.cbOpcion.TabIndex = 2;
            this.cbOpcion.SelectedIndexChanged += new System.EventHandler(this.cbOpcion_SelectedIndexChanged);
            // 
            // lOpcion
            // 
            this.lOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOpcion.AutoSize = true;
            this.lOpcion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOpcion.ForeColor = System.Drawing.Color.White;
            this.lOpcion.Location = new System.Drawing.Point(492, 83);
            this.lOpcion.Name = "lOpcion";
            this.lOpcion.Size = new System.Drawing.Size(77, 26);
            this.lOpcion.TabIndex = 21;
            this.lOpcion.Text = "Opción";
            // 
            // btnEliminarRutina
            // 
            this.btnEliminarRutina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnEliminarRutina.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarRutina.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRutina.Location = new System.Drawing.Point(355, 631);
            this.btnEliminarRutina.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnEliminarRutina.Name = "btnEliminarRutina";
            this.btnEliminarRutina.Size = new System.Drawing.Size(149, 31);
            this.btnEliminarRutina.TabIndex = 9;
            this.btnEliminarRutina.Text = "Eliminar rutina";
            this.btnEliminarRutina.UseVisualStyleBackColor = false;
            this.btnEliminarRutina.Click += new System.EventHandler(this.btnEliminarRutina_Click);
            // 
            // btnAgregarMusculo
            // 
            this.btnAgregarMusculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarMusculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnAgregarMusculo.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMusculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMusculo.Location = new System.Drawing.Point(171, 258);
            this.btnAgregarMusculo.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnAgregarMusculo.Name = "btnAgregarMusculo";
            this.btnAgregarMusculo.Size = new System.Drawing.Size(131, 31);
            this.btnAgregarMusculo.TabIndex = 4;
            this.btnAgregarMusculo.Text = "Agregar";
            this.btnAgregarMusculo.UseVisualStyleBackColor = false;
            this.btnAgregarMusculo.Click += new System.EventHandler(this.btnAgregarMusculo_Click);
            // 
            // btnAgregarEjercicio
            // 
            this.btnAgregarEjercicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnAgregarEjercicio.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEjercicio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEjercicio.Location = new System.Drawing.Point(618, 258);
            this.btnAgregarEjercicio.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnAgregarEjercicio.Name = "btnAgregarEjercicio";
            this.btnAgregarEjercicio.Size = new System.Drawing.Size(131, 31);
            this.btnAgregarEjercicio.TabIndex = 6;
            this.btnAgregarEjercicio.Text = "Agregar";
            this.btnAgregarEjercicio.UseVisualStyleBackColor = false;
            this.btnAgregarEjercicio.Click += new System.EventHandler(this.btnAgregarEjercicio_Click);
            // 
            // cbMusculos
            // 
            this.cbMusculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMusculos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMusculos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMusculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.cbMusculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMusculos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbMusculos.ForeColor = System.Drawing.Color.White;
            this.cbMusculos.FormattingEnabled = true;
            this.cbMusculos.Location = new System.Drawing.Point(112, 210);
            this.cbMusculos.Name = "cbMusculos";
            this.cbMusculos.Size = new System.Drawing.Size(256, 28);
            this.cbMusculos.TabIndex = 3;
            this.cbMusculos.Click += new System.EventHandler(this.cbMusculos_Click);
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
            this.cbEjercicios.Location = new System.Drawing.Point(566, 210);
            this.cbEjercicios.Name = "cbEjercicios";
            this.cbEjercicios.Size = new System.Drawing.Size(256, 28);
            this.cbEjercicios.TabIndex = 5;
            this.cbEjercicios.Click += new System.EventHandler(this.cbEjercicios_Click);
            // 
            // ConsultaRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 703);
            this.Controls.Add(this.cbEjercicios);
            this.Controls.Add(this.cbMusculos);
            this.Controls.Add(this.btnAgregarEjercicio);
            this.Controls.Add(this.btnAgregarMusculo);
            this.Controls.Add(this.btnEliminarRutina);
            this.Controls.Add(this.cbOpcion);
            this.Controls.Add(this.lOpcion);
            this.Controls.Add(this.lEjercicios);
            this.Controls.Add(this.lMusculos);
            this.Controls.Add(this.dgbEjercicios);
            this.Controls.Add(this.dgbMusculos);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultaRutinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaRutinas";
            this.Load += new System.EventHandler(this.ConsultaRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbMusculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEjercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.DataGridView dgbMusculos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridView dgbEjercicios;
        private System.Windows.Forms.Label lMusculos;
        private System.Windows.Forms.Label lEjercicios;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.ComboBox cbOpcion;
        private System.Windows.Forms.Label lOpcion;
        private System.Windows.Forms.Button btnEliminarRutina;
        private System.Windows.Forms.Button btnAgregarMusculo;
        private System.Windows.Forms.Button btnAgregarEjercicio;
        private System.Windows.Forms.ComboBox cbMusculos;
        private System.Windows.Forms.ComboBox cbEjercicios;
    }
}