using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElyKids_Software_Didactico
{
    public class BotonesGrupoAlmacen : Button
    {
        GrupoLecciones grupo;
        public GrupoLecciones Encapsulado
        {
            get { return grupo; }
            set { grupo = value; }
        }

    }
    public class BotonesLeccionAlmacen : Button
    {
        Lecciones leccion;

        public Lecciones Encapsulado
        {
            get { return leccion; }
            set { leccion = value; }
        }

    }
}
