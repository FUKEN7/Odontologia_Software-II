namespace PresentacionGUI
{
    partial class Consulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRecomendacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(231, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "HISTORIAL PACIENTES";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Borrar Contenido",
            "General",
            "CC",
            "Nombre"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(12, 107);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuscar.TabIndex = 96;
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(141, 107);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(491, 22);
            this.textBoxBuscar.TabIndex = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdentificacion,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnAfiliacion,
            this.ColumnFecha,
            this.ColumnEnfermedad,
            this.ColumnRecomendacion});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 322);
            this.dataGridView1.TabIndex = 97;
            // 
            // ColumnIdentificacion
            // 
            this.ColumnIdentificacion.HeaderText = "Cedula";
            this.ColumnIdentificacion.Name = "ColumnIdentificacion";
            this.ColumnIdentificacion.ReadOnly = true;
            this.ColumnIdentificacion.Width = 80;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 85;
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Telefono";
            this.ColumnApellido.Name = "ColumnApellido";
            this.ColumnApellido.ReadOnly = true;
            this.ColumnApellido.Width = 86;
            // 
            // ColumnAfiliacion
            // 
            this.ColumnAfiliacion.HeaderText = "Correo Electronico";
            this.ColumnAfiliacion.Name = "ColumnAfiliacion";
            this.ColumnAfiliacion.ReadOnly = true;
            this.ColumnAfiliacion.Width = 153;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Width = 71;
            // 
            // ColumnEnfermedad
            // 
            this.ColumnEnfermedad.HeaderText = "Enfermedad";
            this.ColumnEnfermedad.Name = "ColumnEnfermedad";
            this.ColumnEnfermedad.ReadOnly = true;
            this.ColumnEnfermedad.Width = 111;
            // 
            // ColumnRecomendacion
            // 
            this.ColumnRecomendacion.HeaderText = "Recomendacion";
            this.ColumnRecomendacion.Name = "ColumnRecomendacion";
            this.ColumnRecomendacion.ReadOnly = true;
            this.ColumnRecomendacion.Width = 140;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.ShowInTaskbar = false;
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecomendacion;
    }
}