using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    public static class Fecha
    {
        public static string convertirFormatoUniversal(DateTime fecha)
        {
            string anio = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();

            if (mes.Length == 1)
                mes = '0' + mes;

            if (dia.Length == 1)
                dia = '0' + dia;

            return (anio + "-" + mes + "-" + dia);
        }
    }
}
