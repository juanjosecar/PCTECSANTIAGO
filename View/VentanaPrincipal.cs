using PCTECSANTIAGO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTECSANTIAGO
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuSidebar_Click(object sender, EventArgs e)
        {
            if (SidebarGradient.Width == 270)
            {
                SidebarGradient.Visible = false;
                SidebarGradient.Width = 68;
                SidebarWrapper.Width = 90;
                lineaSidebar.Width = 52;
                AnimacionSidebar1.Show(SidebarGradient);

                //LOGO PCTECSANTIAGO
                ImgenSidebarLogo.Visible =false;
                PCTEC_SANTIAGO_logoMini_.Visible = true;
            }
            else
            {
                SidebarGradient.Visible = false;
                SidebarGradient.Width = 270;
                SidebarWrapper.Width = 300;
                lineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(SidebarGradient);

                //LOGO PCTECSANTIAGO
                ImgenSidebarLogo.Visible = true;
                PCTEC_SANTIAGO_logoMini_.Visible = false;

            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
            //AHI PONEMOS EL NOMBRE DE LA SERIE QUE COLOCAMOS EN LA PROPIEDAD SERIES DEL GRAFICO
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("LUNES", 100000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("MARTES", 50000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("MIERCOLES", 150000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("JUEVES", 300000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("VIERNES", 300000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("SABADO", 50000);
            this.GraficoIngresos.Series["ChartLinea"].Points.AddXY("DOMINGO", 100000);

        }

        private void SidebarGradient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormHijo(object formhijo)
        {

            //aqui preguntamos si hay algun control en el interior del panel
            //de ser true lo eliminamos

            if (this.Wrapper.Controls.Count > 0)
                this.Wrapper.Controls.RemoveAt(0);

            //Aqui creamos un formulario con un nombre fh y decimos que es 
            //igual al objeto que recibe la funcion y aeste objeto lo convertiomos a un formulario con la palabra as
            Form fh = formhijo as Form;


            fh.TopLevel = false; //con esto decimos que no es form de nivel superior// es decir secundario
            fh.Dock = DockStyle.Fill; // Para que se acople a todo el panel contenedor.
            this.Wrapper.Controls.Add(fh); // Lo agregamos al panel. 
            this.Wrapper.Tag = fh; //Establecemos la instancia como contenedor de datos de nuestro panel.
            fh.Show();//lo mostramos

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaDashboard());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaClientes());
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaTecnicos());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
                     AbrirFormHijo(new VentanaFacturacion());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaServicios());
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaDashboard());
        }
    }
}
