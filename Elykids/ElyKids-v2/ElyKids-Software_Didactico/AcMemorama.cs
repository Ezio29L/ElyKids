using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        string[] TarjSeleccionables = new string[3];
        List<string> Maso = new List<string>();

        public AcMemorama(int leccion)
        {
            InitializeComponent();
            NumLeccion = leccion;
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
            if (TarjSeleccionables.Length < 1)
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void AcMemorama_Load(object sender, EventArgs e)
        {

        }
    }
}
