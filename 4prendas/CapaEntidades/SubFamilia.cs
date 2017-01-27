using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class SubFamilia
    {
        private String codSubFamilia;
        private String nombre;
        private String imagen;
        private int iva;
        
        public SubFamilia()
        {

        }

        public SubFamilia(String codSubFamilia, String nombre, String imagen, int iva)
        {
            this.codSubFamilia = codSubFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.iva = iva;
        }

        public String CodSubFamilia
        {
            get
            {
                return codSubFamilia;
            }
            set
            {
                codSubFamilia = value;
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

        public int Iva
        {
            get
            {
                return iva;
            }
            set
            {
                iva = value;
            }
        }
    }
}
