using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Terapeuta : Persona
    {
        private string terapia;

        public string Terapia { get => terapia; set => terapia = value; }
    }
}
