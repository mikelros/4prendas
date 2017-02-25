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
        public void InsertarProducto(Producto producto)
        {
            datos.insertarProducto(producto);
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

        public void actualizarProducto(Producto product)
        {
            datos.updateProduct(product);
        }

        public void realizarRecogida(Recogida recogida)
        {
            datos.realizarRecogida(recogida);
        }

        public int comprobarPersona(string nombre)
        {
            return datos.comprobarPersona(nombre);
        }

        public int getLastNRecogida()
        {
            return datos.getLastNRecogida();
        }

        public List<Recogida> getRecogidasSinTodosRegistros()
        {
            return datos.getRecogidasSinTodosRegistros();
        }
    }

}

