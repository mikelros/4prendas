using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Devolucion
    {
        private Venta venta;
        private Producto producto;
        private Empleado empleado;

        public Devolucion() { }

        public Devolucion(Venta venta, Producto producto, Empleado empleado)
        {
            this.venta = venta;
            this.producto = producto;
            this.empleado = empleado;
        }

        public Venta Venta
        {
            get
            {
                return venta;
            }
            set
            {
                venta = value;
            }
        }

        public Producto Producto
        {
            get
            {
                return producto;
            }
            set
            {
                producto = value;
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
    }
}
