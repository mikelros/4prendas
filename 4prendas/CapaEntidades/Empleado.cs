using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        private string nombre;
        private string foto;
        private List<int> ventas;
        private List<int> devoluciones;

        public Empleado() { }

        public Empleado(string nombre, string foto)
        {
            this.nombre = nombre;
            this.foto = foto;
        }

        public Empleado(string nombre, string foto, List<int> ventas, List<int> devoluciones)
        {
            this.nombre = nombre;
            this.foto = foto;
            this.ventas = ventas;
            this.devoluciones = devoluciones;
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

        public List<int> Ventas
        {
            get
            {
                return ventas;
            }
            set
            {
                ventas = value;
            }
        }

        public List<int> Devoluciones
        {
            get
            {
                return devoluciones;
            }
            set
            {
                devoluciones = value;
            }
        }
    }
}
