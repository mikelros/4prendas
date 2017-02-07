using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using CapaEntidades;

namespace CapaDatos
{
    public class Datos
    {
        private static string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=4prendas.accdb";

        public List<Familia> getFamilias() //Qué narices saca esto? todas las familias y subfamilias? para sacar sólo las fams
                                           //no bastaria un "select * from familias"?
        {
            List<Familia> familias = new List<Familia>(); // no sé si es arraylist o qué
            string sql = "SELECT * FROM Familia f INNER JOIN SubFamilia sf ON sf.FamiliaCod = f.CodFamilia";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    return familias; //sale vacía
                }
                bool fin = false;
                do
                {
                    Familia familia = new Familia((string)dr["CodFamilia"], (string)dr["NombreFamilia"], (string)dr["ImagenFamilia"], (int)dr["NumeroCodigoF"]);
                    do
                    { //Una familia no puede no tener subfamilia... pero y si si?
                        familia.SubFamilias.Add(new SubFamilia((string)dr["FamiliaCod"], (string)dr["CodSubFamilia"], (string)dr["Nombre"], (string)dr["Imagen"], (int)dr["IVA"], (int)dr["NumeroCodigoSF"]));
                        if (!dr.Read())
                        {
                            fin = true;
                        }
                    } while (!fin && ((string)dr["CodFamilia"]).Equals(familia.CodFamilia));

                    familias.Add(familia);
                } while (!fin);
                return familias;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }


        public List<Producto> getProductos(string codSubfamilia) //getProductos o getProdsPorSubFamilia
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM Productos WHERE Registro.CodSubFamilia = @codSubFamilia";//WTF ¿Registro??????
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codSubFamilia", codSubfamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return productos; //sale vacía
                }
                while (dr.Read())
                {
                    productos.Add(new Producto((string)dr["CodigoArticulo"], (string)dr["Descripcion"], (string)dr["TallaPesoLitros"], (int)dr["Stock"],
                        (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (int)dr["NumeroVenta"],
                        (int)dr["RecogidaId"], (DateTime)dr["FechaEntrada"], (int)dr["Coste"]));
                }
                return productos;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public Administrador getAdministrador(string user, string pass)
        {
            List<Administrador> administradores = new List<Administrador>();
            string sql = "SELECT * FROM Administrador where Usuario=@User AND Contrasena=@Pass"; ;//;;? no lo borro por si las moscas, pero ta mal, no?
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@User", user);
            cmd.Parameters.AddWithValue("@Pass", pass);
            try
            {
                conTabla.Open();
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    return new Administrador(user, pass);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Empleado> getEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            string sql = "SELECT * FROM Empleado";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return empleados; //sale vacía
                }
                while (dr.Read())
                {
                    empleados.Add(new Empleado((string)dr["Nombre"], (string)dr["Foto"]));
                }
                return empleados;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }

        //Productos en stock minimo
        public List<Producto> getProdsStockMinimo()
        {
            List<Producto> prodsStockMinimo = new List<Producto>(); // no sé si es arraylist o qué
            string sql = "SELECT * FROM Registro WHERE Stock <= StockMinimo";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return prodsStockMinimo; //sale vacía
                }
                while (dr.Read())
                {
                    Empleado emp = new Empleado();
                    //prodsStockMinimo.Add(new Producto(dr["CodigoArticulo"], dr["Descripcion"], dr["TallaPesoLitros"], dr["Stock"], dr["StockMinimo"], dr["EmpleadoId"],  dr["LugarId"], dr["CodFamilia"], dr["NumeroVenta"], dr["RecogidaId"], dr["FechaEntrada"], dr["Coste"]);
                }
                return prodsStockMinimo;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }

        //Productos por descripcion
        public List<Producto> getProdsPorDescripcion(string desc)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM Productos WHERE Registro.Descripcion = @desc"; //WTF ¿Registro??????
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@desc", desc);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return productos; //sale vacía
                }
                while (dr.Read())
                {
                    productos.Add(new Producto((string)dr["CodigoArticulo"], (string)dr["Descripcion"], (string)dr["TallaPesoLitros"], (int)dr["Stock"],
                        (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (int)dr["NumeroVenta"],
                        (int)dr["RecogidaId"], (DateTime)dr["FechaEntrada"], (int)dr["Coste"]));
                }

                return productos;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }
        //Porductos por codigoArticulo
        public List<Producto> getProdsPorCodigoArticulo(string codigoArticulo)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM Productos WHERE Registro.CodigoArticulo = @codigoArticulo"; //WTF ¿Registro??????
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codigoArticulo", codigoArticulo);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return productos; //sale vacía
                }
                while (dr.Read())
                {
                    productos.Add(new Producto((string)dr["CodigoArticulo"], (string)dr["Descripcion"], (string)dr["TallaPesoLitros"], (int)dr["Stock"],
                        (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (int)dr["NumeroVenta"],
                        (int)dr["RecogidaId"], (DateTime)dr["FechaEntrada"], (int)dr["Coste"]));
                }
                return productos;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            }
            finally
            {
                conTabla.Close();
            }
        }

        //Portductos por familia


    }
}
