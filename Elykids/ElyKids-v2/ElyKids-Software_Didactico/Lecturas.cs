using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace ElyKids_Software_Didactico
{
    public partial class Lecturas : Form
    {
        SpeechSynthesizer Voz = new SpeechSynthesizer();
        string NombrePortada;
        public List<string> Oraciones = new List<string>();
        public Lecturas(List<string> Lectura, string NombreImagen)
        {
            InitializeComponent();
            Voz.SelectVoice("Microsoft Sabina Desktop");
            Oraciones = Lectura;
            foreach(String str in Lectura)
            {
                CajaLectura.Items.Add(str);
            }
            NombrePortada= NombreImagen;
            
        }
        public Lecturas()
        {
            //este constructor es nomas para lo de Cargar Instancias desde archivos y NUNCA debe ser usado en Codigo
        }

        private void Lecturas_Load(object sender, EventArgs e)
        {
            ImagenPrincipal.BackgroundImage = Image.FromFile(ObtenerUrl(NombrePortada));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //el boton para salir de la aplicacion no puede cerrarlo todo desde qui, asi que tiene que mandar un mensaje de que 
            //el la pantalla de inicio la cierre.
            DialogResult = DialogResult.Cancel;
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //se cierra el Menu con un mensaje interno de Abortar
            DialogResult = DialogResult.Abort;
            Close();
        }
        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }
        private void CajaLectura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Voz.Speak(CajaLectura.SelectedItem.ToString());
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK; 
            Close();
        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            //Cuando se manipula la barra del volumen tanto el Texto de la etiqueta como el valor del volumen cambian respectivamente
            lblVol.Text = (trbVolumen.Value.ToString()) + "%";
            /*WMP.settings.volume = trbVolumen.Value;
            volumenActivo = trbVolumen.Value;*/
        }
    }
}
