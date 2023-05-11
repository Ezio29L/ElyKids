using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using ElyKids_Software_Didactico;

namespace Generador_de_Clases
{
    public partial class Form1 : Form
    {
        List<string> lectura = new List<string>();
        List<Lecciones> lecciones = new List<Lecciones>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!=string.Empty)
            {
                listBox1.Items.Add(textBox4.Text);
                lectura.Add(textBox4.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i > -1)
            {
                listBox1.Items.RemoveAt(i);
                lblMensaje.Text = "Se removio: " + lectura[i];
                lectura.RemoveAt(i);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((textBox2.Text!=string.Empty)&&(textBox3.Text!=string.Empty)&&(textBox4.Text!=string.Empty))
            {
                Lecturas Lee = new Lecturas(lectura, "Lectura-Leccion-" + textBox3.Text + ".png");
                lecciones.Add(new Lecciones(textBox2.Text,Convert.ToInt32(textBox3.Text),Lee));
                listBox2.Items.Add(textBox2.Text);
                lectura.Clear();
                listBox1.Items.Clear();
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
            }
            else
            {
                lblMensaje.Text = "Falta algun campo";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            if(i > -1)
            {
                listBox2.Items.RemoveAt(i);
                lblMensaje.Text = "se quito la leccion: " + lecciones[i].Nombre;
                lecciones.RemoveAt(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GrupoLecciones Parte = new GrupoLecciones(lecciones, textBox1.Text);
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialogo = new System.Windows.Forms.SaveFileDialog())
                {
                    dialogo.FileName = textBox1.Text;
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        using (var st = new StreamWriter (dialogo.FileName))
                        {
                            var formato = new XmlSerializer(typeof(GrupoLecciones));
                            formato.Serialize(st, Parte);
                            lblMensaje.Text = "Se supone que se guardo, compruebalo";
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "No se ha guardado aun.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Valio madre esta Guardada";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                Muestra_Leccion muestra = new Muestra_Leccion(lecciones[listBox2.SelectedIndex]);
                muestra.Show();
            }
                

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialogo = new OpenFileDialog())
                {
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.Open))
                        {
                            var formato = new XmlSerializer(typeof(GrupoLecciones));

                            
                            //Aqui esta el problema, pero aun estoy trabajando en el.
                            GrupoLecciones Gl = (GrupoLecciones) formato.Deserialize(st);

                            textBox1.Text = Gl.NombreGrupo;
                            listBox2.Items.Clear();
                            foreach (Lecciones clase in Gl.lecciones)
                            {
                                listBox2.Items.Add(clase.Nombre);
                                this.lecciones.Add(clase);
                            }
                        }
                        MessageBox.Show("Se supone que se cargo");
                    }
                    else
                    {
                        MessageBox.Show("No se abrio nada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valio madre este pedo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
