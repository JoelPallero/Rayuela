namespace EntityLayer
{
    public class Turno
    {
        private int id;
        private string dia;
        private int horaInicio;
        private int horaFin;
        private int pacienteId;
        private int terapeutaId;

        public int Id { get => id; set => id = value; }
        public string Dia { get => dia; set => dia = value; }
        public int HoraInicio { get => horaInicio; set => horaInicio = value; }
        public int HoraFin { get => horaFin; set => horaFin = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        public int TerapeutaId { get => terapeutaId; set => terapeutaId = value; }
    }
}
