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
            //return datos.InsertarProductos(productos);
        }

        public List<Familia> getFamiliasSubfamilias()
        {
            return datos.getFamiliasSubfamilias();
        }

        public List<Producto> getProductos(string codSubfamilia)
        {
            return datos.getProductos(codSubfamilia);
        }

        public Administrador getAdministrador(string user, string pass)
        {
            return datos.getAdministrador(user, pass);
        }

        public List<Empleado> getEmpleados()
        {
            return datos.getEmpleados();
        }

        public List<Producto> getProdsStockMinimo()
        {
            return datos.getProdsStockMinimo();
        }

        public List<Producto> getProdsPorDescripcion(string desc)
        {
            return datos.getProdsPorDescripcion(desc);
        }

        public List<Producto> getProdsPorCodigoArticulo(string codigoArticulo)
        {
            return datos.getProdsPorCodigoArticulo(codigoArticulo);
        }

        public void insertarProductos(List<Producto> productos)
        {
            datos.insertarProductos(productos);
        }

    }

}

