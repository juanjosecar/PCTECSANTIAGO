using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTECSANTIAGO.Model
{
    public class Servicios
    {
        private int id;
        private string tipoServicio;

        public int Id { get => id; set => id = value; }
        public string TipoServicio { get => tipoServicio; set => tipoServicio = value; }
    }
}
