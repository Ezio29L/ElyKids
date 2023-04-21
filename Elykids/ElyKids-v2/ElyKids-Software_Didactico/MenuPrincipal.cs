using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElyKids_Software_Didactico
{
    public partial class MenuPrincipal : Form
    {
        //aqui estoy creando un atributo que sea una copia del volumen que se maneja aqui en el menu
        public int volumenActivo;
        public MenuPrincipal(int vol)
        {
            InitializeComponent();
            //Inicializamos todo lo referente al sonido aqui.
            trbVolumen.Value = vol;
            lblVol.Text = vol.ToString() + "%";
            WMP.settings.volume = vol;
            volumenActivo = vol;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            //el boton para salir de la aplicacion no puede cerrarlo todo desde qui, asi que tiene que mandar un mensaje de que 
            //el la pantalla de inicio la cierre.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            //Cuando se manipula la barra del volumen tanto el Texto de la etiqueta como el valor del volumen cambian respectivamente
            lblVol.Text = (trbVolumen.Value.ToString()) + "%";
            WMP.settings.volume = trbVolumen.Value;
            volumenActivo = trbVolumen.Value;
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            //Esta funcion solo muestra y oculta el Panel en el que se encuentra el controlador del volumen
            if (PnlVol.Visible)
            {
                PnlVol.Visible = false;
            }
            else
            {
                PnlVol.Visible = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //se cierra el Menu con un mensaje interno de ok
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
