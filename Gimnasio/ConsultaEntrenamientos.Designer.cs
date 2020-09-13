namespace Gimnasio
{
    partial class ConsultaEntrenamientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEntrenamientos));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSetsEntrenamiento = new System.Windows.Forms.DateTimePicker();
            this.dgbEntrenamientos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lDia = new System.Windows.Forms.Label();
            this.btnEliminarSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEntrenamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mis entrenamientos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpSetsEntrenamiento
            // 
            this.dtpSetsEntrenamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpSetsEntrenamiento.Location = new System.Drawing.Point(436, 120);
            this.dtpSetsEntrenamiento.Name = "dtpSetsEntrenamiento";
            this.dtpSetsEntrenamiento.Size = new System.Drawing.Size(372, 31);
            this.dtpSetsEntrenamiento.TabIndex = 13;
            this.dtpSetsEntrenamiento.Value = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dtpSetsEntrenamiento.CloseUp += new System.EventHandler(this.dtpSetsEntrenamiento_CloseUp);
            // 
            // dgbEntrenamientos
            // 
            this.dgbEntrenamientos.AllowUserToAddRows = false;
            this.dgbEntrenamientos.AllowUserToDeleteRows = false;
            this.dgbEntrenamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbEntrenamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbEntrenamientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEntrenamientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbEntrenamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEntrenamientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEntrenamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgbEntrenamientos.ColumnHeadersHeight = 45;
            this.dgbEntrenamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEntrenamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbEntrenamientos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgbEntrenamientos.EnableHeadersVisualStyles = false;
            this.dgbEntrenamientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbEntrenamientos.Location = new System.Drawing.Point(12, 184);
            this.dgbEntrenamientos.MultiSelect = false;
            this.dgbEntrenamientos.Name = "dgbEntrenamientos";
            this.dgbEntrenamientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEntrenamientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgbEntrenamientos.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEntrenamientos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgbEntrenamientos.RowTemplate.Height = 24;
            this.dgbEntrenamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbEntrenamientos.Size = new System.Drawing.Size(1176, 564);
            this.dgbEntrenamientos.TabIndex = 14;
            this.dgbEntrenamientos.VirtualMode = true;
            this.dgbEntrenamientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEntrenamientos_CellDoubleClick);
            this.dgbEntrenamientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEntrenamientos_CellValueChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // lDia
            // 
            this.lDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(530, 92);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(220, 26);
            this.lDia.TabIndex = 16;
            this.lDia.Text = "Día de entrenamiento";
            this.lDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarSet
            // 
            this.btnEliminarSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnEliminarSet.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminarSet.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSet.Location = new System.Drawing.Point(455, 768);
            this.btnEliminarSet.Margin = new System.Windows.Forms.Padding(15, 17, 3, 17);
            this.btnEliminarSet.Name = "btnEliminarSet";
            this.btnEliminarSet.Size = new System.Drawing.Size(274, 45);
            this.btnEliminarSet.TabIndex = 28;
            this.btnEliminarSet.Text = "Eliminar entrenamiento";
            this.btnEliminarSet.UseVisualStyleBackColor = false;
            this.btnEliminarSet.Click += new System.EventHandler(this.btnEliminarSet_Click);
            // 
            // ConsultaEntrenamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 853);
            this.Controls.Add(this.btnEliminarSet);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.dgbEntrenamientos);
            this.Controls.Add(this.dtpSetsEntrenamiento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaEntrenamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEntrenamientos";
            this.Load += new System.EventHandler(this.ConsultaEntrenamientos_Load);
            this.Enter += new System.EventHandler(this.ConsultaEntrenamientos_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEntrenamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSetsEntrenamiento;
        private System.Windows.Forms.DataGridView dgbEntrenamientos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.Button btnEliminarSet;
    }
}