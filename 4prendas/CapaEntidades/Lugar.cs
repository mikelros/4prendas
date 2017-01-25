using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Lugar
    {
        private String estanteria;
        private int estante;
        private int altura;

        public Lugar()
        {

        }

        public Lugar(String estanteria, int estante, int altura)
        {
            this.estanteria = estanteria;
            this.estante = estante;
            this.altura = altura;
        }

        public String Estanteria
        {
            get
            {
                return estanteria;
            }
            set
            {
                estanteria = value;
            }
        }

        public int Estante
        {
            get
            {
                return estante;
            }
            set
            {
                estante = value;
            }
        }

        public int Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
    }
}
