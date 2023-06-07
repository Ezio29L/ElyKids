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
    public partial class AcRelacionPalabraImagen : Form
    {
        float Calificacion;
        bool AcAcabada = false;
        List<string> Vocabulario = new List<string>();
        int ContIntentos;
        List<string> ImagSeleccionadas = new List<string>();
        List<string> PalabrasSeleccionadas = new List<string>();
        bool MediaSeleccion;
        int LableSel = -1;
        bool Palabra1Correcta;
        bool Palabra2Correcta;
        bool Imagen1Correcta;
        bool Imagen2Correcta;
        bool Imagen3Correcta;

        public AcRelacionPalabraImagen(List<string> vocab)
        {
            InitializeComponent();
            Vocabulario = vocab;
        }
        
        private float ObtenerCalificacion()
        {
            float resultado = 14 - (ContIntentos * 2);
            if(ContIntentos < 0)
            {
                return 0;
            }
            else
            {
                return resultado;
            }
            
        }

        public float Calificar
        {
            get { return Calificacion; }
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

        private void lblPalabra1_Click(object sender, EventArgs e)
        {
            if (Palabra1Correcta == false)
            {
                if (LableSel == 1)
                {
                    ApagarColores();
                    LableSel = -1;
                    MediaSeleccion = false;
                }
                else
                {
                    ApagarColores();
                    MediaSeleccion = true;
                    LableSel = 1;
                    lblPalabra1.BackColor = Color.DeepSkyBlue;
                    lblPalabra1.Refresh();
                }
            }
        }

        private void lblPalabra2_Click(object sender, EventArgs e)
        {
            if (Palabra2Correcta == false)
            {
                if (LableSel == 2)
                {
                    ApagarColores();
                    LableSel = -1;
                    MediaSeleccion = false;
                }
                else
                {
                    ApagarColores();
                    MediaSeleccion = true;
                    LableSel = 2;
                    lblPalabra2.BackColor = Color.Lime;
                    lblPalabra2.Refresh();
                }
            }
            
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (MediaSeleccion && Imagen1Correcta == false)
            {
                switch (LableSel)
                {
                    case 1:
                        if (ImagSeleccionadas[0] == ObtenerPath(lblPalabra1.Text)) 
                        {
                            pb1.BackColor = Color.DeepSkyBlue;
                            pb1.Refresh();
                            Palabra1Correcta = true;
                            Imagen1Correcta = true;
                        }
                        else
                        {
                            pb1.BackColor = Color.Red;
                            pb1.Refresh();
                            Thread.Sleep(1000);
                            LableSel= -1;
                            ApagarColores();
                        }
                        break;
                    case 2:
                        if (ImagSeleccionadas[0] == ObtenerPath(lblPalabra2.Text))
                        {
                            pb1.BackColor = Color.Lime;
                            pb1.Refresh();
                            Palabra2Correcta = true;
                            Imagen1Correcta = true;
                        }
                        else
                        {
                            pb1.BackColor = Color.Red;
                            pb1.Refresh();
                            Thread.Sleep(1000);
                            LableSel= -1;
                            ApagarColores();
                        }
                        break;
                }
                ContIntentos++;
                MediaSeleccion = false;
                CompruebaAcabado();
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (MediaSeleccion && Imagen2Correcta == false)
            {
                switch (LableSel)
                {
                    case 1:
                        if (ImagSeleccionadas[1] == ObtenerPath(lblPalabra1.Text))
                        {
                            pb2.BackColor = Color.DeepSkyBlue;
                            pb2.Refresh();
                            Palabra1Correcta = true;
                            Imagen2Correcta = true;
                        }
                        else
                        {
                            pb2.BackColor = Color.Red;
                            pb2.Refresh();
                            Thread.Sleep(1000);
                            LableSel = -1;
                            ApagarColores();
                        }
                        break;
                    case 2:
                        if (ImagSeleccionadas[1] == ObtenerPath(lblPalabra2.Text))
                        {
                            pb2.BackColor = Color.Lime;
                            pb2.Refresh();
                            Palabra2Correcta = true;
                            Imagen2Correcta = true;
                        }
                        else
                        {
                            pb2.BackColor = Color.Red;
                            pb2.Refresh();
                            Thread.Sleep(1000);
                            LableSel = -1;
                            ApagarColores();
                        }
                        break;
                }
                ContIntentos++;
                MediaSeleccion = false;
                CompruebaAcabado();
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (MediaSeleccion && Imagen3Correcta == false)
            {
                switch (LableSel)
                {
                    case 1:
                        if (ImagSeleccionadas[2] == ObtenerPath(lblPalabra1.Text))
                        {
                            pb3.BackColor = Color.DeepSkyBlue;
                            pb3.Refresh();
                            Palabra1Correcta = true;
                            Imagen3Correcta = true;
                        }
                        else
                        {
                            pb3.BackColor = Color.Red;
                            pb3.Refresh();
                            Thread.Sleep(1000);
                            LableSel = -1;
                            ApagarColores();
                        }
                        break;
                    case 2:
                        if (ImagSeleccionadas[2] == ObtenerPath(lblPalabra2.Text))
                        {
                            pb3.BackColor = Color.Lime;
                            pb3.Refresh();
                            Palabra2Correcta = true;
                            Imagen3Correcta = true;
                        }
                        else
                        {
                            pb3.BackColor = Color.Red;
                            pb3.Refresh();
                            Thread.Sleep(1000);
                            LableSel = -1;
                            ApagarColores();
                        }
                        break;
                }
                ContIntentos++;
                MediaSeleccion = false;
                CompruebaAcabado();
            }
        }
        
        private List<string> ObtenImagenesConPalabra()
        {
            List<string> list = new List<string>();

            foreach (string palabra in Vocabulario)
            {
                if (File.Exists(@"../../Resources/" + palabra + ".png"))
                {
                    list.Add(ObtenerPath(palabra));
                    PalabrasSeleccionadas.Add(palabra);
                }
            }

            return list;
        }

        private void AcRelacionPalabraImagen_Load(object sender, EventArgs e)
        {
            var rand = new Random();
            ImagSeleccionadas = ObtenImagenesConPalabra();

            if (ImagSeleccionadas.Count > 3)
            {
                List<string> list = new List<string>();
                List<string> palabritas= new List<string>();
                for (int i=0; i < 3; i++)
                {
                    int aux = rand.Next(0, ImagSeleccionadas.Count);
                    list.Add(ImagSeleccionadas[aux]);
                    palabritas.Add(PalabrasSeleccionadas[aux]);
                    ImagSeleccionadas.RemoveAt(aux);
                    PalabrasSeleccionadas.RemoveAt(aux);

                }
                ImagSeleccionadas.Clear();
                PalabrasSeleccionadas.Clear();
                ImagSeleccionadas = list;
                PalabrasSeleccionadas = palabritas;
            }

            ImagSeleccionadas= Shuffle(ImagSeleccionadas);

            pb1.BackgroundImage = Image.FromFile(ImagSeleccionadas[0]);
            pb2.BackgroundImage = Image.FromFile(ImagSeleccionadas[1]);
            pb3.BackgroundImage = Image.FromFile(ImagSeleccionadas[2]);

            PalabrasSeleccionadas.RemoveAt(rand.Next(0,3));

            lblPalabra1.Text = PalabrasSeleccionadas[0];
            lblPalabra2.Text = PalabrasSeleccionadas[1];

            AcAcabada = false;
            MediaSeleccion = false;
            ContIntentos = 0;
            LableSel = -1;
            Palabra1Correcta = false;
            Palabra2Correcta = false;
            Imagen1Correcta = false;
            Imagen2Correcta = false;
            Imagen3Correcta = false;
        }
        private string ObtenerPath(string nombre)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + nombre + ".png");
            return file.FullName;
        }

        private static List<string> Shuffle(List<string> lista)
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

        private void ApagarColores()
        {
            if (Palabra1Correcta == false) 
            {
                lblPalabra1.BackColor = Color.FromArgb(255, 241, 215);
            }

            if (Palabra2Correcta == false) 
            {
                lblPalabra2.BackColor = Color.FromArgb(255, 241, 215);
            }

            if (Imagen1Correcta == false)
            {
                pb1.BackColor = Color.Transparent;
            }

            if (Imagen2Correcta == false) 
            {
                pb2.BackColor = Color.Transparent;
            }

            if (Imagen3Correcta == false)
            {
                pb3.BackColor = Color.Transparent;
            }
        }

        private void CompruebaAcabado()
        {
            if(Palabra1Correcta && Palabra2Correcta)
            {
                AcAcabada = true;
            }
        }
    }
}
