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
        private int iva;
        private bool devolucion;

        public Venta() { }

        public Venta(DateTime fechaVenta, int empleadoId, bool devolucion, int IVA)
        {
            this.fechaVenta = fechaVenta;
            this.empleadoId = empleadoId;
            this.devolucion = devolucion;
            this.iva = IVA;
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
    }
}
