using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Paciente : Persona
    {
        private string obraSocial;
        private int nroAfiliado;
        private string certificadoDiscapacidad;
        private int nroCarnetDiscapacidad;
        private string terapia;

        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public int NroAfiliado { get => nroAfiliado; set => nroAfiliado = value; }
        public string CertificadoDiscapacidad { get => certificadoDiscapacidad; set => certificadoDiscapacidad = value; }
        public int NroCarnetDiscapacidad { get => nroCarnetDiscapacidad; set => nroCarnetDiscapacidad = value; }
        public string Terapia { get => terapia; set => terapia = value; }
    }
}
