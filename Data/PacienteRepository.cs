using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Data
{
    public class PacienteRepository
    {
        private SqlConnection connection;
        public PacienteRepository(Manejador cadena)
        {
            connection = cadena.connection;
        }

        public void Guardar(Paciente paciente)
        {
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "insert into Pacientes (IdPersona,Nombre,Celular,Correo,Descripcion,Fecha,Recomedacion) " +
                    " values (@IdPersona,@Nombre,@Celular,@Correo,@Descripcion,@Fecha,@Recomedacion);";
                sqlCommand.Parameters.AddWithValue("@IdPersona", paciente.IDC);
                sqlCommand.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                sqlCommand.Parameters.AddWithValue("@Celular", paciente.Celular);
                sqlCommand.Parameters.AddWithValue("@Correo", paciente.Correo);
                sqlCommand.Parameters.AddWithValue("@Descripcion", paciente.Descricion);
                sqlCommand.Parameters.AddWithValue("@Fecha", paciente.Fecha);
                sqlCommand.Parameters.AddWithValue("@Recomedacion", paciente.Recomedacion);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Eliminar(Paciente paciente)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Delete from Pacientes where IdPersona=@ID";
                command.Parameters.AddWithValue("@ID", paciente.IDC);
                command.ExecuteNonQuery();
            }
        }
        public void Modificar(Paciente paciente)
        {
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "update Pacientes set Nombre=@Nombre, Celular=@Celular, Correo=@Correo," +
                    " Descripcion=@Descripcion, Fecha=@Fecha, Recomedacion=@Recomedacion where IdPersona=@IdPersona";
                sqlCommand.Parameters.AddWithValue("@IdPersona", paciente.IDC);
                sqlCommand.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                sqlCommand.Parameters.AddWithValue("@Celular", paciente.Celular);
                sqlCommand.Parameters.AddWithValue("@Correo", paciente.Correo);
                sqlCommand.Parameters.AddWithValue("@Descripcion", paciente.Descricion);
                sqlCommand.Parameters.AddWithValue("@Fecha", paciente.Fecha);
                sqlCommand.Parameters.AddWithValue("@Recomedacion", paciente.Recomedacion);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public Paciente VerificarPaciente(string item)
        {
            IList<Paciente> lista = LeerPaciente();
            foreach (Paciente paciente in lista)
            {
                if (paciente.IDC.Equals(item))
                {
                    return paciente;
                }
            }
            return null;
        }

        public IList<Paciente> LeerPaciente()
        {
            SqlDataReader dataReader;
            List<Paciente> pacientes = new List<Paciente>();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select * from Pacientes;";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Paciente paciente = MapearCliente(dataReader);
                        pacientes.Add(paciente);
                    }
                }
            }
            return pacientes;
        }

        public Paciente MapearCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Paciente paciente = new Paciente();
            paciente.IDC = (int)dataReader["IdPersona"];
            paciente.Nombre = (string)dataReader["Nombre"];
            paciente.Celular = (string)dataReader["Celular"];
            paciente.Correo = (string)dataReader["Correo"];
            paciente.Descricion = (string)dataReader["Descripcion"];
            paciente.Fecha = (string)dataReader["Fecha"];
            paciente.Recomedacion = (string)dataReader["Recomedacion"];
            return paciente;
        }

        public IList<Paciente> ConsultaPorCedula(string cedula)
        {
            return LeerPaciente().Where(Paciente => Convert.ToString(Paciente.IDC).Contains(cedula)).ToList();
        }

        public IList<Paciente> ConsultaPorNombre(string nombre)
        {
            return LeerPaciente().Where(Paciente => Paciente.Nombre.Contains(nombre)).ToList();
        }
    }
}
