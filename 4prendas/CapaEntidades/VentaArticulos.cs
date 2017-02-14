using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class VentaArticulos
    {
        private List<int> codigosArticulo;
        private int numVenta;
        private float coste;

        public VentaArticulos()
        {

        }
        public VentaArticulos(int numVenta, List<int> codigosArticulo, float coste)
        {
            this.codigosArticulo = codigosArticulo;
            this.coste = coste;
            this.numVenta = numVenta;
        }

        public int NumVenta
        {
            get
            {
                return numVenta;
            }
            set
            {
                numVenta = value;
            }
        }

        public float Coste
        {
            get
            {
                return coste;
            }
            set
            {
                coste = value;
            }
        }

        public List<int> CodigosArticulo
        {
            get
            {
                return codigosArticulo;
            }
            set
            {
                codigosArticulo = value;
            }
        }
    }
}
