namespace Gimnasio
{
    partial class ConsultaCondicionesFisicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCondicionesFisicas));
            this.label1 = new System.Windows.Forms.Label();
            this.lDia = new System.Windows.Forms.Label();
            this.lbFechas = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgbCondicionesFisicas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCondicionesFisicas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mis avances personales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDia
            // 
            this.lDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDia.AutoSize = true;
            this.lDia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDia.ForeColor = System.Drawing.Color.White;
            this.lDia.Location = new System.Drawing.Point(468, 122);
            this.lDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(42, 26);
            this.lDia.TabIndex = 17;
            this.lDia.Text = "Día";
            this.lDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFechas
            // 
            this.lbFechas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lbFechas.ForeColor = System.Drawing.Color.White;
            this.lbFechas.FormattingEnabled = true;
            this.lbFechas.ItemHeight = 23;
            this.lbFechas.Location = new System.Drawing.Point(290, 164);
            this.lbFechas.Margin = new System.Windows.Forms.Padding(4);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(413, 165);
            this.lbFechas.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(1)))), ((int)(((byte)(38)))));
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(404, 342);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(19, 24, 4, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(191, 50);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgbCondicionesFisicas
            // 
            this.dgbCondicionesFisicas.AllowUserToAddRows = false;
            this.dgbCondicionesFisicas.AllowUserToDeleteRows = false;
            this.dgbCondicionesFisicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbCondicionesFisicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbCondicionesFisicas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dgbCondicionesFisicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbCondicionesFisicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbCondicionesFisicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbCondicionesFisicas.ColumnHeadersHeight = 45;
            this.dgbCondicionesFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbCondicionesFisicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbCondicionesFisicas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgbCondicionesFisicas.EnableHeadersVisualStyles = false;
            this.dgbCondicionesFisicas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgbCondicionesFisicas.Location = new System.Drawing.Point(46, 421);
            this.dgbCondicionesFisicas.Margin = new System.Windows.Forms.Padding(4);
            this.dgbCondicionesFisicas.MultiSelect = false;
            this.dgbCondicionesFisicas.Name = "dgbCondicionesFisicas";
            this.dgbCondicionesFisicas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbCondicionesFisicas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbCondicionesFisicas.RowHeadersVisible = false;
            this.dgbCondicionesFisicas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgbCondicionesFisicas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgbCondicionesFisicas.RowTemplate.Height = 75;
            this.dgbCondicionesFisicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgbCondicionesFisicas.Size = new System.Drawing.Size(908, 476);
            this.dgbCondicionesFisicas.TabIndex = 30;
            this.dgbCondicionesFisicas.VirtualMode = true;
            this.dgbCondicionesFisicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbCondicionesFisicas_CellContentClick);
            this.dgbCondicionesFisicas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbCondicionesFisicas_CellDoubleClick);
            this.dgbCondicionesFisicas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgbCondicionesFisicas_CellMouseMove);
            this.dgbCondicionesFisicas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbCondicionesFisicas_CellValueChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 857;
            // 
            // ConsultaCondicionesFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 939);
            this.Controls.Add(this.dgbCondicionesFisicas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbFechas);
            this.Controls.Add(this.lDia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaCondicionesFisicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCondicionesFisicas";
            this.Load += new System.EventHandler(this.ConsultaCondicionesFisicas_Load);
            this.Enter += new System.EventHandler(this.ConsultaCondicionesFisicas_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgbCondicionesFisicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.ListBox lbFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgbCondicionesFisicas;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}