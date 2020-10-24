namespace EntityLayer
{
    public class Persona
    {
        private int id;
        private string nombreApellido;
        private string tipoDocumento;
        private string nroDocumento;

        public int Id { get => id; set => id = value; }
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }
    }
}
