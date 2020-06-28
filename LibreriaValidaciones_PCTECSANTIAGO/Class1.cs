using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaValidaciones_PCTECSANTIAGO
{
    public class Utilidades
    {
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is TextBoxValidacion)
                {
                    TextBoxValidacion obj = (TextBoxValidacion)Item;

                    if (obj.Validacion == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar vacio");
                            HayErrores = true;

                        }
                    }
                    //AQUI VALIDAMOS QUE SOLO HAYA NUMEROS EN LOS CAMPOS QUE SELECCIONO
                    if (obj.SoloNumeros == true)
                    {
                        int cont = 0, letrasEncontradas = 0;

                        foreach (char letra in obj.Text.Trim())
                        {
                            if (char.IsLetter(obj.Text.Trim(), cont))
                            {
                                letrasEncontradas++;
                            }
                            cont++;
                        }

                        if (letrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(obj, "Solo Numeros");
                        }
                    }
                }
            }
            return HayErrores;
        }

    }
}
