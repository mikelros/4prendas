using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Familia
    {
        private string codFamilia;
        private string nombre;
        private string imagen;
        private List<SubFamilia> subFamilias = new List<SubFamilia>();
        private int numCodigo;

        public Familia()
        {

        }

        public Familia(string codFamilia, string nombre, string imagen, int numCod)
        {
            this.codFamilia = codFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.numCodigo = numCod;
        }

        public Familia(string codFamilia, string nombre, string imagen, int numCod, List<SubFamilia> subFamilias) 
        {
            this.codFamilia = codFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.numCodigo = numCod;
            this.subFamilias = subFamilias;
        }

        public string CodFamilia
        {
            get
            {
                return codFamilia;
            }
            set
            {
                codFamilia = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
            }
        }

        public List<SubFamilia> SubFamilias
        {
            get
            {
                return subFamilias;
            }
            set
            {
                subFamilias = value;
            }
        }

        public int NumCodigo
        {
            get
            {
                return numCodigo;
            }
            set
            {
                numCodigo = value;
            }
        }
    }
}
