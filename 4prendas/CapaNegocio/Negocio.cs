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
            datos.insertarProductos(productos);
        }

        public List<Familia> getFamiliasSubfamilias()
        {
            return datos.getFamiliasSubfamilias();
        }

        public List<Producto> getProductos(string codFamilia, string codSubFamilia)
        {
            return datos.getProductos(codFamilia, codSubFamilia);
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

        public string createEmployee(string name, string photo) //Id autonumerico...
        {
            return datos.createEmployee(name, photo);
        }

        public void deleteEmployee(int id)
        {
            datos.deleteEmployee(id);
        }

        public Empleado getEmployee(int employeeNum)
        {
            return datos.getEmpleados(employeeNum);
        }

        public void updateProduct(Producto product)
        {
            datos.updateProduct(product);
        }
    }

}

