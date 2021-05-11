using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE_pa_Excentar.Mis_Clases
{
    class Alumno
    {

        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private String municipio;

        public String Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }






        private String noControl;
        public String NoControl
        {
            get { return noControl; }
            set { noControl = value; }
        }



        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



        private String carrera;



        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }



        private int semestre;



        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }



        private String contra;



        public String Contra
        {
            get { return contra; }
            set { contra = value; }
        }



        public Alumno(String noControl, String nombre, String carrera, int semestre, String contra, String telefono, String correo, String municipio, String estado, String direccion)
        {
            this.noControl = noControl;
            this.nombre = nombre;
            this.carrera = carrera;
            this.semestre = semestre;
            this.contra = contra;
            this.telefono = telefono;
            this.correo = correo;
            this.municipio = municipio;
            this.estado = estado;
            this.direccion = direccion;
        }



        public Alumno()
        {
        }
    }




}

