using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        private DateTime fechaVenta;
        private int empleadoId;
        private int precio;
        private int iva;
        private bool devolucion;
        private List<int> codArticulos;

        public Venta() { }

        public Venta(DateTime fechaVenta, int empleadoId, int precio, bool devolucion, int IVA, List<int> codArticulos)
        {
            this.fechaVenta = fechaVenta;
            this.empleadoId = empleadoId;
            this.precio = precio;
            this.devolucion = devolucion;
            this.iva = IVA;
            this.codArticulos = codArticulos;
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

        public List<int> CodArticulos
        {
            get
            {
                return codArticulos;
            }
            set
            {
                codArticulos = value;
            }
        }

    }
}
