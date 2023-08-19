namespace PresentacionGUI
{
    partial class FormRegistrarPacientes
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
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarPacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texCorreo = new System.Windows.Forms.TextBox();
            this.texFecha = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textRecomendacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRecomendacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBorrarTabla = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(492, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(250, 199);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(224, 228);
            this.txtEnfermedad.Multiline = true;
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(162, 112);
            this.txtEnfermedad.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Enfermedad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Problema o";
            // 
            // texCorreo
            // 
            this.texCorreo.Location = new System.Drawing.Point(224, 167);
            this.texCorreo.Name = "texCorreo";
            this.texCorreo.Size = new System.Drawing.Size(162, 20);
            this.texCorreo.TabIndex = 52;
            // 
            // texFecha
            // 
            this.texFecha.Location = new System.Drawing.Point(224, 202);
            this.texFecha.Name = "texFecha";
            this.texFecha.Size = new System.Drawing.Size(162, 20);
            this.texFecha.TabIndex = 51;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(224, 136);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(162, 20);
            this.txtcelular.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(217, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 38);
            this.label4.TabIndex = 46;
            this.label4.Text = "Registro de Paciente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "IdPaciente";
            // 
            // bntSearch
            // 
            this.bntSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSearch.Location = new System.Drawing.Point(545, 293);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(92, 36);
            this.bntSearch.TabIndex = 41;
            this.bntSearch.Text = "Rellenar datos";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(224, 83);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(162, 20);
            this.txtIdPaciente.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha(DD/MM/AAA)";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(394, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textRecomendacion
            // 
            this.textRecomendacion.Location = new System.Drawing.Point(224, 346);
            this.textRecomendacion.Multiline = true;
            this.textRecomendacion.Name = "textRecomendacion";
            this.textRecomendacion.Size = new System.Drawing.Size(162, 112);
            this.textRecomendacion.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Recomendacion";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.Location = new System.Drawing.Point(394, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(382, 124);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonBorrarTabla
            // 
            this.buttonBorrarTabla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarTabla.Location = new System.Drawing.Point(684, 292);
            this.buttonBorrarTabla.Name = "buttonBorrarTabla";
            this.buttonBorrarTabla.Size = new System.Drawing.Size(92, 36);
            this.buttonBorrarTabla.TabIndex = 95;
            this.buttonBorrarTabla.Text = "Borrar tabla";
            this.buttonBorrarTabla.UseVisualStyleBackColor = true;
            this.buttonBorrarTabla.Click += new System.EventHandler(this.buttonBorrarTabla_Click);
            // 
            // FormRegistrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.buttonBorrarTabla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textRecomendacion);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texCorreo);
            this.Controls.Add(this.texFecha);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarPacientes";
            this.Text = "FormPacientes";
            this.Load += new System.EventHandler(this.FormRegistrarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox texCorreo;
        private System.Windows.Forms.TextBox texFecha;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textRecomendacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecomendacion;
        private System.Windows.Forms.Button buttonBorrarTabla;
    }
}