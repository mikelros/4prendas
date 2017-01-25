using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Familia
    {
        private String codFamilia;
        private String nombre;
        private String imagen;
        private List<SubFamilia> subFamilias;

        public Familia()
        {

        }

        public Familia(String codFamilia, String nombre, String imagen, ArrayList<SubFamilia> subFamilias) 
        {
            this.codFamilia = codFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.subFamilias = subFamilias;
        }

        public String CodFamilia
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

        public String Nombre
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

        public String Imagen
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
