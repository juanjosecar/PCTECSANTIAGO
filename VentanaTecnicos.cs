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
    public partial class VentanaTecnicos : Form
    {
        private Tecnicos tec;
        public VentanaTecnicos()
        {
            InitializeComponent();
            Mysqlcon.Open(); // carga la conexion
            CargarDatos();
            CargarCartasInformativas();
        }
        public void Captura()
        {
            tec = new Tecnicos();
            tec.Id = (txtIdTecnico.Text != "") ? Convert.ToInt32(txtIdTecnico.Text) : 0;
            tec.Nombres_tec = txtNombresTecnico.Text;
            tec.Apellidos_tec = txtApellidosTecnico.Text;
            tec.Cedula_tec = txtCedulaTecnico.Text;
            tec.Direccion_tec = txtDireccionTecnico.Text;
            tec.Correo_tec = txtCorreoTecnico.Text;
            tec.UserAccount= txtUsuarioTecnico.Text;
            tec.Contrasena_tec = txtPasswordTecnico.Text;


        }
        public void Nuevo()
        {
            txtIdTecnico.Clear();
            txtNombresTecnico.Text = "";
            txtApellidosTecnico.Text = "";
            txtCedulaTecnico.Text = "";
            txtDireccionTecnico.Text = "";
            txtCorreoTecnico.Clear();
            txtUsuarioTecnico.Clear();
            txtPasswordTecnico.Clear();
            txtNombresTecnico.Focus();

        }
        public void Guardar()
        {
            Mysqlcon.Open();
            Captura();
            TecnicosDB.Insertar(tec);
            CargarDatos();
            Nuevo();
        }
        public void CargarDatos()
        {
            Mysqlcon.Open();

            dtgTablTecnicos.DataSource = null;
            dtgTablTecnicos.DataSource = TecnicosDB.ListAll();

            // Ajustando la tabla
            dtgTablTecnicos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgTablTecnicos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public static string TotalTecnicos;
        public void CargarCartasInformativas()
        {
            try
            {
                string CMD = string.Format("SELECT COUNT(tec.ID_TECNICO) as TotalTec from tecnicos tec");
                DataSet ds = Mysqlcon.EjecutarConDT(CMD);

                TotalTecnicos = ds.Tables[0].Rows[0]["TotalTec"].ToString().Trim();
                lblTotalTecnicos.Text = TotalTecnicos;



            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta ");
            }
        }
        private void VentanaTecnicos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdTecnico.Text == "")
            {
                Guardar();
                CargarCartasInformativas();
            }
            else
            {
                Mysqlcon.Open();
                int idTecnico = Convert.ToInt32(txtIdTecnico.Text);
                tec = TecnicosDB.Buscar(idTecnico);
                if (tec != null)
                {

                    Mysqlcon.Open();
                    Captura();
                    TecnicosDB.Actualizar(tec);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if (txtIdTecnico.Text == "") return;
            Mysqlcon.Open();
            int id = Convert.ToInt32(txtIdTecnico.Text);
            TecnicosDB.Eliminar(id);
            CargarDatos();
            Nuevo();
            CargarCartasInformativas();
        }

        private void dtgTablTecnicos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                txtIdTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[0].Value.ToString();
                txtNombresTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[1].Value.ToString();
                txtApellidosTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[2].Value.ToString();
                txtCedulaTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[3].Value.ToString();
                txtDireccionTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[4].Value.ToString();
                txtCorreoTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[5].Value.ToString();
                txtPasswordTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[6].Value.ToString();
                txtUsuarioTecnico.Text = dtgTablTecnicos.Rows[rowindex].Cells[7].Value.ToString();
                




            }
        }

        private void txtBuscarTecnicoFiltrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mysqlcon.Open();
            if (txtBuscarTecnicoFiltrado.Text != "")
            {
              
                dtgTablTecnicos.DataSource = null;
                dtgTablTecnicos.DataSource = TecnicosDB.BuscarTecnicoXfiltro(txtBuscarTecnicoFiltrado.Text);

                // Ajustando la tabla
            
                dtgTablTecnicos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtgTablTecnicos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                CargarDatos();
            }


        
        }

        private void txtBuscarTecnicoFiltrado_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarTecnicoFiltrado.Clear();
        }
    }
}
