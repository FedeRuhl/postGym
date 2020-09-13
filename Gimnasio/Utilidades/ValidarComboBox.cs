using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.Utilidades
{
    public static class ValidarComboBox
    {
        public static bool opcionValida(ComboBox ComboBox, string elemento)
        {
            if (ComboBox.FindStringExact(elemento) != -1)
                return true;
            else
                return false;
        }
    }
}
