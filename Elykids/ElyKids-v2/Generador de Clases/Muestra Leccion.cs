using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElyKids_Software_Didactico;

namespace Generador_de_Clases
{
    public partial class Muestra_Leccion : Form
    {
        Lecciones Target;
        public Muestra_Leccion(Lecciones Prueba)
        {
            InitializeComponent();
            Target= Prueba;
        }

        private void Muestra_Leccion_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Target.Nombre;
            lblNum.Text = Target.Numero.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lecturas Copia = Target.lectura;
            Copia.ShowDialog();
        }
    }
}
