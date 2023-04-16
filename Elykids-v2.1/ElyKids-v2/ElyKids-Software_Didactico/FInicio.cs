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
            WMP.URL = ObtenerUrl("intro.wav");
            WMP.settings.volume = 100;
            WMP.Ctlcontrols.play();
        }

        private void eButton1_Click(object sender, EventArgs e)
        {
            
        }
        private string ObtenerUrl(string url)
        {
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolumen_Click_1(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            lblVol.Text=(trbVolumen.Value.ToString())+"%";
            WMP.settings.volume= trbVolumen.Value;
        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }
    }
}
