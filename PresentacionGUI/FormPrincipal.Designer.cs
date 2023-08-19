namespace PresentacionGUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImprimirRecibo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtAgregarVehiculo = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.Location = new System.Drawing.Point(12, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 58);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Persona";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimirRecibo
            // 
            this.btnImprimirRecibo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRecibo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnImprimirRecibo.Location = new System.Drawing.Point(12, 209);
            this.btnImprimirRecibo.Name = "btnImprimirRecibo";
            this.btnImprimirRecibo.Size = new System.Drawing.Size(146, 64);
            this.btnImprimirRecibo.TabIndex = 2;
            this.btnImprimirRecibo.Text = "Actualizar";
            this.btnImprimirRecibo.UseVisualStyleBackColor = true;
            this.btnImprimirRecibo.Click += new System.EventHandler(this.btnImprimirRecibo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnConsultar.Location = new System.Drawing.Point(12, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(146, 63);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Historial Paciente";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtAgregarVehiculo
            // 
            this.txtAgregarVehiculo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarVehiculo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAgregarVehiculo.Location = new System.Drawing.Point(12, 70);
            this.txtAgregarVehiculo.Name = "txtAgregarVehiculo";
            this.txtAgregarVehiculo.Size = new System.Drawing.Size(146, 64);
            this.txtAgregarVehiculo.TabIndex = 4;
            this.txtAgregarVehiculo.Text = "Agregar Paciente";
            this.txtAgregarVehiculo.UseVisualStyleBackColor = true;
            this.txtAgregarVehiculo.Click += new System.EventHandler(this.txtAgregarVehiculo_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(826, 28);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(133, 18);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelHora
            // 
            this.labelHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(826, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(144, 19);
            this.labelHora.TabIndex = 27;
            this.labelHora.Text = "Hora:";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.btnImprimirRecibo);
            this.panel2.Controls.Add(this.txtAgregarVehiculo);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(818, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 447);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(402, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Menú";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(988, 518);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimirRecibo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button txtAgregarVehiculo;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}