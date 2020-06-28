using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCTECSANTIAGO.Controller;
using PCTECSANTIAGO.Model;
using LibreriaValidaciones_PCTECSANTIAGO;
using PCTECSANTIAGO.View;

namespace PCTECSANTIAGO
{
    public partial class VentanaServicios : Form
    {
        public VentanaServicios()
        {
            InitializeComponent();
            CargarDatosTabla();
        }
        public static  DataSet LlenarDataGV()
        {
            DataSet DS;
            string cmd = string.Format("SELECT fac.ID_FACTURA_COD as Codigo, fac.FAC_FECHA_FACTURA as Fecha," +
                "CONCAT(cli.CLI_NOMBRES_CLIENTE,' ',cli.CLI_APELLIDOS_CLIENTE) as Cliente," +
                "det.DET_DESCRIPCION_SERVICIOS as 'Descripcion'," +
                " ser.SER_TIPO_SERVICIO as 'Tipo de Servicio', " +
                "concat(tec.TEC_NOMBRES_TECNICO,' ',tec.TEC_APELLIDOS_TECNICO) AS Tecnico," +
                " det.DET_CANTIDAD_SERVICIO as 'Cantidad', det.DET_PRECIO_SERVICIOS as 'Precio', " +
                "  (det.DET_CANTIDAD_SERVICIO * det.DET_PRECIO_SERVICIOS) AS 'Total Servicio'" +
                " FROM facturas fac inner join detalle_facturas  det on fac.ID_FACTURA_COD = det.FACTURAS_ID_FACTURA_COD" +
                " inner join servicios ser on ser.ID_SERVICIO = det.SERVICIOS_ID_SERVICIO" +
                " inner join clientes cli on fac.CLIENTE_ID_CLIENTE = cli.ID_CLIENTE" +
                " inner join tecnicos tec on fac.TECNICOS_ID_TECNICO = tec.ID_TECNICO" +
             
                " order by fac.ID_FACTURA_COD");
            DS = Mysqlcon.EjecutarConDT(cmd);
            return DS;
        }

        public static DataSet LLenarTablaXCliente(string NombreCli)
        {
            DataSet DS;
            string cmd = string.Format("SELECT fac.ID_FACTURA_COD as Codigo, fac.FAC_FECHA_FACTURA as Fecha," +
                 "CONCAT(cli.CLI_NOMBRES_CLIENTE,' ',cli.CLI_APELLIDOS_CLIENTE) as Cliente," +
                 "det.DET_DESCRIPCION_SERVICIOS as 'Descripcion'," +
                 " ser.SER_TIPO_SERVICIO as 'Tipo de Servicio', " +
                 "concat(tec.TEC_NOMBRES_TECNICO,' ',tec.TEC_APELLIDOS_TECNICO) AS Tecnico," +
                 " det.DET_CANTIDAD_SERVICIO as 'Cantidad', det.DET_PRECIO_SERVICIOS as 'Precio', " +
                 "  (det.DET_CANTIDAD_SERVICIO * det.DET_PRECIO_SERVICIOS) AS 'Total Servicio'" +
                 " FROM facturas fac inner join detalle_facturas  det on fac.ID_FACTURA_COD = det.FACTURAS_ID_FACTURA_COD" +
                 " inner join servicios ser on ser.ID_SERVICIO = det.SERVICIOS_ID_SERVICIO" +
                 " inner join clientes cli on fac.CLIENTE_ID_CLIENTE = cli.ID_CLIENTE" +
                 " inner join tecnicos tec on fac.TECNICOS_ID_TECNICO = tec.ID_TECNICO" +
                 " WHERE cli.CLI_NOMBRES_CLIENTE LIKE '%" + NombreCli + "%'" +
                 " order by fac.ID_FACTURA_COD");
            DS = Mysqlcon.EjecutarConDT(cmd);
            return DS;
        }

       public void CargarDatosTabla()
        {
            dtgServiciosRealizados.DataSource = LlenarDataGV().Tables[0];
            // Ajustando la tabla
            dtgServiciosRealizados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
        public void CargarDatosTablaXCliente(string NomCli)
        {
            dtgServiciosRealizados.DataSource = LLenarTablaXCliente(NomCli).Tables[0];
            // Ajustando la tabla
            dtgServiciosRealizados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgServiciosRealizados.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
        public void  CargarCartasInformativas()
        {
            try
            {
                string CMD = string.Format("SELECT COUNT(fac.ID_FACTURA_COD) as TotalServicios from facturas fac ");
                DataSet ds = Mysqlcon.EjecutarConDT(CMD);

                lblTotalServicios.Text = ds.Tables[0].Rows[0]["TotalServicios"].ToString().Trim();

               

            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta ");
            }
        }
        private void VentanaServicios_Load(object sender, EventArgs e)
        {
            CargarCartasInformativas();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(dtgServiciosRealizados.DataSource != null)
            {
                int IdFactura = Convert.ToInt32(dtgServiciosRealizados.Rows[dtgServiciosRealizados.CurrentRow.Index].Cells[0].Value);
                //Imprimiendo Factura
                Mysqlcon.Open();
                ImprimirFactura.FacturaPDF(IdFactura);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgServiciosRealizados.DataSource != null)
            {
                int IdFactura = Convert.ToInt32(dtgServiciosRealizados.Rows[dtgServiciosRealizados.CurrentRow.Index].Cells[0].Value);
                //Eliminando Factura
                Mysqlcon.Open();
                FacturaDB.EliminarFactura(IdFactura);
                CargarDatosTabla();
                CargarCartasInformativas();
            }
        }

        private void txtBuscarClienteFiltrado_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarClienteFiltrado.Clear();
        }

        private void txtBuscarClienteFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarClienteFiltrado.Text != "")
            {
                CargarDatosTablaXCliente(txtBuscarClienteFiltrado.Text);
            }
            else
            {
                CargarDatosTabla();
            }
        }
    }
}
