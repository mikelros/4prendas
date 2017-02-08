using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        private int empleadoId;
        private string nombre;
        private string foto;

        public Empleado() { }

        public Empleado(string nombre, string foto)
        {
            this.nombre = nombre;
            this.foto = foto;
        }

        public Empleado(int empleadoId, string nombre, string foto)
        {
            this.empleadoId = empleadoId;
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

        public int EmpleadoId
        {
            get
            {
                return empleadoId;
            }
            set
            {
                empleadoId = value;
            }
        }
    }
}
