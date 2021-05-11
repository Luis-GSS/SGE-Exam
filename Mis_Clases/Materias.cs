using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE_pa_Excentar.Mis_Clases
{
    class Materias
    {
        private String nomMateria;

        public String NomMateria
        {
            get { return nomMateria; }
            set { nomMateria = value; }
        }

        private String hora;

        public String Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private String [] miembros;

        public String [] Miembros
        {
            get { return miembros; }
            set { miembros = value; }
        }

        private int [] calif;

        public int [] Calif
        {
            get { return calif; }
            set { calif = value; }
        }

        public Materias(String nomMateria, String hora, String [] miembros, int [] calif)
        {
            this.nomMateria = nomMateria;
            this.hora = hora;
            this.miembros = miembros;
            this.calif = calif;
        }

        


        public Materias()
        {
        }


    }
}
