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
    public partial class Avance_R : Form
    {

        string control = "";
        public JArray jArray;
        public JObject jsonAlum;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        public Avance_R(String control)
        {
            InitializeComponent();
            this.control = control;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Avance_R_Load(object sender, EventArgs e)
        {
            label1.Text = "Falta por cursar";
            label1.BackColor = Color.FromArgb(135, 187, 219);
            label2.Text = "Materia aprobada";
            label2.BackColor = Color.FromArgb(79, 234, 154);
            label3.Text = "Materia NO aprobada";
            label3.BackColor = Color.FromArgb(255, 142, 29);

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
                    { //N=no ha cursado
                        //int si curso
                        jsonAlumno = (JObject)json.GetValue("materiasDelCurso");
                        jsonAlum = (JObject)jsonAlumno.GetValue(control);
                        if (jsonAlum.GetValue("TAP").Equals("N"))
                            TAP.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("TAP")) < 70)
                            TAP.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("TAP")) >= 70)
                            TAP.BackColor = Color.FromArgb(79, 234, 154); 

                        if (jsonAlum.GetValue("Ingles").ToString().Equals("N"))
                            ingles.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Ingles")) < 70)
                            ingles.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Ingles")) >= 70)
                            ingles.BackColor = Color.FromArgb(79, 234, 154);

                        if (jsonAlum.GetValue("Principios Electricos").ToString().Equals("N"))
                            ingles.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Principios Electricos")) < 70)
                            pElec.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Principios Electricos")) >= 70)
                            pElec.BackColor = Color.FromArgb(79, 234, 154);

                        if (jsonAlum.GetValue("Metodos N").ToString().Equals("N"))
                            mN.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Metodos N")) < 70)
                            mN.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Metodos N")) >= 70)
                            mN.BackColor = Color.FromArgb(79, 234, 154);

                        if (jsonAlum.GetValue("Ecuaciones Diferenciales").ToString().Equals("N"))
                            eD.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Ecuaciones Diferenciales")) < 70)
                            eD.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Ecuaciones Diferenciales")) >= 70)
                            eD.BackColor = Color.FromArgb(79, 234, 154);

                        if (jsonAlum.GetValue("Simulacion").ToString().Equals("N"))
                            simulacion.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Simulacion")) < 70)
                            simulacion.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Simulacion")) >= 70)
                            simulacion.BackColor = Color.FromArgb(79, 234, 154);

                        if (jsonAlum.GetValue("Bases de datos").ToString().Equals("N"))
                            bD.BackColor = Color.FromArgb(135, 187, 219);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Bases de datos")) < 70)
                            bD.BackColor = Color.FromArgb(255, 142, 29);
                        else if (Convert.ToInt32(jsonAlum.GetValue("Bases de datos")) >= 70)
                            bD.BackColor = Color.FromArgb(79, 234, 154);

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer el archivo jajja" + ex);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Avance_R_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void TAP_Click(object sender, EventArgs e)
        {

        }
    }
}
