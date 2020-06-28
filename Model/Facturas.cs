using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTECSANTIAGO.Model
{
    public class Facturas
    {
        private int id;
        private string fecha;
        private int cliente;
        private int tecnico;

        public int Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Tecnico { get => tecnico; set => tecnico = value; }
    }
}
