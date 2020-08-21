namespace Gimnasio
{
    partial class Mantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEjercicioOPersona = new System.Windows.Forms.ComboBox();
            this.tablaPersona = new Gimnasio.tablaPersona();
            this.tablaPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPersonaTableAdapter = new Gimnasio.tablaPersonaTableAdapters.tablaPersonaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lAltura = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Qué querés modificar o crear?";
            // 
            // cbEjercicioOPersona
            // 
            this.cbEjercicioOPersona.FormattingEnabled = true;
            this.cbEjercicioOPersona.Items.AddRange(new object[] {
            "Ejercicios",
            "Personas"});
            this.cbEjercicioOPersona.Location = new System.Drawing.Point(312, 186);
            this.cbEjercicioOPersona.Name = "cbEjercicioOPersona";
            this.cbEjercicioOPersona.Size = new System.Drawing.Size(121, 24);
            this.cbEjercicioOPersona.TabIndex = 3;
            this.cbEjercicioOPersona.SelectedIndexChanged += new System.EventHandler(this.cbEjercicioOPersona_SelectedIndexChanged);
            // 
            // tablaPersona
            // 
            this.tablaPersona.DataSetName = "tablaPersona";
            this.tablaPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaPersonaBindingSource
            // 
            this.tablaPersonaBindingSource.DataMember = "tablaPersona";
            this.tablaPersonaBindingSource.DataSource = this.tablaPersona;
            // 
            // tablaPersonaTableAdapter
            // 
            this.tablaPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.Location = new System.Drawing.Point(59, 334);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 492);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(255, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(235, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(250, 225);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(86, 26);
            this.lNombre.TabIndex = 6;
            this.lNombre.Text = "Nombre";
            // 
            // lAltura
            // 
            this.lAltura.AutoSize = true;
            this.lAltura.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltura.ForeColor = System.Drawing.Color.White;
            this.lAltura.Location = new System.Drawing.Point(409, 226);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(70, 26);
            this.lAltura.TabIndex = 7;
            this.lAltura.Text = "Altura";
            this.lAltura.Visible = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(255, 254);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(129, 22);
            this.tbNombre.TabIndex = 8;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(390, 254);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(100, 22);
            this.tbAltura.TabIndex = 9;
            this.tbAltura.Visible = false;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 838);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lAltura);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbEjercicioOPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbEjercicioOPersona, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.lNombre, 0);
            this.Controls.SetChildIndex(this.lAltura, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbAltura, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEjercicioOPersona;
        private tablaPersona tablaPersona;
        private System.Windows.Forms.BindingSource tablaPersonaBindingSource;
        private tablaPersonaTableAdapters.tablaPersonaTableAdapter tablaPersonaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}