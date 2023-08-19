using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormActualizarPaciente : Form
    {
        PacienteService pacienteService;
        Response response;
        public FormActualizarPaciente()
        {
            pacienteService = new PacienteService(ConfigConnection.connectionString);
            response = new Response();
            InitializeComponent();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pacienteService.Editar(CrearPaciente()));
        }
        private Paciente CrearPaciente()
        {
            Paciente paciente = new Paciente();
            paciente.IDC = int.Parse(txtIdPaciente.Text);
            paciente.Nombre = txtNombre.Text;
            paciente.Celular = txtcelular.Text;
            paciente.Correo = texCorreo.Text;
            paciente.Descricion = txtEnfermedad.Text;
            paciente.Fecha = texFecha.Text;
            paciente.Recomedacion = textRecomendacion.Text;
            return paciente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerificarConsulta();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtIdPaciente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtcelular.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                texCorreo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                texFecha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtEnfermedad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textRecomendacion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Una Fila");
            }
        }

        public void VerificarConsulta()
        {
            response = pacienteService.Consultar();
            if (response.error == false)
            {
                PintarTablaCliente(response.pacientes);
            }
            else if (response.error == true)
            {
                MessageBox.Show(response.Mensaje);
            }
        }


        private void PintarTablaCliente(IList<Paciente> pacientes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (pacientes != null)
            {
                foreach (Paciente item in pacientes)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.IDC;
                    dataGridView1.Rows[n].Cells[1].Value = item.Nombre;
                    dataGridView1.Rows[n].Cells[2].Value = item.Celular;
                    dataGridView1.Rows[n].Cells[3].Value = item.Correo;
                    dataGridView1.Rows[n].Cells[4].Value = item.Fecha;
                    dataGridView1.Rows[n].Cells[5].Value = item.Descricion;
                    dataGridView1.Rows[n].Cells[6].Value = item.Recomedacion;
                }
            }
        }
    }
}
