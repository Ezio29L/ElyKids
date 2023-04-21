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
            //esto lo hacemos en varios pasos
            //Paso 1: creamos la otra ventana
            MenuPrincipal menu = new MenuPrincipal(trbVolumen.Value);
            //Paso 2: paramos la musica de aqui y volvemos invisible esta ventana.
            WMP.Ctlcontrols.stop();
            this.Visible = false;
            //Paso 3: Ahora si abrimos el menu, con ShowDialog, lo que nos va a hacer imposible interactuar
            //con esta ventana aunque estuviece visible, mientras el menu este abierto.
            menu.ShowDialog();
            //de aqui el codigo no avanza hasta que el Menu se cierre.
            //si el menu se cierra a travez del boton de atras se ejecutara el if, si se cerro por el boton de salir, se ejecutara el else
            if (menu.DialogResult == DialogResult.OK)
            {
                //Paso 4: cuando el menu se cierre tenemos que volver a hacer visible esta ventana
                this.Visible = true;
                //Paso 5: Importamos el sonido que estaba manejandose en el menu
                trbVolumen.Value = menu.volumenActivo;
                lblVol.Text = (trbVolumen.Value.ToString()) + "%";
                WMP.settings.volume = trbVolumen.Value;
                //Paso 6: prendemos la musica
                WMP.Ctlcontrols.play();
                //Paso 7: y ya nos podemos deshacer del menu.
                menu.Dispose();
            }
            else
            { 
                Application.Exit();
            }
            
            


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
