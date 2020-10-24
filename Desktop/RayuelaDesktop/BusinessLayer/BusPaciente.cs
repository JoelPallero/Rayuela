using DataLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BusPaciente
    {
        private readonly DataPaciente _dataPaciente;
        public BusPaciente()
        {
            _dataPaciente = new DataPaciente();
        }

        public int SavePaciente(Paciente _paciente)
        {
            return _dataPaciente.NuevoPaciente(_paciente);
        }

        public Paciente ConsutlarIdPaciente(Paciente _paciente)
        {
            return _dataPaciente.ConsutlarIdPaciente(_paciente);
        }

        public Paciente BuscarPaciente(string dni, Paciente _paciente)
        {
            return _dataPaciente.BuscarPaciente(dni, _paciente);
        }

    }
}
