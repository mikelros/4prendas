using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private string codigoArticulo;
        private string descripcion;
        private string medida;
        private int stock;
        private int stockMinimo;
        private int empleadoId;
        private int lugarId;
        private string codFamilia;
        private int numeroVenta;
        private int recogidaId;
        private DateTime fechaEntrada;
        private int coste;


        public Producto()
        {

        }

        //Sin venta
        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, int empleadoId, int lugarId,
           string codFamilia, int recogidaId, DateTime fechaEntrada, int coste)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleadoId = empleadoId;
            this.lugarId = lugarId;
            this.codFamilia = codFamilia;
            this.recogidaId = recogidaId;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste;
        }
        
        //Todos los campos
        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, int empleadoId, int lugarId,
           string codFamilia, int recogidaId, int numeroVenta, DateTime fechaEntrada, int coste)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleadoId = empleadoId;
            this.lugarId = lugarId;
            this.codFamilia = codFamilia;
            this.recogidaId = recogidaId;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste;
            this.numeroVenta = numeroVenta;
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

        public int LugarId
        {
            get
            {
                return lugarId;
            }
            set
            {
                lugarId = value;
            }
        }

        public string CodFamilia
        {
            get
            {
                return codFamilia;
            }
            set
            {
                codFamilia = value;
            }
        }

        public int NumeroVenta
        {
            get
            {
                return numeroVenta;
            }
            set
            {
                numeroVenta = value;
            }
        }

        public int RecogidaId
        {
            get
            {
                return recogidaId;
            }
            set
            {
                recogidaId = value;
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
