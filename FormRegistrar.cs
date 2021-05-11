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
    public partial class FormRegistrar : Form
    {
        public JArray jArray;
        
        public JObject jsonAlumno;
        public JObject json;
        String lectura;

        public FormRegistrar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            jArray = new JArray();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bRregis_Click(object sender, EventArgs e)
        {
            json = new JObject();
            jsonAlumno = new JObject();

            Alumno al = new Alumno();
            al.Carrera = fCarrera.Text;
            al.Contra = fContraseña.Text;
            al.NoControl = fNocontrol.Text;
            al.Nombre = fNombre.Text;
            al.Semestre = Convert.ToInt32(fSemestre.Text);
            al.Correo = "";
            al.Direccion = "";
            al.Estado = "";
            al.Municipio = "";
            al.Telefono = "";


            JObject dt = JObject.FromObject(al);
            
                try
                {
                    StreamReader sr = new StreamReader("SGE.json");
                    lectura = sr.ReadToEnd();
                    sr.Close();
                    json = JObject.Parse(lectura);
                    if (lectura != null)
                    {
                        if (json.ContainsKey("AlumnosRegistrados"))
                        {
                            jsonAlumno = (JObject)json.GetValue("AlumnosRegistrados");
                            if (jsonAlumno.ContainsKey("alumnos"))
                            {

                            jArray = (JArray)jsonAlumno.GetValue("alumnos");
                            jArray.Add(dt);
                          //jsonAlumno.Add("alumnos", jArray);
                            //json.Add("alumnosRegistrados", jsonAlumno);

                                
                            
                                try
                                {
                                    StreamWriter sw = new StreamWriter("SGE.json", false);
                                    sw.WriteLine(json.ToString());
                                    sw.Close();

                                    MessageBox.Show("Alumno Registrado con exito sisi");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error al registrar: " + ex);
                                    MessageBox.Show("No se registro el alumno intentalo de nuevo");
                                }




                                
                                foreach (JObject jObject in jArray)
                                {
                                    Console.WriteLine(jObject.GetValue("NoControl"));
                                }
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);

                }

            
           





        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            json = new JObject();
            jsonAlumno = new JObject();
            try
            {
                StreamReader sr = new StreamReader("SGE.json");
                lectura = sr.ReadToEnd();
                sr.Close();
                json = JObject.Parse(lectura);
                if (lectura != null)
                {
                    if (json.ContainsKey("AlumnosRegistrados"))
                    {
                        jsonAlumno = (JObject)json.GetValue("AlumnosRegistrados");
                        if (jsonAlumno.ContainsKey("alumnos"))
                        {
                            

                            JArray jArray = (JArray)jsonAlumno.GetValue("alumnos");
                            foreach (JObject jObject in jArray)
                            {
                                Console.WriteLine(jObject.GetValue("NoControl"));
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
