using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class SubFamilia
    {
        private string codSubFamilia;
        private string nombre;
        private string imagen;
        private int iva;
        
        public SubFamilia()
        {

        }

        public SubFamilia(string codSubFamilia, string nombre, string imagen, int iva)
        {
            this.codSubFamilia = codSubFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.iva = iva;
        }

        public string CodSubFamilia
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
