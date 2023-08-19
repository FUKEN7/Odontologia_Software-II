using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace PresentacionGUI
{
    public partial class Consulta : Form
    {
        PacienteService pacienteService;
        Response response;
        public Consulta()
        {
            pacienteService = new PacienteService(ConfigConnection.connectionString);
            response = new Response();
            InitializeComponent();
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscar.Text.Equals("General")) { VerificarConsulta(); }
            else if (comboBoxBuscar.Text.Equals("CC")) { ConsultaPorCedula(); }
            else if (comboBoxBuscar.Text.Equals("Nombre")) { ConsultaPorNombre(); }
            else if (comboBoxBuscar.Text.Equals("Borrar Contenido")) { BorrarContenido(); }
        }

        private void BorrarContenido()
        {
            dataGridView1.Rows.Clear();
        }

        private void ConsultaPorNombre()
        {
            response = pacienteService.ConsultarPorNombre(textBoxBuscar.Text);
            if (response.error == false)
            {
                PintarTablaCliente(response.pacientes);
            }
            else if (response.error == true)
            {
                MessageBox.Show(response.Mensaje);
            }
        }
        private void ConsultaPorCedula()
        {
            response = pacienteService.ConsultarPorNitOCedula(textBoxBuscar.Text);
            if (response.error == false)
            {
                PintarTablaCliente(response.pacientes);
            }
            else if (response.error == true)
            {
                MessageBox.Show(response.Mensaje);
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
