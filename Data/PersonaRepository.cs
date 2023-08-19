using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonaRepository
    {
        private SqlConnection connection;
        public PersonaRepository(Manejador cadena)
        {
            connection = cadena.connection;
        }

        public void Guardar(Persona persona)
        {
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "insert into persona(Cedula,Nombre,Telefono,CorreoElectronico) " +
                    "values(@Cedula,@Nombre,@Telefono,@CorreoElectronico)";
                sqlCommand.Parameters.AddWithValue("@Cedula", persona.IDC);
                sqlCommand.Parameters.AddWithValue("@Nombre", persona.Nombre);
                sqlCommand.Parameters.AddWithValue("@Telefono", persona.Celular);
                sqlCommand.Parameters.AddWithValue("@CorreoElectronico", persona.Correo);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Eliminar(Persona persona)
        {
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Delete from persona where Cedula=@Cedula";
                command.Parameters.AddWithValue("@Cedula", persona.IDC);
                command.ExecuteNonQuery();
            }
        }
        public void Modificar(Persona persona)
        {
            using (SqlCommand sqlcommand = connection.CreateCommand())
            {
                sqlcommand.CommandText = "update  persona set Nombre=@Nombre, Telefono=@Telefono," +
                    " CorreoElectronico=@CorreoElectronico where Cedula=@Cedula";
                sqlcommand.Parameters.AddWithValue("@Cedula", persona.IDC);
                sqlcommand.Parameters.AddWithValue("@Nombre", persona.Nombre);
                sqlcommand.Parameters.AddWithValue("@Telefono", persona.Celular);
                sqlcommand.Parameters.AddWithValue("@CorreoElectronico", persona.Correo);
                sqlcommand.ExecuteNonQuery();
            }
        }
        public Persona VerificarCliente(string item)
        {
            IList<Persona> lista = LeerPersona();
            foreach (Persona cliente in lista)
            {
                if (cliente.IDC.Equals(item))
                {
                    return cliente;
                }
            }
            return null;
        }

        public IList<Persona> LeerPersona()
        {
            SqlDataReader dataReader;
            List<Persona> personas = new List<Persona>();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select * from persona";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = MapearCliente(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }

        public Persona MapearCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Persona persona = new Persona();
            persona.IDC = Convert.ToInt32((string)dataReader["Cedula"]);
            persona.Nombre = (string)dataReader["Nombre"];
            persona.Celular = (string)dataReader["Telefono"];
            persona.Correo = (string)dataReader["CorreoElectronico"];
            return persona;
        }
    }
}
