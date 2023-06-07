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
    public partial class PantallaCierre : Form
    {
        public PantallaCierre(float Calificacion)
        {
            InitializeComponent();
            lblCalificacion.Text = Calificacion.ToString();
            pictureBox2.Image = Image.FromFile(ObtenerUrl("niños.gif"));
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            this.Close();
        }

        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }
    }
}
