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
    public partial class VentanaLogin : Form
    {
        public static String idTecnico = "";
        public static String NombresTecnico = "";

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Exit();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM tecnicos WHERE USER_ACCOUNT='{0}' AND TEC_PASSWORD_TECNICO='{1}'", txtUsername.Text.Trim(), txtPasswordReal.Text.Trim());
                DataSet ds = Mysqlcon.EjecutarConDT(CMD);

                idTecnico = ds.Tables[0].Rows[0]["ID_TECNICO"].ToString().Trim();
                NombresTecnico = ds.Tables[0].Rows[0]["TEC_NOMBRES_TECNICO"].ToString().Trim() + " " + ds.Tables[0].Rows[0]["TEC_APELLIDOS_TECNICO"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["USER_ACCOUNT"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["TEC_PASSWORD_TECNICO"].ToString().Trim();
                if (cuenta == txtUsername.Text.Trim() && contra == txtPasswordReal.Text.Trim())
                {
                    VentanaPrincipal Wprincipal = new VentanaPrincipal();
                    this.Hide();
                    Wprincipal.Show();
                
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrecta " );
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
