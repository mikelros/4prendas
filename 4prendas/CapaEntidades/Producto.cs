using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto : IEquatable<Producto>
    {
        private string codigoArticulo;
        private string descripcion;
        private string medida;
        private int stock;
        private int stockMinimo;
        private int empleadoId;
        private int lugarId;
        private string codFamilia;
        private string codSubFamilia;
        private int recogidaId;
        private DateTime fechaEntrada;
        private float coste;
        private int unidades;

        public Producto()
        {

        }

        //Todos los campos
        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, int empleadoId, int lugarId,
           string codFamilia, string codSubFamilia, int recogidaId, DateTime fechaEntrada, int coste)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleadoId = empleadoId;
            this.lugarId = lugarId;
            this.codFamilia = codFamilia;
            this.codSubFamilia = codSubFamilia;
            this.recogidaId = recogidaId;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste; }

        public Producto(string codArticulo, string descripcion, string medida, int stock, int stockMinimo, int empleadoId, int lugarId,
          string codFamilia, string codSubFamilia, int recogidaId, DateTime fechaEntrada, int coste, int unidades)
        {
            this.codigoArticulo = codArticulo;
            this.descripcion = descripcion;
            this.medida = medida;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.empleadoId = empleadoId;
            this.lugarId = lugarId;
            this.codFamilia = codFamilia;
            this.codSubFamilia = codSubFamilia;
            this.recogidaId = recogidaId;
            this.fechaEntrada = fechaEntrada;
            this.coste = coste;
            this.unidades = unidades;
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

        public string CodSubFamilia
        {
            get
            {
                return codSubFamilia;
            }
            set
            {
                codSubFamilia = value;
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

        public int Unidades
        {
            get
            {
                return unidades;
            }
            set
            {
                unidades = value;
            }
        }

        public bool Equals(Producto other)
        {
            return this.codigoArticulo.ToLower() == other.codigoArticulo.ToLower();
        }
        
        public override string ToString()
        {
            return (this.descripcion.ToString() + " - " + this.unidades.ToString() + " - " + this.coste.ToString() + "€ - " +(this.unidades * this.coste)+"€");
        }
    }
}
