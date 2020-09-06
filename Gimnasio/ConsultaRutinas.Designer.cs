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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRutinas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lDia = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.dgbMusculos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgbEjercicios = new System.Windows.Forms.DataGridView();
            this.lMusculos = new System.Windows.Forms.Label();
            this.lEjercicios = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.lDia.Location = new System.Drawing.Point(401, 96);
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
            this.cbDias.Location = new System.Drawing.Point(352, 125);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgbMusculos.ColumnHeadersHeight = 45;
            this.dgbMusculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbMusculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgbMusculos.EnableHeadersVisualStyles = false;
            this.dgbMusculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbMusculos.Location = new System.Drawing.Point(12, 233);
            this.dgbMusculos.MultiSelect = false;
            this.dgbMusculos.Name = "dgbMusculos";
            this.dgbMusculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbMusculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgbMusculos.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgbMusculos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgbMusculos.RowTemplate.Height = 24;
            this.dgbMusculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbMusculos.Size = new System.Drawing.Size(410, 293);
            this.dgbMusculos.TabIndex = 17;
            this.dgbMusculos.VirtualMode = true;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgbEjercicios.ColumnHeadersHeight = 45;
            this.dgbEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            this.dgbEjercicios.EnableHeadersVisualStyles = false;
            this.dgbEjercicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbEjercicios.Location = new System.Drawing.Point(463, 233);
            this.dgbEjercicios.MultiSelect = false;
            this.dgbEjercicios.Name = "dgbEjercicios";
            this.dgbEjercicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEjercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgbEjercicios.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEjercicios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgbEjercicios.RowTemplate.Height = 24;
            this.dgbEjercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbEjercicios.Size = new System.Drawing.Size(425, 293);
            this.dgbEjercicios.TabIndex = 18;
            this.dgbEjercicios.VirtualMode = true;
            // 
            // lMusculos
            // 
            this.lMusculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMusculos.AutoSize = true;
            this.lMusculos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMusculos.ForeColor = System.Drawing.Color.White;
            this.lMusculos.Location = new System.Drawing.Point(193, 204);
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
            this.lEjercicios.Location = new System.Drawing.Point(634, 204);
            this.lEjercicios.Name = "lEjercicios";
            this.lEjercicios.Size = new System.Drawing.Size(103, 26);
            this.lEjercicios.TabIndex = 20;
            this.lEjercicios.Text = "Ejercicios";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Eliminar";
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.MinimumWidth = 6;
            this.Borrar.Name = "Borrar";
            // 
            // ConsultaRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 562);
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
    }
}