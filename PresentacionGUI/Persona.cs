namespace Entidad
{
    public class Persona
    {
        public Persona(string IDC, string nombre, int celular, string correo)
        {
            this.IDC = IDC;
            Nombre = nombre;
            Celular = celular;
            Correo = correo;
        }
        public Persona()
        {

        }
        public string IDC { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public  double Celular { get; set; }
    }
}
