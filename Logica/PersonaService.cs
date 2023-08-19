using Data;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PersonaService
    {
        Manejador manejador;
        PersonaRepository repository;
        public PersonaService(string cadenaConexion)
        {
            manejador = new Manejador(cadenaConexion);
            repository = new PersonaRepository(manejador);
        }

        public string Guardar(Persona persona)
        {
            try
            {
                manejador.Open();
                repository.Guardar(persona);
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

        public string Eliminar(Persona persona)
        {
            try
            {
                manejador.Open();
                repository.Eliminar(persona);
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

        public string Editar(Persona persona)
        {
            try
            {
                manejador.Open();
                repository.Modificar(persona);
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
                respuesta.personas = repository.LeerPersona();
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
