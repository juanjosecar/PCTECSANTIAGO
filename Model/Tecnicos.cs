using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTECSANTIAGO.Model
{
    public class Tecnicos
    {
        private int id;
        private string nombres_tec;
        private string apellidos_tec;
        private string cedula_tec ;
        private string direccion_tec;
        private string correo_tec;
        private string userAccount;
        private string contrasena_tec;

        public int Id { get => id; set => id = value; }
        public string Nombres_tec { get => nombres_tec; set => nombres_tec = value; }
        public string Apellidos_tec { get => apellidos_tec; set => apellidos_tec = value; }
        public string Cedula_tec { get => cedula_tec; set => cedula_tec = value; }
        public string Direccion_tec { get => direccion_tec; set => direccion_tec = value; }
        public string Correo_tec { get => correo_tec; set => correo_tec = value; }
        public string Contrasena_tec { get => contrasena_tec; set => contrasena_tec = value; }
        public string UserAccount { get => userAccount; set => userAccount = value; }
    }
}
