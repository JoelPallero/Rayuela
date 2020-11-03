using System;

namespace EntityLayer
{
    public class Turno
    {
        private int id;
        private DateTime dia;
        private DateTime horaInicio;
        private DateTime horaFin;
        private int pacienteId;
        private int terapeutaId;

        public int Id { get => id; set => id = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        public int TerapeutaId { get => terapeutaId; set => terapeutaId = value; }
    }
}
