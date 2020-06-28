using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTECSANTIAGO.Model
{
    public class Clientes
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string telefono ;
        private string correo;
       


        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    
    }
}
