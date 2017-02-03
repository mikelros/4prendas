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
        private List<SubFamilia> subFamilias;

        public Familia()
        {

        }

        public Familia(string codFamilia, string nombre, string imagen)
        {
            this.codFamilia = codFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
        }

        public Familia(string codFamilia, string nombre, string imagen, List<SubFamilia> subFamilias) 
        {
            this.codFamilia = codFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
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
    }
}
