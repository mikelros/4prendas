using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Venta
    {
        private DateTime fechaVenta;
        private Empleado empleado;
        private int precio;
        private int IVA;
        private bool devolucion; //Booleano o relacionado con la tabla Devolucion¿

        public Venta() { }

        public Venta(DateTime fechaVenta, Empleado empleado, int precio, bool devolucion, int IVA)
        {
            this.fechaVenta = fechaVenta;
            this.empleado = empleado;
            this.precio = precio;
            this.devolucion = devolucion;
            this.IVA = IVA;
        }


    }
}
