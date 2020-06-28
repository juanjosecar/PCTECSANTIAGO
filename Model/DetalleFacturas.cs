using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTECSANTIAGO.Model
{
   public class DetalleFacturas
    {
        private int id_Det_Facturas;
        private int idFacturas;
        private int idServicios;
        private int cantidad;
        private float precio;
        private string descripcion;
        private string tipo_servicio;

        public int IdFacturas { get => idFacturas; set => idFacturas = value; }
        public int IdServicios { get => idServicios; set => idServicios = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
  
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_Det_Facturas { get => id_Det_Facturas; set => id_Det_Facturas = value; }
        public string Tipo_servicio { get => tipo_servicio; set => tipo_servicio = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
