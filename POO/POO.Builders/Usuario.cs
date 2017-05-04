namespace POO.Builders
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Usuario()
        {
        }

        public Usuario(string id, string dni, string nombre, string apellido)
        {
            Id = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
