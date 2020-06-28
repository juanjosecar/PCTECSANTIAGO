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
    public class TecnicosDB
    {
        public static string SQL;

        public static void Insertar(Tecnicos ob)
        {

            SQL = "insert into tecnicos(TEC_NOMBRES_TECNICO," +
                "TEC_APELLIDOS_TECNICO,TEC_CEDULA_TECNICO,TEC_DIRECCION_TECNICO," +
                "TEC_CORREO_TECNICO,USER_ACCOUNT,TEC_PASSWORD_TECNICO" +
                ",CREATED,MODIFIED) " +
                 " Values ('" + ob.Nombres_tec + "','" + ob.Apellidos_tec +
                 "','" + ob.Cedula_tec + "','" + ob.Direccion_tec  +"','" + ob.Correo_tec + "','" 
                 + ob.UserAccount + "','" + ob.Contrasena_tec + "',CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";

            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Tecnico Registrado");
            else
                MessageBox.Show("Error al registrar el tecnico");
        }

        public static List<Tecnicos> ListAll()
        {
            List<Tecnicos> tecnico = null;
            SQL = "Select * from tecnicos";
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            tecnico = new List<Tecnicos>();
            Tecnicos ob;
            while (reg.Read())
            {
                ob = new Tecnicos();
                ob.Id = Convert.ToInt32(reg["ID_TECNICO"].ToString());
                ob.Nombres_tec = reg["TEC_NOMBRES_TECNICO"].ToString();
                ob.Apellidos_tec = reg.GetString("TEC_APELLIDOS_TECNICO");
                ob.Cedula_tec = reg.GetString("TEC_CEDULA_TECNICO");
                ob.Direccion_tec = reg.GetString("TEC_DIRECCION_TECNICO");
                ob.Correo_tec = reg.GetString("TEC_CORREO_TECNICO");
                ob.Contrasena_tec = reg.GetString("TEC_PASSWORD_TECNICO");
                ob.UserAccount = reg.GetString("USER_ACCOUNT");
            
                tecnico.Add(ob);
            }
            reg.Close();
            return tecnico;
        }

        public static void Eliminar(int id)
        {
            SQL = "delete from tecnicos Where ID_TECNICO=" + id;
            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Tecnico Eliminado");
            else
                MessageBox.Show("Error al eliminar el tecnico seleccionado");
        }

        public static List<Tecnicos> BuscarTecnicoXfiltro(string filtro)
        {
            List<Tecnicos> tecnico = null;
            SQL = "Select * from tecnicos where TEC_NOMBRES_TECNICO Like '%" + filtro + "%'";
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            tecnico = new List<Tecnicos>();
            Tecnicos ob;
            while (reg.Read())
            {
                ob = new Tecnicos();
                ob.Id = Convert.ToInt32(reg["ID_TECNICO"].ToString());
                ob.Nombres_tec = reg["TEC_NOMBRES_TECNICO"].ToString();
                ob.Apellidos_tec = reg.GetString("TEC_APELLIDOS_TECNICO");
                ob.Cedula_tec = reg.GetString("TEC_CEDULA_TECNICO");
                ob.Direccion_tec = reg.GetString("TEC_DIRECCION_TECNICO");
                ob.Correo_tec = reg.GetString("TEC_CORREO_TECNICO");
                ob.Contrasena_tec = reg.GetString("TEC_PASSWORD_TECNICO");
                ob.UserAccount = reg.GetString("USER_ACCOUNT");
                tecnico.Add(ob);
            }
            reg.Close();
            return tecnico;
        }

        public static Tecnicos Buscar(int id)
        {
            SQL = "Select * from tecnicos where ID_TECNICO =" + id;
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            Tecnicos ob = null;
            if (reg.Read())
            {
                ob = new Tecnicos();
                ob.Id = Convert.ToInt32(reg["ID_TECNICO"].ToString());
                ob.Nombres_tec = reg["TEC_NOMBRES_TECNICO"].ToString();
                ob.Apellidos_tec = reg.GetString("TEC_APELLIDOS_TECNICO");
                ob.Cedula_tec = reg.GetString("TEC_CEDULA_TECNICO");
                ob.Direccion_tec = reg.GetString("TEC_DIRECCION_TECNICO");
                ob.Correo_tec = reg.GetString("TEC_CORREO_TECNICO");
                ob.UserAccount = reg.GetString("USER_ACCOUNT");
            }
            reg.Close();
            return ob;
        }

        public static void Actualizar(Tecnicos ob)
        {
            SQL = "update tecnicos set TEC_NOMBRES_TECNICO='" + ob.Nombres_tec + "',TEC_APELLIDOS_TECNICO='" +
                ob.Apellidos_tec + "',TEC_CEDULA_TECNICO='" + ob.Cedula_tec + "',TEC_DIRECCION_TECNICO='" + ob.Direccion_tec +
                 "',TEC_CORREO_TECNICO='" + ob.Correo_tec + "',USER_ACCOUNT='" + ob.UserAccount +
                 "',TEC_PASSWORD_TECNICO='" + ob.Contrasena_tec +
                "' where ID_TECNICO =" + ob.Id;
            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Datos del tecnico actualizados");
            else
                MessageBox.Show("Error al actualizar");
        }


    }
}
