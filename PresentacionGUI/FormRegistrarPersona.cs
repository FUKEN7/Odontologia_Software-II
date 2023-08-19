using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormRegistrarPersona : Form
    {
        PersonaService personaService;
        Response response;
        public FormRegistrarPersona()
        {
            personaService= new PersonaService(ConfigConnection.connectionString);
            response = new Response();
            InitializeComponent();
        }

        private void Guardar()
        {
            MessageBox.Show(personaService.Guardar(CrearPaciente()));
        }

        private Persona CrearPaciente()
        {
            Persona persona = new Persona();
            persona.IDC = int.Parse(txtIdClient.Text);
            persona.Nombre = txtNombre.Text;
            persona.Celular = textCelular.Text;
            persona.Correo = textCorreo.Text;
            return persona;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Guardar();
            VerificarConsulta();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtIdClient.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textCelular.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textCorreo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Una Fila");
            }
        }

        public void VerificarConsulta()
        {
            response = personaService.Consultar();
            if (response.error == false)
            {
                PintarTablaCliente(response.personas);
            }
            else if (response.error == true)
            {
                MessageBox.Show(response.Mensaje);
            }
        }

        private void PintarTablaCliente(IList<Persona> personas)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (personas != null)
            {
                foreach (Persona item in personas)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = Convert.ToString(item.IDC);
                    dataGridView1.Rows[n].Cells[1].Value = item.Nombre;
                    dataGridView1.Rows[n].Cells[2].Value = item.Celular;
                    dataGridView1.Rows[n].Cells[3].Value = item.Correo;
                }
            }
        }

        private void btnPintarTabla_Click(object sender, EventArgs e)
        {
            VerificarConsulta();
        }

        private void btnBorrarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
