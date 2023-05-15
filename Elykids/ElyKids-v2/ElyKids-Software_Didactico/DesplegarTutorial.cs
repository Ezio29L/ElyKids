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
    public partial class DesplegarTutorial : Form
    {
        int tutorial;
        bool play = true;
        public DesplegarTutorial(int tutorial)
        {
            InitializeComponent();
            this.tutorial = tutorial;
        }

        private void DesplegarTutorial_Load(object sender, EventArgs e)
        {

            switch(tutorial)
            {
                case 1:
                    WMP.URL = ObtenerUrl("Tutorial_00.mp4");
                    break;
                case 0:
                    MessageBox.Show("a la vuelta joven");
                    break;
            }
            WMP.uiMode = "none";
            WMP.settings.volume= 100;
            WMP.Ctlcontrols.play();
        }
        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //el boton para salir de la aplicacion no puede cerrarlo todo desde qui, asi que tiene que mandar un mensaje de que 
            //el la pantalla de inicio la cierre.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //se cierra el Menu con un mensaje interno de ok
            DialogResult = DialogResult.OK;
            WMP.Ctlcontrols.stop();
            Close();
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

        private void btnPausaPlay_Click(object sender, EventArgs e)
        {
            if (play)
            {
                play= false;
                WMP.Ctlcontrols.pause();
                btnPausaPlay.Image = global::ElyKids_Software_Didactico.Properties.Resources.tocar;
            }
            else
            {
                play = true;
                WMP.Ctlcontrols.play();
                btnPausaPlay.Image = global::ElyKids_Software_Didactico.Properties.Resources.boton_de_pausa;
            }
        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            //Cuando se manipula la barra del volumen tanto el Texto de la etiqueta como el valor del volumen cambian respectivamente
            lblVol.Text = (trbVolumen.Value.ToString()) + "%";
            WMP.settings.volume = trbVolumen.Value;
            //volumenActivo = trbVolumen.Value;
        }
    }
}
