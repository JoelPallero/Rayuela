namespace EntityLayer
{
    public class Terapeuta
    {
        private int id;
        private string nombreApellido;
        private string contraseña;
        private string terapia;

        public int Id { get => id; set => id = value; }
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Terapia { get => terapia; set => terapia = value; }
    }
}
