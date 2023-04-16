using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elykids
{
    public partial class VenetanaInicio : Form
    {

        private bool esVisible = false;
        public VenetanaInicio()
        {
            InitializeComponent();

            
        }

        private void VenetanaInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSt_Click(object sender, EventArgs e)
        {

        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if(esVisible)
            {
                PanVolumen.Visible = false;
                esVisible = false;
            }
            else
            {
                PanVolumen.Visible = true;
                esVisible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanVolumen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbVolumen_Scroll(object sender, EventArgs e)
        {
            label2.Text= (tbVolumen.Value.ToString()) + "%";
        }
    }
}
