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
    public partial class PortadaLeccion : Form
    {
        int numImagenes;
        public PortadaLeccion(string titulo, string num, string img1)
        {
            InitializeComponent();
            lblLeccion.Text = "Lección " + num;
            lblLeccion.Location = new Point(Convert.ToInt32((this.Width / 2) - (lblLeccion.Width / 2)), lblLeccion.Location.Y);

            lblTitulo.Text = "\"" + titulo + "\"";
            lblTitulo.Location = new Point(Convert.ToInt32((this.Width / 2) - (lblTitulo.Width / 2)), lblTitulo.Location.Y);

            PictureBox pb1 = new PictureBox();
            pb1.BackgroundImage = Image.FromFile(img1);
            pb1.Size = new Size(436, 260);
            pb1.BackgroundImageLayout = ImageLayout.Stretch;
            pb1.Location = new Point(267, 240);
            this.Controls.Add(pb1);
            this.numImagenes = 1;
        }
        public PortadaLeccion(string titulo, string num, string img1, string img2, string img3)
        {
            InitializeComponent();
            lblLeccion.Text = "Lección " + num;
            lblLeccion.Location = new Point(Convert.ToInt32((this.Width / 2) - (lblLeccion.Width / 2)), lblLeccion.Location.Y);

            lblTitulo.Text = "\"" + titulo + "\"";
            lblTitulo.Location = new Point(Convert.ToInt32((this.Width / 2) - (lblTitulo.Width / 2)), lblTitulo.Location.Y);

            PictureBox pb1 = new PictureBox();
            pb1.BackgroundImage = Image.FromFile(img1);
            pb1.Size = new Size(300, 260);
            pb1.BackgroundImageLayout = ImageLayout.Stretch;
            pb1.Location = new Point(355, 240);
            this.Controls.Add(pb1);

            PictureBox pb2= new PictureBox();
            pb2.BackgroundImage = Image.FromFile(img2);
            pb2.BackgroundImageLayout= ImageLayout.Stretch;
            pb2.Size = new Size(300,260);
            pb2.Location = new Point(15, 240);
            this.Controls.Add(pb2);

            PictureBox pb3= new PictureBox();
            pb3.BackgroundImage = Image.FromFile(img3);
            pb3.BackgroundImageLayout = ImageLayout.Stretch;
            pb3.Size = new Size(300, 260);
            pb3.Location = new Point(655, 240);
            this.Controls.Add(pb3);


            this.numImagenes = 3;
        }

        private void PortadaLeccion_Resize(object sender, EventArgs e)
        {
            int numControles = 0;
            foreach(Control c in this.Controls) { numControles++; }

            if (numImagenes == 1)
            {
                this.Controls[numControles - 1].Location = new Point((this.Width / 2) - 218, 240);
            }else if(numImagenes == 3)
            {
                this.Controls[numControles - 1].Location = new Point((this.Width / 2) - 150, 240);
                this.Controls[numControles - 2].Location = new Point((this.Width-940)/2,240);
                this.Controls[numControles - 3].Location = new Point(((this.Width - 940) / 2) + 640, 240);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //se cierra el Menu con un mensaje interno de Abortar
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            lblVol.Text = (trbVolumen.Value.ToString()) + "%";
        }
    }
}
