using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string tipoDocumento;
        private int nroDocumento;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
    }
}
