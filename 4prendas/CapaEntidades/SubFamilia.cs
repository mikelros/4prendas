using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class SubFamilia
    {
        private string codFamilia;
        private string codSubFamilia;
        private string nombre;
        private string imagen;
        private int iva;
        private int numeroCodigo;
        
        public SubFamilia()
        {

        }

        public SubFamilia(string codFamilia, string codSubFamilia, string nombre, string imagen, int iva, int numeroCodigo)
        {
            this.codFamilia = codFamilia;
            this.codSubFamilia = codSubFamilia;
            this.nombre = nombre;
            this.imagen = imagen;
            this.iva = iva;
            this.numeroCodigo = numeroCodigo;
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

        public int NumeroCodigo
        {
            get
            {
                return numeroCodigo;
            }
            set
            {
                numeroCodigo = value;
            }
        }
    }
}
