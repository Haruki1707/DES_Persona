namespace Persona.Models
{
    public class Persona
    {
        public int ID { get; set; }

        public string DUI { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateOnly FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public string Correo { get; set; }
    }
}
