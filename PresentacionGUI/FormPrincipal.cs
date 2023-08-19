using System;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFrmHija(object FormHija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FormRegistrarPersona());
        }

        private void txtAgregarVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FormRegistrarPacientes());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new Consulta());
        }

        private void btnImprimirRecibo_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FormActualizarPaciente());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void HOLA_Click(object sender, EventArgs e)
        {

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
