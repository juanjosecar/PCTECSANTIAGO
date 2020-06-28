using PCTECSANTIAGO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PCTECSANTIAGO.Controller
{
    public class ServicioDB
    {
        public static string SQL;
        public static List<Servicios> ListAll()
        {
            List<Servicios> servicio = null;
            SQL = "Select * from servicios";
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            servicio = new List<Servicios>();
            Servicios ob;
            while (reg.Read())
            {
                ob = new Servicios();
                ob.Id = Convert.ToInt32(reg["ID_SERVICIO"].ToString());
                ob.TipoServicio = reg["SER_TIPO_SERVICIO"].ToString();
            

                servicio.Add(ob);
            }
            reg.Close();
            return servicio;
        }
    }
}
