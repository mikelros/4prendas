using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Recogida
    {
        private DateTime fechaRecogida;
        private Empleado empleado;
        private int cantidadProductos;
        private Persona persona;

        public Recogida() { }

        public Recogida(DateTime fechaRecogida, Empleado empleado, int cantidadProductos)
        {
            this.fechaRecogida = fechaRecogida;
            this.empleado = empleado;
            this.cantidadProductos = cantidadProductos;
        }

        public Recogida(DateTime fechaRecogida, Empleado empleado, int cantidadProductos, Persona persona)
        {
            this.fechaRecogida = fechaRecogida;
            this.empleado = empleado;
            this.cantidadProductos = cantidadProductos;
            this.persona = persona;
        }

        public DateTime FechaRecogida
        {
            get
            {
                return fechaRecogida;
            }
            set
            {
                fechaRecogida = value;
            }
        }

        public Empleado Empleado
        {
            get
            {
                return empleado;
            }
            set
            {
                empleado = value;
            }
        }

        public int CantidadProductos
        {
            get
            {
                return cantidadProductos;
            }
            set
            {
                cantidadProductos = value;
            }
        }

        public Persona Persona
        {
            get
            {
                return persona;
            }
            set
            {
                persona = value;
            }
        }
    }
}
