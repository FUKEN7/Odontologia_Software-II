using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logica
{
    public class Response
    {
        public IList<Paciente> pacientes { get; set; }
        public IList<Persona> personas { get; set; }
        public string Mensaje { get; set; }
        public bool error { get; set; }
    }
}
