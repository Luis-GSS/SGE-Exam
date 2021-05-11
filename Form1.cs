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
    public partial class Form1 : Form
    {
        private JObject json;
        private JObject jsonAlumnos;


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bRegiter_Click_1(object sender, EventArgs e)
        {
            FormRegistrar fr = new FormRegistrar();
            fr.Show();
        }

        private void bLogin_Click_1(object sender, EventArgs e)
        {
            string control = "";
            string contra = "", nom=""; 
            json = new JObject();
            jsonAlumnos = new JObject();
            //lee archivos
            try
            {
                StreamReader sr = new StreamReader("SGE.json");
                String lectura = sr.ReadToEnd();
                sr.Close();
                json = JObject.Parse(lectura);
                if (json.ContainsKey("AlumnosRegistrados"))
                {
                    jsonAlumnos = (JObject)json.GetValue("AlumnosRegistrados");

                    if (jsonAlumnos.ContainsKey("alumnos"))
                    {
                        
                        JArray jArray = (JArray)jsonAlumnos.GetValue("alumnos");
                        for (int i = 0; i < jArray.Count; i++)
                        {
                            JObject al = (JObject)jArray[i];
                            if (al.GetValue("NoControl").ToString().Equals(fieldControl.Text) && al.GetValue("Contra").ToString().Equals(fieldContra.Text))
                            {
                                control = al.GetValue("NoControl").ToString();
                                contra = al.GetValue("Contra").ToString();
                                nom = al.GetValue("Nombre").ToString();
                                break;
                            }
                        }
                        if (control.Equals(fieldControl.Text) && contra.Equals(fieldContra.Text))
                        {
                            pagprin frp = new pagprin(control, fieldContra.Text, nom);
                            Form1 nel = new Form1();
                            showMessage("Bienvenido al Sistema Gestor Para Escuelas " + nom, 2000);
                            this.Hide();
                            frp.Show();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("La contraseña o el numero de control es incorrecto checa tus datos bro :D");
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer: " + ex);
                MessageBox.Show("Error al leer el archivo xd");

            }


        }

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}