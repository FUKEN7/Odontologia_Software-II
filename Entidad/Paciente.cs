using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Entidad
{
    public class Paciente : Persona
    {
        public new int IDC { get; set; }
        public new string Nombre { get; set; }
        public new string Celular { get; set; }
        public new string Correo { get; set; }
        public string Recomedacion { get; set; }
        public string Descricion { get; set; }

        public string Fecha { get; set; }




        public Paciente()
        {
        }

        public Paciente(int IDC, string nombre, string celular, string correo, string descricion, string fecha, string recomendacion)
        {
        
            this.IDC =  IDC;
            Nombre = nombre;
            Celular = celular;
            Correo = correo;
            Recomedacion = recomendacion;
            Descricion = descricion;
            Fecha = fecha;
        }
        
    }
}
