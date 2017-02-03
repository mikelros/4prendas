using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        private string profesor;
        private string curso;

        public Persona() { }

        public Persona(string profesor, string curso)
        {
            this.profesor = profesor;
            this.curso = curso;
        }

        public string Profesor
        {
            get
            {
                return profesor;
            }
            set
            {
                profesor = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }
            set
            {
                curso = value;
            }
        }
    }
}
