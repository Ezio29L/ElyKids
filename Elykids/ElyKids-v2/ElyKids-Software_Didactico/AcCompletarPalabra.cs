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
    public partial class AcCompletarPalabra : Form
    {
        float Calificacion;
        bool AcAcabada = false;
        List<string> Vocabulario = new List<string>();
        List<string> PalabrasDisponibles = new List<string>();
        string PrimeraPalabra;
        string SegundaPalabra;
        public AcCompletarPalabra( List<string> vocab)
        {
            InitializeComponent();
            Vocabulario= vocab;
            
        }
        
        private float ObtenerCalificacion()
        {
            int aciertos = 0;
            int i;
            int total = PrimeraPalabra.Length + SegundaPalabra.Length;

            for (i = 0; i < PrimeraPalabra.Length; i++)
            {
                if (flp1.Controls[i].Text == PrimeraPalabra[i].ToString())
                {
                    aciertos++;
                }
            }

            for (i = 0; i < SegundaPalabra.Length; i++)
            {
                if (flp2.Controls[i].Text == SegundaPalabra[i].ToString())
                {
                    aciertos++;
                }
            }

            return (aciertos/total) * 10;
        }

        public float Calificar
        {
            get { return Calificacion; }
        }

        private List<string> ObtenImagenesConPalabra()
        {
            List<string> list = new List<string>();

            foreach (string palabra in Vocabulario)
            {
                if (File.Exists(@"../../Resources/" + palabra + ".png"))
                {
                    list.Add(palabra);
                    
                }
            }

            return list;
        }
        private string ObtenerPath(string nombre)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + nombre + ".png");
            return file.FullName;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private bool EstanLlenosTodosLosTextBox()
        {
            bool respuesta = true;
            int i;
            for (i = 0; i < PrimeraPalabra.Length; i++) 
            {
                if (flp1.Controls[i].Text == string.Empty)
                {
                    respuesta = false;
                }
            }

            for (i = 0; i < SegundaPalabra.Length; i++)
            {
                if (flp2.Controls[i].Text == string.Empty)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (EstanLlenosTodosLosTextBox())
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

        private void AcCompletarPalabra_Load(object sender, EventArgs e)
        {
            var rand = new Random();
            int seleccion1 = rand.Next(0,PalabrasDisponibles.Count);
            int seleccion2;

            PalabrasDisponibles = ObtenImagenesConPalabra();

            do
            {
                seleccion2 = rand.Next(0, PalabrasDisponibles.Count);
            } while (seleccion1 == seleccion2);

            PrimeraPalabra = PalabrasDisponibles[seleccion1];
            SegundaPalabra = PalabrasDisponibles[seleccion2];

            pb1.BackgroundImage = Image.FromFile(ObtenerPath(PrimeraPalabra));
            pb2.BackgroundImage = Image.FromFile(ObtenerPath(SegundaPalabra));

            for (int i = 0; i < PrimeraPalabra.Length; i++) 
            {
                flp1.Controls[i].Visible = true;
            }

            for (int i = 0; i < SegundaPalabra.Length; i++)
            {
                flp2.Controls[i].Visible = true;
            }

            seleccion1=rand.Next(0,PrimeraPalabra.Length); 
            do
            {
                seleccion2 = rand.Next(0, PrimeraPalabra.Length);
            } while (seleccion1 == seleccion2);

            flp1.Controls[seleccion1].Text = PrimeraPalabra[seleccion1].ToString();
            flp1.Controls[seleccion2].Text = PrimeraPalabra[seleccion2].ToString();

            seleccion1 = rand.Next(0, SegundaPalabra.Length);
            do
            {
                seleccion2 = rand.Next(0, SegundaPalabra.Length);
            } while (seleccion1 == seleccion2);

            flp2.Controls[seleccion1].Text = SegundaPalabra[seleccion1].ToString();
            flp2.Controls[seleccion2].Text = SegundaPalabra[seleccion2].ToString();


        }

        
    }
}
