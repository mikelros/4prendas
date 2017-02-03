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
        private int iva;
        private bool devolucion; //Booleano o relacionado con la tabla Devolucion¿
        private List<Producto> productos;

        public Venta() { }

        public Venta(DateTime fechaVenta, Empleado empleado, int precio, bool devolucion, int IVA, List<Producto> productos)
        {
            this.fechaVenta = fechaVenta;
            this.empleado = empleado;
            this.precio = precio;
            this.devolucion = devolucion;
            this.iva = IVA;
            this.productos = productos;
        }

        public DateTime FechaVenta
        {
            get
            {
                return fechaVenta;
            }
            set
            {
                fechaVenta = value;
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

        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        public int IVA
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

        public bool Devolucion
        {
            get
            {
                return devolucion;
            }
            set
            {
                devolucion = value;
            }
        }

        public List<Producto> Productos
        {
            get
            {
                return productos;
            }
            set
            {
                productos = value;
            }
        }

    }
}
