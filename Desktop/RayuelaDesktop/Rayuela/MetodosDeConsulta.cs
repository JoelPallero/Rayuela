using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class MetodosDeConsulta
    {
        #region Instancias
        private Paciente _paciente = new Paciente();
        private BusPaciente _busPaciente = new BusPaciente();
        #endregion

        #region Variables
        public int IdPaciente;
        public int IdTerapeuta;
        #endregion

        public void ConsultarIdPaciente()
        {
            _paciente = _busPaciente.ConsutlarIdPaciente(_paciente);
            IdPaciente = _paciente.Id;
        }

        public void ConsultarIdTerapeuta(string terapeuta)
        {

        }
    }
}
