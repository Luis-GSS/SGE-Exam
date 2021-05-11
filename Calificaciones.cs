using Newtonsoft.Json.Linq;
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
    public partial class Calificaciones : Form
    {
        string control = "";
        public JArray jArray;
        public JObject jsonAlum;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        public Calificaciones(String control)
        {
            InitializeComponent();
            this.control = control;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hola mundo");
            int i = 0;
            json = new JObject();
            jsonAlumno = new JObject();
            jsonAlum = new JObject();
            try
            {
                StreamReader sr = new StreamReader("SGE.json");
                lectura = sr.ReadToEnd();
                //si
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
                                    string s = "";
                                    if (jsonAlumno.ContainsKey(control))
                                    {
                                        jsonAlum = (JObject)jsonAlumno.GetValue(control);
                                        s = (string)jsonAlum.GetValue((string)jObject.GetValue("NomMateria")); //s = calificacion jsonalum= nocontrol
                                    }

                                    string [] rowArray = { (string)jObject.GetValue("NomMateria"), s};

                                    dataGridView1.Rows.Insert(i, rowArray);
                                    i++;
                                }
                                
                                
                            }
                        }
                        
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);

            }
       

            double prome=0;
            for (int a = 0; a < dataGridView1.Rows.Count -1; a++)
            {

                if (dataGridView1.Rows[a].Cells[1].ToString() != "")
                {
                    prome = prome + Convert.ToInt32(dataGridView1.Rows[a].Cells[1].Value.ToString());

                    if (Convert.ToInt32(dataGridView1.Rows[a].Cells[1].Value.ToString()) < 70)
                        dataGridView1.Rows[a].Cells[1].Style.ForeColor = Color.Red;
                }


            }
            prome /=  dataGridView1.Rows.Count-1;
            prom.Text = prome.ToString("N2");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}