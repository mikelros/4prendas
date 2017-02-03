using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Devolucion
    {
        private int numDevolucion;
        private Venta venta;
        private Producto articulo;
        private Empleado empleado;

        public Devolucion() { }

        public Devolucion(int numDevolucion, Venta venta, Producto producto, Empleado empleado)
        {
            this.numDevolucion = numDevolucion;
            this.venta = venta;
            this.articulo = producto;
            this.empleado = empleado;
        }

        public Devolucion(Venta venta, Producto producto, Empleado empleado)
        {
            this.venta = venta;
            this.articulo = producto;
            this.empleado = empleado;
        }

        public int NumDevolucion
        {
            get
            {
                return numDevolucion;
            }
            set
            {
                numDevolucion = value;
            }
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
