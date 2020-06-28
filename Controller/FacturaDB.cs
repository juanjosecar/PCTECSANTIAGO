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
    public class FacturaDB
    {
        public static string SQL;

        public static List<Facturas> ObtenerDatosFactura(int IdFactura)
        {

            List<Facturas> factura = null;
            SQL = "SELECT * from  facturas where  ID_FACTURA_COD =" + IdFactura;
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            factura = new List<Facturas>();
            Facturas ob;
            while (reg.Read())
            {
                ob = new Facturas();
                ob.Id = reg.GetInt32("ID_FACTURA_COD"); ;
                ob.Fecha = reg["FAC_FECHA_FACTURA"].ToString();




                factura.Add(ob);
            }
            reg.Close();
            return factura;
        }

      
        public static Clientes ObtenerDatosCliente(int IdFactura)
        {
            SQL = "SELECT cli.ID_CLIENTE,cli.CLI_NOMBRES_CLIENTE,cli.CLI_APELLIDOS_CLIENTE, cli.CLI_TELEFONO_CLIENTE,cli.CLI_CORREO_CLIENTE " +
                "FROM facturas fac inner join clientes  cli on fac.CLIENTE_ID_CLIENTE= cli.ID_CLIENTE" +
                " where fac.ID_FACTURA_COD = " + IdFactura;
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
        public static Tecnicos ObtenerDatosTecnico(int IdFactura)
        {
            SQL = "SELECT tec.ID_TECNICO,tec.TEC_NOMBRES_TECNICO, tec.TEC_APELLIDOS_TECNICO,tec.TEC_CORREO_TECNICO" +
                " FROM facturas fac inner join tecnicos  tec on fac.TECNICOS_ID_TECNICO= tec.ID_TECNICO" +
                " where fac.ID_FACTURA_COD =" + IdFactura;
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            Tecnicos ob = null;
            if (reg.Read())
            {
                ob = new Tecnicos();
                ob.Id = Convert.ToInt32(reg["ID_TECNICO"].ToString());
                ob.Nombres_tec = reg["TEC_NOMBRES_TECNICO"].ToString();
                ob.Apellidos_tec = reg.GetString("TEC_APELLIDOS_TECNICO");
                ob.Correo_tec = reg.GetString("TEC_CORREO_TECNICO");
          
            }
            reg.Close();
            return ob;
        }

        public static List<DetalleFacturas> ObtenerDatosDetalleFactura(int IdFactura)
        {

            List<DetalleFacturas> det_factura = null;
            SQL = "SELECT det.ID_DETALLE_FACTURAS, ser.SER_TIPO_SERVICIO, det.DET_CANTIDAD_SERVICIO,det.DET_PRECIO_SERVICIOS,det.DET_DESCRIPCION_SERVICIOS" +
                " FROM facturas fac inner join detalle_facturas  det on fac.ID_FACTURA_COD = det.FACTURAS_ID_FACTURA_COD" +
                " inner join servicios ser on ser.ID_SERVICIO = det.SERVICIOS_ID_SERVICIO" +
                " where fac.ID_FACTURA_COD =" + IdFactura;
            MySqlDataReader reg = Mysqlcon.Query(SQL);
            det_factura = new List<DetalleFacturas>();
            DetalleFacturas ob;
            while (reg.Read())
            {
                ob = new DetalleFacturas();
                ob.Id_Det_Facturas = reg.GetInt32("ID_DETALLE_FACTURAS"); 
                ob.Tipo_servicio = reg.GetString("SER_TIPO_SERVICIO");
                ob.Cantidad = reg.GetInt32("DET_CANTIDAD_SERVICIO");
                ob.Precio = reg.GetInt32("DET_PRECIO_SERVICIOS");
                ob.Descripcion = reg.GetString("DET_DESCRIPCION_SERVICIOS");





                det_factura.Add(ob);
            }
            reg.Close();
            return det_factura;
        }


        public static void EliminarFactura(int id)
        {
            SQL = "DELETE FROM facturas WHERE ID_FACTURA_COD =" + id;
            if (Mysqlcon.Execute(SQL))
                MessageBox.Show("Factura Eliminada");
            else
                MessageBox.Show("Error al eliminar la factura seleccionada");
        }

    }
}
