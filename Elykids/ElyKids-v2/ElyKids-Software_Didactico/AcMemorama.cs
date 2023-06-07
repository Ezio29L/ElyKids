using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElyKids_Software_Didactico
{
    public partial class AcMemorama : Form
    {
        float Calificacion;
        bool AcAcabada = false;
        int NumLeccion;
        int ContIntentos;
        bool MediaTirada;
        List<string> TarjSeleccionables = new List<string>();
        List<string> Maso = new List<string>();
        int TarjetaSeleccionada = -1;
        public AcMemorama(int leccion)
        {
            InitializeComponent();
            NumLeccion = leccion;
        }
        
        public float Calificar
        {
            get { return Calificacion; }
        }

        private float ObtenerCalificacion()
        {
            float resultado = 15 - ContIntentos;
            if (resultado > 10)
            {
                return 10;
            }
            else
            {
                return resultado;
            }
        }

        private void ComprobarAcabado()
        {
            if (TarjSeleccionables.Count < 1)
            {
                AcAcabada= true;
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (AcAcabada)
            {
                Calificacion= ObtenerCalificacion();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Aun no se termina la actividad");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 0;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button1.Image = Image.FromFile(Maso[EstaTarjeta]);
                button1.Refresh();
                if (MediaTirada)
                {
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 1;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button2.Image = Image.FromFile(Maso[EstaTarjeta]);
                button2.Refresh();
                if (MediaTirada)
                {
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 2;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button3.Image = Image.FromFile(Maso[EstaTarjeta]);
                button3.Refresh();
                if (MediaTirada)
                {
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 3;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button4.Image = Image.FromFile(Maso[EstaTarjeta]);
                button4.Refresh();
                if (MediaTirada)
                {
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 4;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button5.Image = Image.FromFile(Maso[EstaTarjeta]);
                button5.Refresh();
                if (MediaTirada)
                {
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int EstaTarjeta = 5;
            if (TarjSeleccionables.Contains(Maso[EstaTarjeta]) && TarjetaSeleccionada != EstaTarjeta)
            {

                button6.Image = Image.FromFile(Maso[EstaTarjeta]);
                button6.Refresh();
                if (MediaTirada)
                {
                    
                    Thread.Sleep(1000);
                    if (Maso[TarjetaSeleccionada] == Maso[EstaTarjeta])
                    {
                        TarjSeleccionables.Remove(Maso[EstaTarjeta]);
                    }
                    else
                    {
                        OcultarImagenes();
                    }
                    MediaTirada = false;
                    ContIntentos++;
                    ComprobarAcabado();
                    TarjetaSeleccionada = -1;
                }
                else
                {
                    TarjetaSeleccionada = EstaTarjeta;
                    MediaTirada = true;
                }
            }
        }

        private void AcMemorama_Load(object sender, EventArgs e)
        {
            string[] tarjetasDisponibles = Directory.GetFiles(@"../../Resources/Memorama/" + NumLeccion.ToString());
            var rand = new Random();
            int eleccion1 = rand.Next(0, tarjetasDisponibles.Length);
            int eleccion2;
            int eleccion3;
            int aux;
            do
            {
                aux = rand.Next(0, tarjetasDisponibles.Length);

            } while (aux == eleccion1);
            eleccion2 = aux;

            do
            {
                aux = rand.Next(0, tarjetasDisponibles.Length);
            } while (aux == eleccion1 || aux == eleccion2);
            eleccion3 = aux;

            Maso.Add(tarjetasDisponibles[eleccion1]);
            Maso.Add(tarjetasDisponibles[eleccion1]);
            Maso.Add(tarjetasDisponibles[eleccion2]);
            Maso.Add(tarjetasDisponibles[eleccion2]);
            Maso.Add(tarjetasDisponibles[eleccion3]);
            Maso.Add(tarjetasDisponibles[eleccion3]);

            TarjSeleccionables.Add(tarjetasDisponibles[eleccion1]);
            TarjSeleccionables.Add(tarjetasDisponibles[eleccion2]);
            TarjSeleccionables.Add(tarjetasDisponibles[eleccion3]);

            Maso = Shuffle(Maso);

            AcAcabada = false;
            MediaTirada= false;
            ContIntentos = 0;
        }

        private static List<string> Shuffle (List<string> lista)
        {
            var random = new Random();
            var ShuffledList = new List<string>();
            int listcCount = lista.Count;
            for (int i = 0; i < listcCount; i++)
            {
                var randomElementInList = random.Next(0, lista.Count);
                ShuffledList.Add(lista[randomElementInList]);
                lista.Remove(lista[randomElementInList]);
            }
            return ShuffledList;

        }

        private void OcultarImagenes()
        {
            button1.Image=null; 
            button2.Image=null;
            button3.Image=null;
            button4.Image=null;
            button5.Image=null;
            button6.Image=null;
        }
        
    }
}
