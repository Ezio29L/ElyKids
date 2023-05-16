using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ElyKids_Software_Didactico
{
    public class BotonesGrupoAlmacen : Button
    {
        GrupoLecciones grupo;
        public GrupoLecciones Encapsulado
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public void GenerarOtrosBotones(object sender, EventArgs e)
        {
            Control FlowPanel2 = this.Parent.Parent.Controls[1];

            //crea un boton por cada leccion del grupo
            foreach(Lecciones l in grupo.lecciones)
            {
                BotonesLeccionAlmacen btnLec = new BotonesLeccionAlmacen();
                btnLec.Size = new System.Drawing.Size(180, 238);
                btnLec.Image = Image.FromFile(ObtenerUrl("Leccion_" + l.Numero.ToString() + ".jpg"));
                btnLec.ImageAlign = ContentAlignment.MiddleCenter;
                btnLec.Text = string.Empty;
                btnLec.Encapsulado= l;
                btnLec.Click += new EventHandler(btnLec.CorrerLeccion); 
                FlowPanel2.Controls.Add(btnLec);

            }

        }

        private string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }

    }
    public class BotonesLeccionAlmacen : Button
    {
        Lecciones leccion;
        

        public Lecciones Encapsulado
        {
            get { return leccion; }
            set { leccion = value; }
        }
        
        public void CorrerLeccion(object sender, EventArgs e)
        {
            Lecturas lectura = leccion.mostrarlecturas();
            int Estado = 0;
            string[] ImagenesPortadaLeccion = leccion.ObtenerImagenesPortadaLeccion();
            PortadaLeccion portada;
            if (ImagenesPortadaLeccion.Length == 1)
            {
                portada = new PortadaLeccion(leccion.Nombre, leccion.Numero.ToString(), ImagenesPortadaLeccion[0]);
            }else
            {
                portada = new PortadaLeccion(leccion.Nombre, leccion.Numero.ToString(), ImagenesPortadaLeccion[0], ImagenesPortadaLeccion[1], ImagenesPortadaLeccion[2]);
            }

            this.Parent.Parent.Parent.Visible= false;
            do
            {
                switch(Estado)
                {
                    case 0:
                        //este caso muestra la portada
                        portada.ShowDialog();
                        if(portada.DialogResult == DialogResult.OK) { Estado++; }
                        else if(portada.DialogResult== DialogResult.Abort) { Estado--; }
                        else if(portada.DialogResult== DialogResult.Cancel) { Estado = -2; }
                        break;

                    case 1:
                        //este caso muestra la lectura
                        lectura.ShowDialog();
                        if (lectura.DialogResult == DialogResult.OK) { Estado++; }
                        else if (lectura.DialogResult == DialogResult.Abort) { Estado--; }
                        else if(lectura.DialogResult==DialogResult.Cancel) { Estado = -2; }
                        break;

                    case 2:
                        //Este muestra la actividad
                        Estado=5; 
                        break;

                    case 3:
                        //este caso muestra la actividad de Trazado de Letra
                        break;

                    case 4:
                        //Este caso contempla una pantalla de Felicitaciones.
                        break;
                }
            } while (Estado > -1 && Estado != 5);

            this.Parent.Parent.Parent.Visible = true;

            if (Estado == -2) 
            {
                this.Parent.Parent.Parent.Dispose();
            }
        }
    }
}
