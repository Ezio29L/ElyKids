using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elykids
{
    public partial class Form2 : Form
    {
        //Crear las variables para el reproductor de musica, isMuted es para detener/reproducir la musica, cuando = false, la musica suena, = true, la musica para
        private SoundPlayer player;
        private bool isMuted = false;

        public Form2()
        {
            InitializeComponent();
            //Creamos la instancia con la ruta
            player = new SoundPlayer(@"C:\Users\Hp\Downloads\menu\elymenu\menu.wav");
            // Reproduce el archivo de audio
            player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Boton para poner mute a la musica
        private void btnMute_Click(object sender, EventArgs e)
        {

            if (!isMuted)
            {
                player.Stop();
                isMuted = true;
            }
            else
            {
                player.PlayLooping();
                isMuted = false;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Oculta todos los controles de Form2
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            // Crea una instancia de Form1 y lo muestra dentro de Form2
            Form1 form1 = new Form1();
            //establecemos form1 como secundario
            form1.TopLevel = false;
            //convertimos este form a principal
            form1.Parent = this;
            //Establecemos form2 que se ajuste a form1, ocupando todo el espacio posible
            form1.Dock = DockStyle.Fill;
            //Mostramos pantalla
            form1.Show();
        }
    }
}
