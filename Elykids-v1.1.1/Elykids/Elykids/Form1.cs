using System.Media;
using System.Numerics;

namespace Elykids
{
    public partial class Form1 : Form
    {
        //Crear las variables para el reproductor de musica, isMuted es para detener/reproducir la musica, cuando = false, la musica suena, = true, la musica para
        private SoundPlayer player;
        private bool isMuted = false;
        public Form1()
        {
            //InitializeComponent();
            
            //Usando System.Media, creamos una instancia y se le asigna la ruta del archivo de audio a reproducir
            player = new SoundPlayer(@"../../../Resources/intro.wav");
            //Reproduce la cancion
            player.Play();
        }
        //Boton para entrar al menu
        private void btnSt_Click(object sender, EventArgs e)
        {

            // Oculta todos los controles de Form1
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            // Crea una instancia de Form2 y lo muestra dentro de Form1
            Form2 form2 = new Form2();
            //establecemos form1 como secundario
            form2.TopLevel = false;
            //convertimos este form a principal
            form2.Parent = this;
            //Establecemos form2 que se ajuste a form1, ocupando todo el espacio posible
            form2.Dock = DockStyle.Fill;
            //mostramos pantalla
            form2.Show();

        }
        //Boton para salir de la aplicacion
        private void btnEx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton para silenciar
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
