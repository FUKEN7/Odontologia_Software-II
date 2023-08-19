using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Manejador
    {
        public SqlConnection connection;

        public Manejador(string cadenaConexion)
        {
            connection = new SqlConnection(cadenaConexion);
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
