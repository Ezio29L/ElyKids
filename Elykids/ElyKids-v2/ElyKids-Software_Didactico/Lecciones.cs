using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElyKids_Software_Didactico
{
    [Serializable()]
    public class GrupoLecciones
    {
        public string NombreGrupo;
        public List<Lecciones> lecciones = new List<Lecciones>();

        public GrupoLecciones(List<Lecciones> lecciones, string nombreGrupo)
        {
            this.lecciones = lecciones;
            NombreGrupo = nombreGrupo;
        }
        public GrupoLecciones()
        {
            //este constructor es nomas para lo de Cargar Instancias desde archivos y NUNCA debe ser usado en Codigo
        }
        public string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }
        /*public string Guardar()
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialogo = new System.Windows.Forms.SaveFileDialog())
                {
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.Create))
                        {
                            var formato = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            formato.Serialize(st, this);
                        }
                        return "Se supone que se guardo, compruebalo";
                    }
                    else
                    {
                        return "No se ha guardado aun.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Valio madre esta Guardada";
            }
        }*/
    }
    [Serializable()]
    public class Lecciones
    {
        public string Nombre;
        public int Numero;
        public Lecturas lectura;

        public Lecciones(string nombre, int numero, Lecturas lectura)
        {
            Nombre = nombre;
            Numero = numero;
            this.lectura = lectura;
            
        }
        public Lecciones()
        {
            //este constructor es nomas para lo de Cargar Instancias desde archivos y NUNCA debe ser usado en Codigo
        }
        public string ObtenerUrl(string url)
        {
            //Esta funcion pasa la direccion de un recurso dado a un formato en que el objeto Windows Media Player puede entender.
            FileInfo file = new FileInfo(@"../../Resources/" + url);
            return file.FullName;
        }
        
    }
}
