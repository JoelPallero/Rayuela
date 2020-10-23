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
        private string nombreApellido;
        private string tipoDocumento;
        private int nroDocumento;

        public int Id { get => id; set => id = value; }
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
    }
}
