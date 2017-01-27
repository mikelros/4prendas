using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Empleado
    {
        private string nombre;
        private string foto;

        public Empleado() { }

        public Empleado(string nombre, string foto)
        {
            this.nombre = nombre;
            this.foto = foto;
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

        public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }
    }
}
