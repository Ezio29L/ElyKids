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
using System.Xml.Serialization;

namespace ElyKids_Software_Didactico
{
    public partial class MenuPrincipal : Form
    {
        //aqui estoy creando un atributo que sea una copia del volumen que se maneja aqui en el menu
        public int volumenActivo;

        //un indicador de en que estado se esta. 0 es para no hay botones en el FlowPanel2 y 1 es para Si hay botones en el FlowPanel2
        private int Estado = 0;

        public int EstadoActual
        {
            get { return Estado; }
            set { Estado = value; }
        }
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
            //se le asigna la cancion de fondo al menu
            WMP.URL = ObtenerUrl("menu.wav");
            //se le indica al WMP que suene la cancionsita en bucle
            WMP.settings.setMode("loop", true);
            //Y ya porfin se empieza la musica.
            //lo que sigue es crear los botones 
            string[] Partes = Directory.GetFiles(ObtenerUrl("GruposDeLecciones"));

            int contadorPartes = 1;

            foreach (string p in Partes)
            {
                Stream st = File.Open(p, FileMode.Open);
                var formato = new XmlSerializer(typeof(GrupoLecciones));

                GrupoLecciones Gl = (GrupoLecciones) formato.Deserialize(st);

                BotonesGrupoAlmacen btnGrupo = new BotonesGrupoAlmacen();
                btnGrupo.Size = new System.Drawing.Size(240, 320);
                btnGrupo.Text = string.Empty;
                btnGrupo.Encapsulado = Gl;
                btnGrupo.Image = Image.FromFile((ObtenerUrl("GrupoLeccion_" + contadorPartes.ToString() + ".jpg")));
                btnGrupo.ImageAlign = ContentAlignment.MiddleCenter;
                btnGrupo.Click += BtnGrupo_Click;
                btnGrupo.Click += new EventHandler(btnGrupo.GenerarOtrosBotones);
                
                FlowPanel1.Controls.Add(btnGrupo);
                contadorPartes++;
                
            }

        }

        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            FlowPanel1.Width = this.Width - 192;
            FlowPanel2.Width = this.Width - 192;
            FlowPanel2.Height = this.Height - 246;
        }

        private void BtnGrupo_Click(object sender, EventArgs e)
        {
            FlowPanel1.Visible = false;
            FlowPanel2.Visible = true;

            if (Estado == 1)
            {
                FlowPanel2.Controls.Clear();
            }

            Estado= 1;
        }

        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
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
            if (Estado == 0)
            {
                //se cierra el Menu con un mensaje interno de ok
                DialogResult = DialogResult.OK;
                WMP.Ctlcontrols.stop();
                Close();
            }else
            {
                FlowPanel1.Visible = true;
                FlowPanel2.Visible = false; 
                FlowPanel2.Controls.Clear();
                Estado = 0; 
            }
            
        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            FlowPanel1.Visible = false;
            FlowPanel2.Visible = true;
            if (Estado == 1)
            {
                //si ya hay botones en el FlowPanel2 se borran
                FlowPanel2.Controls.Clear();
                Estado= 0;
            }
            //aqui se deben crear 2 botones
            System.Windows.Forms.Button btnL0 = new System.Windows.Forms.Button();
            btnL0.Size= new System.Drawing.Size(277,356);
            btnL0.Image = global::ElyKids_Software_Didactico.Properties.Resources.Lección0;
            btnL0.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnL0.Text= string.Empty;
            btnL0.Click += BtnL0_Click;
            FlowPanel2.Controls.Add(btnL0);

            System.Windows.Forms.Button btnL00 = new System.Windows.Forms.Button();
            btnL00.Size = new System.Drawing.Size(277, 356);
            btnL00.Image = global::ElyKids_Software_Didactico.Properties.Resources.lección00;
            btnL00.ImageAlign= System.Drawing.ContentAlignment.MiddleCenter;
            btnL00.Text= string.Empty;
            btnL00.Click += BtnL00_Click;
            FlowPanel2.Controls.Add(btnL00);

            //le informa al sistema que haty botones en FlowPanel2
            Estado = 1;
        }

        private void BtnL00_Click(object sender, EventArgs e)
        {
            DesplegarTutorial tutorial = new DesplegarTutorial(1);
            this.Visible= false;
            WMP.Ctlcontrols.pause();
            tutorial.ShowDialog();
            tutorial.Dispose();
            this.Visible = true;
            WMP.Ctlcontrols.play();
        }

        private void BtnL0_Click(object sender, EventArgs e)
        {
            DesplegarTutorial tutorial = new DesplegarTutorial(0);
            this.Visible = false;
            WMP.Ctlcontrols.pause();
            tutorial.ShowDialog();
            tutorial.Dispose();
            this.Visible = true;
            WMP.Ctlcontrols.play();
        }
    }
}
