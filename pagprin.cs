using Newtonsoft.Json.Linq;
using SGE_pa_Excentar.Mis_Clases;
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

namespace SGE_pa_Excentar
{
    public partial class pagprin : Form
    {
        string control;
        string contra, nom;
        public JArray jArray;
        public JObject jsonAlum;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        public pagprin(string control, String contra, string nom)
        {
            InitializeComponent();
            this.control = control;
            this.contra = contra;
            this.nom = nom;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public pagprin()
        {
            InitializeComponent();
            

        }

        private void asdkjasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagprin_Load(object sender, EventArgs e)
        {
            label2.Text = "Hola, bienvenid@ " + nom + "\nAcontinuacion encontraras tu horario";
            noControl.Text = control;
            int i = 0;
            json = new JObject();
            jsonAlumno = new JObject();
            jsonAlum = new JObject();
           try
            {
                StreamReader sr = new StreamReader("SGE.json");
                lectura = sr.ReadToEnd();
                sr.Close();
                json = JObject.Parse(lectura);
                if (lectura != null)
                {
                    if (json.ContainsKey("materiasDelCurso"))
                    {
                        jsonAlumno = (JObject)json.GetValue("materiasDelCurso");
                        if (jsonAlumno.ContainsKey("materias"))
                        {


                            JArray jArray = (JArray)jsonAlumno.GetValue("materias");

                            foreach (JObject jObject in jArray)
                            {

                               

                                if (jObject.GetValue("Miembros").ToString().Contains(control))
                                {


                                    string[] rowArray = { (string)jObject.GetValue("NomMateria"), (string)jObject.GetValue("Hora") };
                                  
                                    dataGridView1.Rows.Insert(i, rowArray);
                                    i++;
                                }
                                
                                
                            }
                        }
                        if (jsonAlumno.ContainsKey("19121077"))
                        {
                            jsonAlum = (JObject)jsonAlumno.GetValue("19121077");
                            Console.WriteLine(jsonAlum.GetValue("TAP"));
                        }
                    }
                    
                }
                



            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);

            }

           






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificaciones frp = new Calificaciones(control);
            frp.Show();
            
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDatosPersonales frp = new EditarDatosPersonales(control, contra);
            frp.Show();
            
        }

        private void reticulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avance_R frp = new Avance_R(control);
            frp.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 nel = new Form1();
            nel.Show();
            this.Close();
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Este codigo y su diseño fue creado por Luis Gerado Sanchez Santoyo");
        }

        private void correoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luisanze30@gmail.com");
        }

        private void telefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4437315731");
        }

        private void direccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("P-Sherman, calle Wallaby 42, Sidney");
        }

        private void obtenerAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se. \n Espero haber ayudado");
        }

        private void pagprin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void pagprin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamenI nel = new ExamenI("Ingles", nom, control, "BancodePreguntasdeIngles", "preguntasI");
            nel.Show();
            
        }

        private void principiosElecrtricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamenI nel = new ExamenI("Principios Electricos", nom, control, "BancodePreguntasdePrincipiosElectricos", "preguntasPE");
            nel.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}