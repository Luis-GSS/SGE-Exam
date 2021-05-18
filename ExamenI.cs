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
        List<String> res = new List<String>();
        bool flag = true;
        string control;
        string mta, nom, banco, preguntas;
        public JArray jArray;
        public JObject jsonAlum;
        public JObject jsonAlumno;
        public JObject json;
        String lectura;
        //hola
        public ExamenI(string mta, string nom, string control, string banco, string preguntas)
        {
            InitializeComponent();
            this.mta = mta;
            this.nom = nom;
            this.control = control;
            this.banco = banco;
            this.preguntas = preguntas;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


            int calif=0;
            
            if (box1.SelectedItem.ToString().Equals(res[0])) {
                box1.BackColor = Color.LightGreen;
                calif++;
            } else box1.BackColor = Color.Red;

            if (box2.SelectedItem.ToString().Equals(res[1]))
            {
                box2.BackColor = Color.LightGreen;
                calif++;
            }
            else box2.BackColor = Color.Red;
            if (box3.SelectedItem.ToString().Equals(res[2]))
            {
                box3.BackColor = Color.LightGreen;
                calif++;
            }
            else box3.BackColor = Color.Red;
            if (box4.SelectedItem.ToString().Equals(res[3]))
            {
                box4.BackColor = Color.LightGreen;
                calif++;
            }
            else box4.BackColor = Color.Red;
            if (box5.SelectedItem.ToString().Equals(res[4]))
            {
                box5.BackColor = Color.LightGreen;
                calif++;
            }
            else box5.BackColor = Color.Red;
            if (box6.SelectedItem.ToString().Equals(res[5]))
            {
                box6.BackColor = Color.LightGreen;
                calif++;
            }
            else box6.BackColor = Color.Red;

            if (box7.SelectedItem.ToString().Equals(res[6]))
            {
                box7.BackColor = Color.LightGreen;
                calif++;
            }
            else box7.BackColor = Color.Red;
            if (box8.SelectedItem.ToString().Equals(res[7]))
            {
                box8.BackColor = Color.LightGreen;
                calif++;
            }
            else box8.BackColor = Color.Red;
            if (box9.SelectedItem.ToString().Equals(res[8]))
            {
                box9.BackColor = Color.LightGreen;
                calif++;
            }
            else box9.BackColor = Color.Red;
            if (box10.SelectedItem.ToString().Equals(res[9]))
            {
                box10.BackColor = Color.LightGreen;
                calif++;
            }
            else box10.BackColor = Color.Red;
            calif=calif * 10;
            if (flag)
            {
                int califF = calif;
                if (calif < 70)
                {
                    
                    cal.BackColor = Color.Red;
                    MessageBox.Show("Ponte a estudiar joto");
                    
                    
                }
                else {
                    cal.BackColor = Color.LightGreen;
                    MessageBox.Show("Copiaste...");

                }
                cal.Text = cal.Text + " " + califF;
                flag = false;
            }

            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
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
                    if (json.ContainsKey(banco))
                    {
                        jsonAlumno = (JObject)json.GetValue(banco);
                        if (jsonAlumno.ContainsKey(preguntas))
                        {


                            JArray jArray = (JArray)jsonAlumno.GetValue(preguntas);
                            int j = 0;
                            foreach (JObject jObject in jArray)
                            {

                                if (list.Contains((int)jObject.GetValue("ID")))
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box1.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box2.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box3.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box4.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box5.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box6.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box7.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box8.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box9.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 1)
                                        {
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
                                        }
                                        if (vr == 2)
                                        {
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta1"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_correcta"));
                                            box10.Items.Add((String)jObject.GetValue("Respuesta_incorrecta2"));
                                            res.Add((String)jObject.GetValue("Respuesta_correcta"));
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
