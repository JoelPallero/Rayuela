using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusTerapeuta
    {
        private readonly DataTerapeuta _dataTerapeuta;

        public BusTerapeuta()
        {
            _dataTerapeuta = new DataTerapeuta();
        }

        public int NuevoTerapeuta(Terapeuta _terapeuta)
        {
            return _dataTerapeuta.NuevoTerapeuta(_terapeuta);
        }

        public DataTable TraerTerapeutas()
        {
            return _dataTerapeuta.TraerTerapeutas();
        }

    }
}
