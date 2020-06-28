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



namespace PCTECSANTIAGO
{
    public partial class VentanaClientes : Form
    {
        private Clientes cli;
        public VentanaClientes()
        {
            InitializeComponent();
            Mysqlcon.Open(); // carga la conexion
            CargarDatos();
            CargarCartasInformativas();

        }
        public void Captura()
        {
            cli = new Clientes();
           cli.Id = (txtIdCliente.Text != "") ? Convert.ToInt32(txtIdCliente.Text) : 0;
            cli.Nombres = txtNombresCliente.Text;
            cli.Apellidos = txtApellidosCliente.Text;
            cli.Telefono = txtTelefonoCliente.Text;
            cli.Correo = txtCorreoCliente.Text;
          
        }
        public void Nuevo()
        {
            txtIdCliente.Clear();
           txtNombresCliente.Text="";
            txtApellidosCliente.Text="";
            txtTelefonoCliente.Text="";
            txtCorreoCliente.Text = "";
            txtNombresCliente.Text = "";
           
        }
        public void Guardar()
        {
            Mysqlcon.Open();
            Captura();
           
            ClienteDB.Insertar(cli);
            CargarDatos();
           Nuevo();
        }
        public void CargarDatos()
        {

            Mysqlcon.Open();
            dtgTablaClientes.DataSource = null;
            dtgTablaClientes.DataSource = ClienteDB.ListAll();

            // Ajustando la tabla
            dtgTablaClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablaClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablaClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablaClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablaClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public static string TotalClientes;
        public void CargarCartasInformativas()
        {
            try
            {
                string CMD = string.Format("SELECT COUNT(cli.ID_CLIENTE) as TotalCli from clientes cli");
                DataSet ds = Mysqlcon.EjecutarConDT(CMD);

                TotalClientes = ds.Tables[0].Rows[0]["TotalCli"].ToString().Trim();
                lblTotalClientes.Text = TotalClientes;
              

            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta ");
            }
        }
        private void VentanaClientes_Load(object sender, EventArgs e)
        {
       
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mysqlcon.Open();
            if (txtIdCliente.Text == "")
            {
                Guardar();
                CargarCartasInformativas();
            }
            else
            {
                Mysqlcon.Open();
                int idCliente = Convert.ToInt32(txtIdCliente.Text);
                cli = ClienteDB.Buscar(idCliente);
                if (cli != null)
                {
                    Mysqlcon.Open();
                    Captura();
                    ClienteDB.Actualizar(cli);
                    CargarDatos();
                    Nuevo();

                }
                else
                    Guardar();
                CargarCartasInformativas();
            }

        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

       

        private void VentanaClientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarClienteFiltrado.Text = "Buscar cliente";
        }

        private void txtBuscarClienteFiltrado_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarClienteFiltrado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "") return;
            Mysqlcon.Open();
            int id = Convert.ToInt32(txtIdCliente.Text);
            ClienteDB.Eliminar(id);
            CargarDatos();
            Nuevo();
            CargarCartasInformativas();
        }

        private void dtgTablaClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                txtIdCliente.Text = dtgTablaClientes.Rows[rowindex].Cells[0].Value.ToString();
                txtNombresCliente.Text = dtgTablaClientes.Rows[rowindex].Cells[1].Value.ToString();
                txtApellidosCliente.Text = dtgTablaClientes.Rows[rowindex].Cells[2].Value.ToString();
                txtTelefonoCliente.Text = dtgTablaClientes.Rows[rowindex].Cells[3].Value.ToString();
                txtCorreoCliente.Text = dtgTablaClientes.Rows[rowindex].Cells[4].Value.ToString();

            }
        }

        private void txtBuscarClienteFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mysqlcon.Open();
            if (txtBuscarClienteFiltrado.Text != "")
            {
                dtgTablaClientes.DataSource = null;
                dtgTablaClientes.DataSource = ClienteDB.BuscarClienteXfiltro(txtBuscarClienteFiltrado.Text);
              
               // Ajustando la tabla
                dtgTablaClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablaClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablaClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablaClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablaClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                CargarDatos();
            }
        }
    }
}
