namespace EntityLayer
{
    public class Paciente : Persona
    {
        private string obraSocial;
        private string nroAfiliado;
        private string certificadoDiscapacidad;
        private string nroCarnetDiscapacidad;
        private string terapia;

        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public string NroAfiliado { get => nroAfiliado; set => nroAfiliado = value; }
        public string CertificadoDiscapacidad { get => certificadoDiscapacidad; set => certificadoDiscapacidad = value; }
        public string NroCarnetDiscapacidad { get => nroCarnetDiscapacidad; set => nroCarnetDiscapacidad = value; }
        public string Terapia { get => terapia; set => terapia = value; }
    }
}
