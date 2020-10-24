using DataLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BusHorarios
    {
        private DataHorarios _dataHorarios;

        public BusHorarios()
        {
            _dataHorarios = new DataHorarios();
        }

        public Horarios SeleccionDeHorario(int Id, Horarios _horarios)
        {
            return _dataHorarios.SeleccionDeHorario(Id, _horarios);
        }
    }
}
