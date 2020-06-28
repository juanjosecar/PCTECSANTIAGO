using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaValidaciones_PCTECSANTIAGO
{
    public partial class TextBoxValidacion : TextBox
    {
        public TextBoxValidacion()
        {
            InitializeComponent();
        }
        public Boolean Validacion
        {
            set;
            get;
        }
        public Boolean SoloNumeros
        {
            set;
            get;
        }
    }
}
