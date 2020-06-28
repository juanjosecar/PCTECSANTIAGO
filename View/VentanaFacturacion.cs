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
namespace PCTECSANTIAGO.View
{
    public partial class VentanaFacturacion : Form
    {
        public VentanaFacturacion()
        {
            InitializeComponent();
            Mysqlcon.Open(); // carga la conexion
            cargaTipoServicios();
        }

        public void Nuevo()
        {
            txtCliente.Clear();
            txtTecnico.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescripcionServicio.Clear();


            lblValorTotal.Text = "COP$ 0";
            dtgTablaFacturacion.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCliente.Focus();

        }

        public void cargaTipoServicios()
        {
            // cmbTipoServicio.Refresh();
           cmbTipoServicio.DataSource = null;
            cmbTipoServicio.DataSource = ServicioDB.ListAll();
            cmbTipoServicio.DisplayMember = "TipoServicio";
            cmbTipoServicio.ValueMember = "Id";
        }
        /// /////////////////////////////////Metodo de prueba
        public Boolean Agregar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    MessageBox.Show("Lo has hecho bien hasta ahora");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un erro al guardar!" + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

   
        /// /////////////////////////////////
    
        public static int cont_fila =0;
        public static double total;

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                //bool existe = false;
               // int num_fila = 0;

                if (cont_fila == 0)
                {
                    dtgTablaFacturacion.Rows.Add(cmbTipoServicio.SelectedValue + "", txtDescripcionServicio.Text, txtCantidad.Text, txtPrecio.Text);
                    double importe = Convert.ToDouble(dtgTablaFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dtgTablaFacturacion.Rows[cont_fila].Cells[3].Value);
                    dtgTablaFacturacion.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;

                }
                else
                {
                    dtgTablaFacturacion.Rows.Add(cmbTipoServicio.SelectedValue + "", txtDescripcionServicio.Text, txtCantidad.Text, txtPrecio.Text);
                    double importe = Convert.ToDouble(dtgTablaFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dtgTablaFacturacion.Rows[cont_fila].Cells[3].Value);
                    dtgTablaFacturacion.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                }
                }

                ///////////Aqui calculamos el total de los importes
                total = 0;

                foreach (DataGridViewRow Fila in dtgTablaFacturacion.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
            lblValorTotal.Text = "$COP " + total.ToString();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescripcionServicio.Clear();

            }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dtgTablaFacturacion.Rows[dtgTablaFacturacion.CurrentRow.Index].Cells[4].Value));
                lblValorTotal.Text = "$COP " + total.ToString();

                dtgTablaFacturacion.Rows.RemoveAt(dtgTablaFacturacion.CurrentRow.Index);

                cont_fila--;
            }
        }

        public static int IDCliente =0;
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarCli = new BuscarCliente();
            BuscarCli.ShowDialog();

            if(BuscarCli.DialogResult == DialogResult.OK){
                IDCliente = Convert.ToInt32(BuscarCli.TablaBuscarCliente.Rows[BuscarCli.TablaBuscarCliente.CurrentRow.Index].Cells[0].Value.ToString());
                lblIDCliente.Text = IDCliente +"";
               string  nombresCli = BuscarCli.TablaBuscarCliente.Rows[BuscarCli.TablaBuscarCliente.CurrentRow.Index].Cells[1].Value.ToString();
               string apellidosCli = BuscarCli.TablaBuscarCliente.Rows[BuscarCli.TablaBuscarCliente.CurrentRow.Index].Cells[2].Value.ToString();

                txtCliente.Text = nombresCli +" "+ apellidosCli;
                txtTecnico.Focus();
            }
        }
        public static int IDTecnico = 0;
        private void btnBuscarTecnico_Click(object sender, EventArgs e)
        {
            BuscarTecnico BuscarTec = new BuscarTecnico();
            BuscarTec.ShowDialog();

            if (BuscarTec.DialogResult == DialogResult.OK)
            {
                IDTecnico = Convert.ToInt32(BuscarTec.TablaBuscarTecnico.Rows[BuscarTec.TablaBuscarTecnico.CurrentRow.Index].Cells[0].Value.ToString());
                lblIDTecnico.Text = IDTecnico + "";
                string nombresTec = BuscarTec.TablaBuscarTecnico.Rows[BuscarTec.TablaBuscarTecnico.CurrentRow.Index].Cells[1].Value.ToString();
                string apellidosTec = BuscarTec.TablaBuscarTecnico.Rows[BuscarTec.TablaBuscarTecnico.CurrentRow.Index].Cells[2].Value.ToString();

                txtTecnico.Text = nombresTec + " " + apellidosTec;

                txtCantidad.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtTecnico_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtDescripcionServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0)
            {
                try
                {
                    //METODO PARA OBTENER EL MAX ID DE FACTURA
                    string cmd1 = string.Format("SELECT MAX(ID_FACTURA_COD) AS MaxNumFact from facturas");
                    DataSet ds1 = Mysqlcon.EjecutarConDT(cmd1);
                  
                //    string MaxNumFact =ds1.Tables[0].Rows[0]["MaxNumFact"].ToString().Trim();
                    string MaxNumFact = ds1.Tables[0].Rows[0]["MaxNumFact"].ToString();

                    int numFac = 0;
                    if (MaxNumFact == ""){
                        // numFac = Convert.ToInt32(MaxNumFact);
                        numFac =  0;
                        numFac = numFac + 1;
                    }
                    else{
                        numFac = Convert.ToInt32(MaxNumFact);
                        numFac = numFac + 1;
                    }

                    //
                    string cmd = string.Format("CALL ActualizarFacturas ('{0}','{1}','{2}') ", lblIDCliente.Text.Trim(),lblIDTecnico.Text.Trim(),numFac);

                    DataSet ds = Mysqlcon.EjecutarConDT(cmd);
                    string NumFac = ds.Tables[0].Rows[0]["ID_FACTURA_COD"].ToString().Trim();

                    foreach (DataGridViewRow Fila in dtgTablaFacturacion.Rows)
                    {

                        cmd = string.Format("CALL ActualizaDetalles ('{0}','{1}','{2}','{3}','{4}')", NumFac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString(), Fila.Cells[1].Value.ToString());
                        ds = Mysqlcon.EjecutarConDT(cmd);


                    }

                  
                    Nuevo();
                    Mysqlcon.Open();
                    int IDFACTURA =Convert.ToInt32(NumFac);
                    //Imprimiendo Factura
                    ImprimirFactura.FacturaPDF(IDFACTURA);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }
            }
        }

        private void VentanaFacturacion_Load(object sender, EventArgs e)
        {
            lblUserEnSesion.Text = "    "+VentanaLogin.NombresTecnico;
        }
    }
    }

