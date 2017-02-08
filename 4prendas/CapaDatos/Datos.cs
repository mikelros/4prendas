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

        public List<Familia> getFamiliasSubfamilias()
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
                    Familia familia = new Familia(dr.IsDBNull(dr.GetOrdinal("CodFamilia")) ? "" : (string)dr["CodFamilia"], dr.IsDBNull(dr.GetOrdinal("NombreFamilia")) ? "" : (string)dr["NombreFamilia"], dr.IsDBNull(dr.GetOrdinal("ImagenFamilia")) ? "" : (string)dr["ImagenFamilia"], dr.IsDBNull(dr.GetOrdinal("NumeroCodigoF")) ? -1 : (int)dr["NumeroCodigoF"]);
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


        public List<Producto> getProductos(string codSubfamilia)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM Registro WHERE Registro.CodSubFamilia = @codSubFamilia";//WTF ¿Registro??????
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

        public List<Producto> getProductosFamilia(string codFamilia)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT Registro.CodigoArticulo, Registro.Descripcion, Registro.TallaPesoLitros, Registro.Stock, Registro.StockMinima, Registro.EmpleadoId, Registro.LugarId, Registro.CodFamilia, Registro.CodSubFamilia, Registro.NumeroVenta, Registro.RecogidaId, Registro.FechaEntrada, Registro.Coste FROM (Familia INNER JOIN SubFamilia ON Familia.CodFamilia = SubFamilia.FamiliaCod) INNER JOIN Registro ON SubFamilia.FamiliaCod = Registro.CodFamilia AND SubFamilia.CodSubFamilia = Registro.CodSubFamilia WHERE Familia.CodFamilia = @codFamilia";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codFamilia", codFamilia);
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
            string sql = "SELECT * FROM Administrador where Usuario=@User AND Contrasena=@Pass";
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
                    prodsStockMinimo.Add(new Producto((string)dr["CodigoArticulo"], (string)dr["Descripcion"], (string)dr["TallaPesoLitros"], (int)dr["Stock"],
                        (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (int)dr["NumeroVenta"],
                        (int)dr["RecogidaId"], (DateTime)dr["FechaEntrada"], (int)dr["Coste"]));
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
            string sql = "SELECT * FROM Registro WHERE Registro.Descripcion = @desc"; //WTF ¿Registro??????
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
            string sql = "SELECT * FROM Registro WHERE Registro.CodigoArticulo = @codigoArticulo"; //WTF ¿Registro??????
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
        //Productos por subfamilia ¿O es lo de arriba de getProductos?


        public void insertarProductos(List<Producto> productos)
        {
            string sql = "INSERT INTO Registro(CodigoArticulo, Descripcion, TallaPesoLitro, Stock, EmpleadoId, RecogidaId) VALUES (@codArt, @desc, @medida, @stock, @empleadoid, @recogidaid)";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
               conTabla.Open();

               foreach(Producto p in productos)
               {
                    cmd.Parameters.AddWithValue("@codArt", p.CodigoArticulo);
                    cmd.Parameters.AddWithValue("@desc", p.Descripcion);
                    cmd.Parameters.AddWithValue("@medida", p.Medida);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@empleadoid", p.EmpleadoId);
                    cmd.Parameters.AddWithValue("@recogidaid", p.RecogidaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
            }
            finally
            {
                conTabla.Close();
            }
        }

    }
}
