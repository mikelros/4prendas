using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Lugar
    {
        private int id;
        private string estanteria;
        private int estante;
        private int altura;

        public Lugar()
        {

        }

        public Lugar(string estanteria, int estante, int altura)
        {
            this.estanteria = estanteria;
            this.estante = estante;
            this.altura = altura;
        }

        public Lugar(int id, string estanteria, int estante, int altura)
        {
            this.estanteria = estanteria;
            this.estante = estante;
            this.altura = altura;
            this.id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public string Estanteria
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
