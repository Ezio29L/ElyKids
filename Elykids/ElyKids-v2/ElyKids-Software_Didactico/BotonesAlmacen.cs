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
            Portada PortadaDeActividad = new Portada(leccion.Actividad);
            Portada portadaLeccion;

            if (ImagenesPortadaLeccion.Length == 1)
            {
                portadaLeccion = new Portada(leccion.Nombre, leccion.Numero.ToString(), ImagenesPortadaLeccion[0]);
            }else
            {
                portadaLeccion = new Portada(leccion.Nombre, leccion.Numero.ToString(), ImagenesPortadaLeccion[0], ImagenesPortadaLeccion[1], ImagenesPortadaLeccion[2]);
            }

            AcMemorama memorama = new AcMemorama(leccion.Numero);
            AcRelacionPalabraImagen relacionPalabraImagen = new AcRelacionPalabraImagen(leccion.Vocabulario);
            AcCompletarPalabra completarPalabra = new AcCompletarPalabra(leccion.Vocabulario);

            this.Parent.Parent.Parent.Visible= false;
            do
            {
                switch(Estado)
                {
                    case 0:
                        //este caso muestra la portada
                        portadaLeccion.ShowDialog();
                        if(portadaLeccion.DialogResult == DialogResult.OK) { Estado++; }
                        else if(portadaLeccion.DialogResult== DialogResult.Abort) { Estado--; }
                        else if(portadaLeccion.DialogResult== DialogResult.Cancel) { Estado = -2; }
                        break;

                    case 1:
                        //este caso muestra la lectura
                        lectura.ShowDialog();
                        if (lectura.DialogResult == DialogResult.OK) { Estado++; }
                        else if (lectura.DialogResult == DialogResult.Abort) { Estado--; }
                        else if(lectura.DialogResult==DialogResult.Cancel) { Estado = -2; }
                        break;

                    case 2:
                        //Este muestra Portada de la actividad
                        PortadaDeActividad.ShowDialog();
                        if (PortadaDeActividad.DialogResult == DialogResult.OK) { Estado++; }
                        else if (PortadaDeActividad.DialogResult == DialogResult.Abort) { Estado--; }
                        else if (PortadaDeActividad.DialogResult == DialogResult.Cancel) { Estado = -2; }
                        break;

                    case 3:
                        //este caso muestra la actividad
                        switch (leccion.Actividad)
                        {
                            case 1:
                                
                                memorama.ShowDialog();
                                if (memorama.DialogResult == DialogResult.OK) { Estado++; }
                                else if (memorama.DialogResult == DialogResult.Abort) { Estado--; }
                                else if (memorama.DialogResult == DialogResult.Cancel) { Estado = -2; }
                                break;
                            case 2:
                                
                                relacionPalabraImagen.ShowDialog();
                                if (relacionPalabraImagen.DialogResult == DialogResult.OK) { Estado++; }
                                else if (relacionPalabraImagen.DialogResult == DialogResult.Abort) { Estado--; }
                                else if (relacionPalabraImagen.DialogResult == DialogResult.Cancel) { Estado = -2; }
                                break;
                            case 3:
                                
                                completarPalabra.ShowDialog();
                                if (completarPalabra.DialogResult == DialogResult.OK) { Estado++; }
                                else if (completarPalabra.DialogResult == DialogResult.Abort) { Estado--; }
                                else if (completarPalabra.DialogResult == DialogResult.Cancel) { Estado = -2; }
                                break;
                        }
                        break;

                    case 4:
                        PantallaCierre cierre;
                        switch (leccion.Actividad)
                        {
                            case 1:
                                cierre = new PantallaCierre(memorama.Calificar);
                                break;
                            case 2:
                                cierre = new PantallaCierre(relacionPalabraImagen.Calificar);
                                break;
                            case 3:
                                cierre = new PantallaCierre(completarPalabra.Calificar);
                                break;
                            default:
                                cierre = new PantallaCierre(0);
                                break;
                        }
                        cierre.ShowDialog();
                        if (cierre.DialogResult == DialogResult.OK) { Estado++; }
                        else if (cierre.DialogResult == DialogResult.Abort) { Estado--; }
                        else if (cierre.DialogResult == DialogResult.Cancel) { Estado = -2; }
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
