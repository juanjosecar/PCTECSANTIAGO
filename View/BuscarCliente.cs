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

namespace PCTECSANTIAGO.View
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
            Mysqlcon.Open(); // carga la conexion
        }
        public void CargarTablaClientes()
        {
            TablaBuscarCliente.DataSource = null;
            TablaBuscarCliente.DataSource = ClienteDB.ListAll();

            // Ajustando la tabla
            TablaBuscarCliente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarCliente.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarCliente.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarCliente.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            CargarTablaClientes();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (TablaBuscarCliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtBuscarClienteFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarClienteFiltrado.Text != "")
            {
                TablaBuscarCliente.DataSource = null;
                TablaBuscarCliente.DataSource = ClienteDB.BuscarClienteXfiltro(txtBuscarClienteFiltrado.Text);

                // Ajustando la tabla
                TablaBuscarCliente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarCliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarCliente.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarCliente.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarCliente.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                CargarTablaClientes();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtBuscarClienteFiltrado_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarClienteFiltrado.Clear();

        }
    }
}
