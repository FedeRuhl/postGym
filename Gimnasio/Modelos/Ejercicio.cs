using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Modelos
{
    class Ejercicio
    {
        private int id;
        private String nombre;

        public Ejercicio(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
