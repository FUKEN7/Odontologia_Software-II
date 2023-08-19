namespace Entidad
{
    public class Persona
    {
        public Persona(int IDC, string nombre, string celular, string correo)
        {
            this.IDC = IDC;
            Nombre = nombre;
            Celular = celular;
            Correo = correo;
        }
        public Persona()
        {

        }
        public int IDC { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public  string Celular { get; set; }
    }
}
