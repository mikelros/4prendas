using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class Negocio
    {
        private Datos datos;

        public Negocio()
        {
            datos = new Datos();
        }

        public void InsertarProductos(List<Producto> productos)
        {
            //datos.InsertarProductos(productos);
        }

    }

}
}
