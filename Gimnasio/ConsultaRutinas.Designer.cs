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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRutinas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1.Location = new System.Drawing.Point(320, 24);
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
            this.lDia.Location = new System.Drawing.Point(326, 99);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(42, 26);
            this.lDia.TabIndex = 15;
            this.lDia.Text = "Día";
            // 
            // cbDias
            // 
            this.cbDias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
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
            this.cbDias.Location = new System.Drawing.Point(277, 128);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(145, 28);
            this.cbDias.TabIndex = 16;
            this.cbDias.SelectedIndexChanged += new System.EventHandler(this.cbDias_SelectedIndexChanged);
            // 
            // dgbMusculos
            // 
            this.dgbMusculos.AllowUserToAddRows = false;
            this.dgbMusculos.AllowUserToDeleteRows = false;
            this.dgbMusculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgbMusculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbMusculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbMusculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbMusculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbMusculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgbMusculos.ColumnHeadersHeight = 45;
            this.dgbMusculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbMusculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgbMusculos.EnableHeadersVisualStyles = false;
            this.dgbMusculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbMusculos.Location = new System.Drawing.Point(12, 334);
            this.dgbMusculos.MultiSelect = false;
            this.dgbMusculos.Name = "dgbMusculos";
            this.dgbMusculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgbMusculos.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgbMusculos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgbMusculos.RowTemplate.Height = 24;
            this.dgbMusculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbMusculos.Size = new System.Drawing.Size(410, 293);
            this.dgbMusculos.TabIndex = 17;
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
            this.dgbEjercicios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgbEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbEjercicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEjercicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEjercicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgbEjercicios.ColumnHeadersHeight = 45;
            this.dgbEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            this.dgbEjercicios.EnableHeadersVisualStyles = false;
            this.dgbEjercicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbEjercicios.Location = new System.Drawing.Point(463, 334);
            this.dgbEjercicios.MultiSelect = false;
            this.dgbEjercicios.Name = "dgbEjercicios";
            this.dgbEjercicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgbEjercicios.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEjercicios.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgbEjercicios.RowTemplate.Height = 24;
            this.dgbEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbEjercicios.Size = new System.Drawing.Size(425, 293);
            this.dgbEjercicios.TabIndex = 18;
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
            this.lMusculos.Location = new System.Drawing.Point(192, 195);
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
            this.lEjercicios.Location = new System.Drawing.Point(632, 195);
            this.lEjercicios.Name = "lEjercicios";
            this.lEjercicios.Size = new System.Drawing.Size(103, 26);
            this.lEjercicios.TabIndex = 20;
            this.lEjercicios.Text = "Ejercicios";
            // 
            // cbOpcion
            // 
            this.cbOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
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
            this.cbOpcion.Location = new System.Drawing.Point(463, 128);
            this.cbOpcion.Name = "cbOpcion";
            this.cbOpcion.Size = new System.Drawing.Size(145, 28);
            this.cbOpcion.TabIndex = 22;
            this.cbOpcion.SelectedIndexChanged += new System.EventHandler(this.cbOpcion_SelectedIndexChanged);
            // 
            // lOpcion
            // 
            this.lOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lOpcion.AutoSize = true;
            this.lOpcion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOpcion.ForeColor = System.Drawing.Color.White;
            this.lOpcion.Location = new System.Drawing.Point(492, 99);
            this.lOpcion.Name = "lOpcion";
            this.lOpcion.Size = new System.Drawing.Size(77, 26);
            this.lOpcion.TabIndex = 21;
            this.lOpcion.Text = "Opción";
            // 
            // btnEliminarRutina
            // 
            this.btnEliminarRutina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnEliminarRutina.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarRutina.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRutina.Location = new System.Drawing.Point(355, 647);
            this.btnEliminarRutina.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnEliminarRutina.Name = "btnEliminarRutina";
            this.btnEliminarRutina.Size = new System.Drawing.Size(149, 31);
            this.btnEliminarRutina.TabIndex = 25;
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
            this.btnAgregarMusculo.Location = new System.Drawing.Point(171, 274);
            this.btnAgregarMusculo.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnAgregarMusculo.Name = "btnAgregarMusculo";
            this.btnAgregarMusculo.Size = new System.Drawing.Size(131, 31);
            this.btnAgregarMusculo.TabIndex = 27;
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
            this.btnAgregarEjercicio.Location = new System.Drawing.Point(618, 274);
            this.btnAgregarEjercicio.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnAgregarEjercicio.Name = "btnAgregarEjercicio";
            this.btnAgregarEjercicio.Size = new System.Drawing.Size(131, 31);
            this.btnAgregarEjercicio.TabIndex = 29;
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
            this.cbMusculos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cbMusculos.ForeColor = System.Drawing.Color.White;
            this.cbMusculos.FormattingEnabled = true;
            this.cbMusculos.Location = new System.Drawing.Point(112, 226);
            this.cbMusculos.Name = "cbMusculos";
            this.cbMusculos.Size = new System.Drawing.Size(256, 28);
            this.cbMusculos.TabIndex = 30;
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
            this.cbEjercicios.Location = new System.Drawing.Point(566, 226);
            this.cbEjercicios.Name = "cbEjercicios";
            this.cbEjercicios.Size = new System.Drawing.Size(256, 28);
            this.cbEjercicios.TabIndex = 31;
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