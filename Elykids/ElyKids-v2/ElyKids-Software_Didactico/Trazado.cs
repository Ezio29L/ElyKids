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
    public partial class Trazado : Form
    {
        //
        Graphics g;
        Boolean cursormov = false;
        //creamos nuestra pluma y establecemos las coordenadas de inicio
        Pen cursorpen;
        int cursorX = -1;
        int cursorY = -1;
        public Trazado()
        {
            InitializeComponent();
            //creamos el "lienzo"
            g = Lienzo.CreateGraphics();
            //Creamos una nueva pluma con una punta de 7 pixeles
            cursorpen = new Pen(Color.Black,10);
            //Establecemos la forma de pintado, que sea redondo y que sea smooth.
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorpen.StartCap = System.Drawing.Drawing2D.LineCap.Round; //Inicio del trazo
            cursorpen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //Terminado del trazo
        }
        //Establecer el color de la pluma
        private void Dibujar_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
        }
//Codigo para el movimiento del mouse
        private void Lienzo_MouseDown(object sender, MouseEventArgs e)
        {
            cursormov = true;
            cursorX = e.X; cursorY = e.Y;
        }
        //Para cuando se dejo de mover
        private void Lienzo_MouseUp(object sender, MouseEventArgs e)
        {
            cursormov = false;
            cursorX = -1; cursorY = -1;
        }
        //Para detener la pluma
        private void Lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if(cursorX !=  -1 && cursorY != -1 && cursormov == true) 
            {
                g.DrawLine(cursorpen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X; cursorY = e.Y;
            }
        }
        //Boton para borrar todo el contenido del panel
        private void Borrarbtn_Click(object sender, EventArgs e)
        {
            Lienzo.Refresh();
        }
    }
}
