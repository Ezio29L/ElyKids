using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElyKids_Software_Didactico
{ 
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
            
        }

        private void FInicio_Load(object sender, EventArgs e)
        {
            //Al iniciarce la Pantalla se asigna la cancion que se tocara de fondo...
            WMP.URL = ObtenerUrl("intro.wav");
            // se pone el volumen a 100%...
            WMP.settings.volume = 100;
            //y se empieza a tocar la musica
            WMP.Ctlcontrols.play();
        }

        private void eButton1_Click(object sender, EventArgs e)
        {
            //en este espacio se pondra la funcion para pasar de una ventana a otra
        }
        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolumen_Click_1(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //el boton para salir de la aplicacion
            Application.Exit();
        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            //Cuando se manipula la barra del volumen tanto el Texto de la etiqueta como el valor del volumen cambian respectivamente
            lblVol.Text=(trbVolumen.Value.ToString())+"%";
            WMP.settings.volume= trbVolumen.Value;
        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }
    }
}
