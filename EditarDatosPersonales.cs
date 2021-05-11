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
    public partial class EditarDatosPersonales : Form
    {
        public JArray jArray;
        String control, contra;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        string carr = "", sem = "",tel = "", correo = "", muni="", esta="", dir = "";
        public EditarDatosPersonales(String control, String contra)
        {
            InitializeComponent();
            this.control = control;
            this.contra = contra;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            json = new JObject();
            jsonAlumno = new JObject();
           
            Alumno al = new Alumno();
            al.Carrera = fCarrera.Text;
            al.Contra = fContraseña.Text;
            al.NoControl = control;
            al.Nombre = nom.Text;
            al.Semestre = Convert.ToInt32(fSemestre.Text);
            al.Correo = fCorreo.Text;
            al.Direccion = fDireccion.Text;
            al.Estado = fEstado.Text;
            al.Municipio = fMunicipio.Text;
            al.Telefono = fTelefono.Text;

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

                            foreach (JObject jObject in jArray)
                            {
                                if (jObject.GetValue("NoControl").ToString().Equals(control))
                                {
                                    jObject.Remove();
                                    break;
                                }
                            }


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
                            
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);

            }
        }

        private void EditarDatosPersonales_Load(object sender, EventArgs e)
        {
            
            contro.Text = control;
            fContraseña.Text = contra;
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
                                if(jObject.GetValue("NoControl").ToString().Equals(control))
                                {
                                    nom.Text = jObject.GetValue("Nombre").ToString();
                                    sem = jObject.GetValue("Semestre").ToString();
                                    fSemestre.Text = sem;
                                    carr = jObject.GetValue("Carrera").ToString();
                                    fCarrera.Text = carr;
                                    tel = jObject.GetValue("Telefono").ToString();
                                    fTelefono.Text = tel;
                                    correo = jObject.GetValue("Correo").ToString();
                                    fCorreo.Text = correo;
                                    muni = jObject.GetValue("Municipio").ToString();
                                    fMunicipio.Text = muni;
                                    esta = jObject.GetValue("Estado").ToString();
                                    fEstado.Text = esta;
                                    dir = jObject.GetValue("Direccion").ToString();
                                    fDireccion.Text = dir;
                                    break;
                                }
                                                               
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo dtperson" + ex);

            }
        }

        private void fCarrera_Enter(object sender, EventArgs e)
        {
            fCarrera.Text = "";
        }

        private void fSemestre_Enter(object sender, EventArgs e)
        {
            fSemestre.Text = "";
        }

        private void fSemestre_Leave(object sender, EventArgs e)
        {
            if (fSemestre.Text == "")
                fSemestre.Text = sem;
        }

        private void fTelefono_Leave(object sender, EventArgs e)
        {
            if (fTelefono.Text == "")
                fTelefono.Text = tel;
        }

        private void fCorreo_Enter(object sender, EventArgs e)
        {
            fCorreo.Text = "";

        }

        private void fCorreo_Leave(object sender, EventArgs e)
        {
            if (fCorreo.Text == "")
                fCorreo.Text = correo;
        }

        private void fMunicipio_Enter(object sender, EventArgs e)
        {
            fMunicipio.Text = "";
        }

        private void fMunicipio_Leave(object sender, EventArgs e)
        {
            if (fMunicipio.Text == "")
                fMunicipio.Text = muni;
        }

        private void fEstado_Enter(object sender, EventArgs e)
        {
            fEstado.Text = "";
        }

        private void fEstado_Leave(object sender, EventArgs e)
        {
            if (fEstado.Text == "")
                fEstado.Text = esta;
        }

        private void fDireccion_Enter(object sender, EventArgs e)
        {
            fDireccion.Text = "";
        }

        private void fDireccion_Leave(object sender, EventArgs e)
        {
            if (fDireccion.Text == "")
                fDireccion.Text = dir;
        }

        private void nom_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void fContraseña_Enter(object sender, EventArgs e)
        {
            fContraseña.Text = "";
        }

        private void fContraseña_Leave(object sender, EventArgs e)
        {
            if (fContraseña.Text == "")
                fContraseña.Text = contra;
        }

        private void fTelefono_Enter(object sender, EventArgs e)
        {
            fTelefono.Text = "";
        }

        private void fCarrera_Leave(object sender, EventArgs e)
        {
            if (fCarrera.Text=="")
            fCarrera.Text = carr;
        }

        private void fCarrera_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
