using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidad;

namespace Logica
{
    public class PacienteService
    {
        Manejador manejador;
        PacienteRepository repository;
        public PacienteService(string cadenaConexion)
        {
            manejador = new Manejador(cadenaConexion);
            repository = new PacienteRepository(manejador);
        }

        public string Guardar(Paciente paciente)
        {
            try
            {
                manejador.Open();
                repository.Guardar(paciente);
                return "Se Guardo Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            finally
            {
                manejador.Close();
            }
        }

        public string Eliminar(Paciente paciente)
        {
            try
            {
                manejador.Open();
                repository.Eliminar(paciente);
                return "Se Elimino Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            finally
            {
                manejador.Close();
            }
        }

        public string Editar(Paciente paciente)
        {
            try
            {
                manejador.Open();
                repository.Modificar(paciente);
                return "Se Edito Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            finally
            {
                manejador.Close();
            }
        }

        public Response Consultar()
        {
            Response respuesta = new Response();
            try
            {
                manejador.Open();
                respuesta.pacientes = repository.LeerPaciente();
                manejador.Close();
                respuesta.error = false;
            }
            catch (Exception E)
            {
                respuesta.error = true;
                respuesta.Mensaje = "Error de la aplicación: " + E.Message;
            }
            finally
            {
                manejador.Close();
            }
            return respuesta;
        }

        public Response ConsultarPorNitOCedula(string cedula)
        {
            Response respuesta = new Response();
            try
            {
                manejador.Open();
                respuesta.pacientes = repository.ConsultaPorCedula(cedula);
                manejador.Close();
                respuesta.error = false;
            }
            catch (Exception E)
            {
                respuesta.error = true;
                respuesta.Mensaje = "Error de la aplicación: " + E.Message;
            }
            finally
            {
                manejador.Close();
            }
            return respuesta;
        }

        public Response ConsultarPorNombre(string nombre)
        {
            Response respuesta = new Response();
            try
            {
                manejador.Open();
                respuesta.pacientes = repository.ConsultaPorNombre(nombre);
                manejador.Close();
                respuesta.error = false;
            }
            catch (Exception E)
            {
                respuesta.error = true;
                respuesta.Mensaje = "Error de la aplicación: " + E.Message;
            }
            finally
            {
                manejador.Close();
            }
            return respuesta;
        }
    }
}
