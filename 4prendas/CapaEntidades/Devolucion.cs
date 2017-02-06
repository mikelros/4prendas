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
        private int ventaId;
        private string codigoArticulo;
        private int empleadoId;

        public Devolucion() { }

        public Devolucion(int numDevolucion, int ventaId, string codigoArticulo, int empleadoId)
        {
            this.numDevolucion = numDevolucion;
            this.ventaId = ventaId;
            this.codigoArticulo = codigoArticulo;
            this.empleadoId = empleadoId;
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

        public int VentaId
        {
            get
            {
                return ventaId;
            }
            set
            {
                ventaId = value;
            }
        }

        public string CodigoArticulo
        {
            get
            {
                return codigoArticulo;
            }
            set
            {
                codigoArticulo = value;
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
