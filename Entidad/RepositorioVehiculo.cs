using Entidad;
using System;
using System.Collections.Generic;
using System.IO;


namespace Data
{
    public class RepositorioVehiculo
    {

        string ruta = "Vehiculo.txt";
        public string Guardar(Vehiculo vehiculo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(vehiculo.ToString());
                escritor.Close();

                return "";
            }
            catch (Exception)
            {
                return "";
            }

        }
        public string Modificar(List<Vehiculo> vehiculo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in vehiculo)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "";

                //File.Delete(ruta);  // elimina
                //File.Move("tmp", ruta);// renombrar
            }
            catch (Exception)
            {

                return "";
            }

        }
        public string Modificar2(List<Vehiculo> vehiculo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("tmp.txt", true);// sobreescribe
                foreach (var item in vehiculo)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                File.Delete(ruta);  // elimina
                File.Move("tmp.txt", ruta);// renombrar

                return "Se modificaron los datos los datos";

            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }

        public List<Vehiculo> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Vehiculo> cuentas = new List<Vehiculo>();
                // 2. operaciones
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();

                    string Matricula = linea.Split(';')[0];
                    double Kilometro = double.Parse(linea.Split(';')[1]);
                    String Descipcion = linea.Split(';')[2];
                    Cliente cliente = new RepositorioCliente().Buscar(linea.Split(';')[3]);
                    double Precio = double.Parse(linea.Split(';')[4]);
                    Vehiculo cuenta = new Vehiculo(Matricula, Kilometro, Descipcion, cliente, Precio);
                    cuentas.Add(cuenta);


                }


                lector.Close();

                return cuentas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Encontrar(string Idregistrado, String Idbuscado)
        {
            return Idregistrado == Idbuscado;

        }
        public void Eliminar(String Placa)
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();
            vehiculo = Consultar();
            FileStream archivo = new FileStream(ruta, FileMode.Create);
            archivo.Close();
            foreach (var item in vehiculo)
            {
                if (!Encontrar(item.Matricula, Placa))
                {
                    Guardar(item);
                }
            }

        }
    }
}
