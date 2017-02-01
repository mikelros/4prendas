using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Producto
    {
        private string codigoArticulo;
        private string descripcion;
        private string medida;
        private int stock;
        private int stockMinimo;
        private Empleado empleado;
        private Lugar lugar;
        private Familia familia;
        private Venta venta;
        private Recogida recogida;
        private DateTime fechaEntrada;
        private int coste;


        public Producto()
        {

        }

        //Sin venta
        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, Empleado empleado, Lugar lugar,
           Familia familia, Recogida recogida, DateTime fechaEntrada, int coste)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleado = empleado;
            this.lugar = lugar;
            this.familia = familia;
            this.recogida = recogida;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste;
        }
        
        //Todos los campos
        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, Empleado empleado, Lugar lugar,
            Familia familia, SubFamilia subFamilia, Venta venta, Recogida recogida, DateTime fechaEntrada, int coste)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleado = empleado;
            this.lugar = lugar;
            this.familia = familia;
            this.venta = venta;
            this.recogida = recogida;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public string Medida
        {
            get
            {
                return medida;
            }
            set
            {
                medida = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }

        public int StockMinimo
        {
            get
            {
                return stockMinimo;
            }
            set
            {
                stockMinimo = value;
            }
        }

        public Empleado EmpleadoId
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

        public Lugar Lugar
        {
            get
            {
                return lugar;
            }
            set
            {
                lugar = value;
            }
        }

        public Familia Familia
        {
            get
            {
                return familia;
            }
            set
            {
                familia = value;
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

        public Recogida Recogida
        {
            get
            {
                return recogida;
            }
            set
            {
                recogida = value;
            }
        }

        public DateTime FechaEntrada
        {
            get
            {
                return fechaEntrada;
            }
            set
            {
                fechaEntrada = value;
            }
        }

        public int Coste
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
    }
}
