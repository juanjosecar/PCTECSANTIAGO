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
    public partial class BuscarTecnico : Form
    {
        public BuscarTecnico()
        {
            InitializeComponent();
        }
        public void CargarTablaTecnico()
        {
            TablaBuscarTecnico.DataSource = null;
            TablaBuscarTecnico.DataSource = TecnicosDB.ListAll();

            // Ajustando la tabla
            TablaBuscarTecnico.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaBuscarTecnico.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void BuscarTecnico_Load(object sender, EventArgs e)
        {
            CargarTablaTecnico();
        }

        private void btnSeleccionaTecnico_Click(object sender, EventArgs e)
        {
            if (TablaBuscarTecnico.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtBuscarTecnicoFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarTecnicoFiltrado.Text != "")
            {
                TablaBuscarTecnico.DataSource = null;
                TablaBuscarTecnico.DataSource = TecnicosDB.BuscarTecnicoXfiltro(txtBuscarTecnicoFiltrado.Text);

                // Ajustando la tabla

                TablaBuscarTecnico.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TablaBuscarTecnico.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                CargarTablaTecnico();
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtBuscarTecnicoFiltrado_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarTecnicoFiltrado.Clear();
        }
    }
}
