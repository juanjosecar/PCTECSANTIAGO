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
    class ClienteDB
    {
        public static string SQL;

        public static void Insertar(Clientes ob)
        {

            SQL = "insert into clientes(CLI_NOMBRES_CLIENTE," +
                "CLI_APELLIDOS_CLIENTE,CLI_TELEFONO_CLIENTE,CLI_CORREO_CLIENTE,CREATED,MODIFIED) " +
                 " Values ('" + ob.Nombres + "','" + ob.Apellidos +
                 "','" + ob.Telefono + "','"+ob.Correo + "',CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";

            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Registro Guardado");
            else
                MessageBox.Show("Error al Guardar");
        }

        public static List<Clientes> ListAll()
        {
            List<Clientes> cliente = null;
            SQL = "Select * from clientes";
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            cliente = new List<Clientes>();
            Clientes ob;
            while (reg.Read())
            {
                ob = new Clientes();
                ob.Id = Convert.ToInt32(reg["ID_CLIENTE"].ToString());
                ob.Nombres = reg["CLI_NOMBRES_CLIENTE"].ToString();
                ob.Apellidos = reg.GetString("CLI_APELLIDOS_CLIENTE");
                ob.Telefono = reg.GetString("CLI_TELEFONO_CLIENTE");
                ob.Correo = reg.GetString("CLI_CORREO_CLIENTE");
              

                cliente.Add(ob);
            }
            reg.Close();
            return cliente;
        }

        public static void Eliminar(int id)
        {
            SQL = "delete from clientes Where ID_CLIENTE=" + id;
            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Cliente Eliminado");
            else
                MessageBox.Show("Error al eliminar el cliente seleccionado");
        }

        public static List<Clientes> BuscarClienteXfiltro(string filtro)
        {
            List<Clientes> cliente = null;
            SQL = "Select * from clientes where CLI_NOMBRES_CLIENTE Like '%" + filtro + "%'";
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            cliente = new List<Clientes>();
            Clientes ob;
            while (reg.Read())
            {
                ob = new Clientes();
                ob.Id = Convert.ToInt32(reg["ID_CLIENTE"].ToString());
                ob.Nombres = reg["CLI_NOMBRES_CLIENTE"].ToString();
                ob.Apellidos = reg.GetString("CLI_APELLIDOS_CLIENTE");
                ob.Telefono = reg.GetString("CLI_TELEFONO_CLIENTE");
                ob.Correo = reg.GetString("CLI_CORREO_CLIENTE");
                cliente.Add(ob);
            }
            reg.Close();
            return cliente;
        }

        public static Clientes Buscar(int id)
        {
            SQL = "Select * from clientes where ID_CLIENTE =" + id;
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            Clientes ob = null;
            if (reg.Read())
            {
                ob = new Clientes();
                ob.Id = Convert.ToInt32(reg["ID_CLIENTE"].ToString());
                ob.Nombres = reg["CLI_NOMBRES_CLIENTE"].ToString();
                ob.Apellidos = reg.GetString("CLI_APELLIDOS_CLIENTE");
                ob.Telefono = reg.GetString("CLI_TELEFONO_CLIENTE");
                ob.Correo = reg.GetString("CLI_CORREO_CLIENTE");

            }
            reg.Close();
            return ob;
        }

        public static void Actualizar(Clientes ob)
        {
            SQL = "update clientes set CLI_NOMBRES_CLIENTE='" + ob.Nombres + "',CLI_APELLIDOS_CLIENTE='" +
                ob.Apellidos + "',CLI_TELEFONO_CLIENTE='" + ob.Telefono + "',CLI_CORREO_CLIENTE='" + ob.Correo+
                "' where ID_CLIENTE =" + ob.Id;
            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Datos del cliente actualizados");
            else
                MessageBox.Show("Error al actualizar");
        }

    }

}
