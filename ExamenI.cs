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
    public partial class ExamenI : Form
    {
        
        string control;
        string mta, nom;
        public JArray jArray;
        public JObject jsonAlum;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        //hola
        public ExamenI(string mta, string nom, string control)
        {
            InitializeComponent();
            this.mta = mta;
            this.nom = nom;
            this.control = control;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ExamenI_Load(object sender, EventArgs e)
        {
            //yo
            List  < int > list = new List<int>();
            
            Random r = new Random();
          
            for (int i = 0; i < 10; i++)
            {
                int v = r.Next(1, 16);
                if (!list.Contains(v))
                {
                    list.Add(v);
                }
                else i--;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            
          





            nomE.Text = nomE.Text + mta;
            nomA.Text = nomA.Text + nom;
            numC.Text = numC.Text + control;

            
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
                    if (json.ContainsKey("BancodePreguntasdeIngles"))
                    {
                        jsonAlumno = (JObject)json.GetValue("BancodePreguntasdeIngles");
                        if (jsonAlumno.ContainsKey("preguntasI"))
                        {


                            JArray jArray = (JArray)jsonAlumno.GetValue("preguntasI");
                            int j = 0;
                            foreach (JObject jObject in jArray)
                            {

                                if (list.Contains((int)jObject.GetValue("ID_TAP")))
                                {

                                    listBox1.Items.Add((String)jObject.GetValue("Pregunta"));
                                    listBox1.Items.Add("");
                                    listBox1.Items.Add("");

                                    if (j == 0)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 1)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 2)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 3)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 4)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 5)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 6)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 7)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 8)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    if (j == 9)
                                    {
                                        int vr = r.Next(0, 3);
                                        Console.WriteLine(vr);
                                        if (vr == 0)
                                        {
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                        if (vr == 1)
                                        {
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                        }
                                    }
                                    j++;
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
        }
    }
}
