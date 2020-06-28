using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTECSANTIAGO.View
{
    public partial class VentanaDashboard : Form
    {


        public VentanaDashboard()
        {
            InitializeComponent();

            CargarCartasInformativas();


        }

        public void CargarCartasInformativas()
        {
            try
            {
                string CMD = string.Format("SELECT COUNT(cli.ID_CLIENTE) as TotalCli from clientes cli");
                DataSet ds = Mysqlcon.EjecutarConDT(CMD);

                lblTotalClientes.Text = ds.Tables[0].Rows[0]["TotalCli"].ToString().Trim();

                ////////////////////////////////////////
                string CMD2 = string.Format("SELECT COUNT(fac.ID_FACTURA_COD) as TotalServicios from facturas fac ");
                DataSet ds2 = Mysqlcon.EjecutarConDT(CMD2);

                lblTotalServicios.Text = ds2.Tables[0].Rows[0]["TotalServicios"].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta ");
            }
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
            //AHI PONEMOS EL NOMBRE DE LA SERIE QUE COLOCAMOS EN LA PROPIEDAD SERIES DEL GRAFICO
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("LUN", 100000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("MAR", 50000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("MIE", 150000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("JUE", 300000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("VIE", 300000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("SAB", 50000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("DOM", 100000);
        }
    }
}
