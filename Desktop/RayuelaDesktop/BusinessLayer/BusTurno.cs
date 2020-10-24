using DataLayer;
using EntityLayer;
using System.Data;

namespace BusinessLayer
{
    public class BusTurno
    {
        private DataTurno _dataTurno;
        public BusTurno()
        {
            _dataTurno = new DataTurno();
        }

        public int CargarTurno(Turno turno)
        {
            return _dataTurno.CargarTurno(turno);
        }

        public DataTable TraerHorariosDesocupados(string Fecha)
        {
            return _dataTurno.TraerHorariosDesocupados(Fecha);
        }


    }
}
