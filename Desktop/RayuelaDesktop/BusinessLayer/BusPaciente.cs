using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
