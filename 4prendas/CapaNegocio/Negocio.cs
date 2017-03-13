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

        public Administrador getAdministrador(string usuario, string contrasena)
        {
            return datos.getAdministrador(usuario, contrasena);
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

        public string crearEmpleado(string nombre, string foto) //Id autonumerico...
        {
            return datos.crearEmpleado(nombre, foto);
        }

        public void eliminarEmpleado(int id)
        {
            datos.borrarEmpleado(id);
        }

        public bool eliminarFamilia(string cod)
        {
            return datos.eliminarFamilia(cod);
        }

        public bool eliminarSubFamilia(string cod, string subCod)
        {
            return datos.eliminarSubFamilia(cod, subCod);
        }

        public Empleado getEmpleado(int employeeNum)
        {
            return datos.getEmpleado(employeeNum);
        }

        public void actualizarProducto(Producto producto)
        {
            datos.actualizarProducto(producto);
        }

        public void realizarRecogida(Recogida recogida)
        {
            datos.realizarRecogida(recogida);
        }

        public int comprobarPersona(string nombre)
        {
            return datos.comprobarPersona(nombre);
        }

        public int getUltimoNumRecogida()
        {
            return datos.getUltimoNumRecogida();
        }

        public List<Recogida> getRecogidasSinTodosRegistros()
        {
            return datos.getRecogidasSinTodosRegistros();
        }

        public string getSiguienteID(string codFamilia, string codSubfamilia)
        {
            return datos.getSiguienteIDProd(codFamilia, codSubfamilia);
        }
        public void insertVenta(List<Producto> productos, int empleadoID)
        {
            datos.insertarVenta(productos, empleadoID);
        }

        public Lugar getLugar(Lugar lugar)
        {
            return datos.getLugar(lugar);
        }

        public bool estaRecogidaCompleta(int id)
        {
            return datos.estaRecogidaCompleta(id);
        }

        public List<Producto> getTodosProductos()
        {
            return datos.getTodosProductos();
        }

        public List<Producto> getProdsCodigoBarras(long codigoBarras)
        {
            return datos.getProdsCodigoBarras(codigoBarras);
        }

        public string getCodigoBarras(string codigoArticulo)
        {
            return datos.getCodigoBarras(codigoArticulo);
        }

        public List<Producto> getProductosFamilia(string codFamilia)
        {
            return datos.getProductosFamilia(codFamilia);
        }

        public void InsertarSubFamilia(SubFamilia subFam)
        {
            datos.insertarSubFamilia(subFam);
        }

        public void InsertarFamilia(Familia fam)
        {
            datos.insertarFamilia(fam);
        }
    }
}

