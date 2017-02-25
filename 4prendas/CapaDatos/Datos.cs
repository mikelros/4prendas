﻿using System;
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
                    Familia familia = new Familia((string)dr["CodFamilia"], dr.IsDBNull(dr.GetOrdinal("NombreFamilia")) ? "" : (string)dr["NombreFamilia"], dr.IsDBNull(dr.GetOrdinal("ImagenFamilia")) ? "" : (string)dr["ImagenFamilia"], dr.IsDBNull(dr.GetOrdinal("NumeroCodigoF")) ? -1 : (int)dr["NumeroCodigoF"]);
                    do
                    { //Una familia no puede no tener subfamilia... pero y si si?
                        familia.SubFamilias.Add(new SubFamilia((string)dr["FamiliaCod"], (string)dr["CodSubFamilia"], dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : (string)dr["Nombre"], dr.IsDBNull(dr.GetOrdinal("Imagen")) ? "" : (string)dr["Imagen"], dr.IsDBNull(dr.GetOrdinal("IVA")) ? -1 : (int)dr["IVA"], dr.IsDBNull(dr.GetOrdinal("NumeroCodigoSF")) ? -1 : (int)dr["NumeroCodigoSF"]));
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

        public void updateProduct(Producto product)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(product);
            eliminarProducto(product);
            insertarProductos(productos);
        }

        public Empleado getEmpleados(int employeeNum)
        {
            Empleado empleado = new Empleado();
            string sql = "SELECT * FROM Empleado WHERE IdEmpleado = @numEmployee";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@numEmployee", employeeNum);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return empleado; //sale vacía
                }
                while (dr.Read())
                {
                    empleado = (new Empleado(dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : (string)dr["Nombre"], dr.IsDBNull(dr.GetOrdinal("Foto")) ? "" : (string)dr["Foto"]));
                }
                return empleado;
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

        public List<Producto> getProductos(string codFamilia, string codSubfamilia)
        {
            List<Producto> productos = new List<Producto>();
            string sql = "SELECT * FROM Registro WHERE Registro.CodFamilia = @codFamilia AND Registro.CodSubFamilia = @codSubFamilia";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codFamilia", codFamilia);
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
                    productos.Add(new Producto((string)dr["CodigoArticulo"], dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"], dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"], dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"],
                        dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (string)dr["CodSubFamilia"],
                        (int)dr["RecogidaId"], dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"], dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"]));
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
            string sql = "SELECT Registro.CodigoArticulo, Registro.Descripcion, Registro.TallaPesoLitros, Registro.Stock, Registro.StockMinimo, Registro.EmpleadoId, Registro.LugarId, Registro.CodFamilia, Registro.CodSubFamilia, Registro.NumeroVenta, Registro.RecogidaId, Registro.FechaEntrada, Registro.Coste FROM Registro WHERE Registro.CodFamilia = @codFamilia";
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
                    productos.Add(new Producto((string)dr["CodigoArticulo"], dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"], dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"], dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"],
                        dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (string)dr["CodSubFamilia"],
                        (int)dr["RecogidaId"], dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"], dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"]));
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
                    prodsStockMinimo.Add(new Producto((string)dr["CodigoArticulo"], dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"], dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"], dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"],
                        dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (string)dr["CodSubFamilia"],
                        (int)dr["RecogidaId"], dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"], dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"]));
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
            string sql = "SELECT * FROM Registro WHERE Registro.Descripcion = @desc";
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
                    productos.Add(new Producto((string)dr["CodigoArticulo"], dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"], dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"], dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"],
                        dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (string)dr["CodSubFamilia"],
                        (int)dr["RecogidaId"], dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"], dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"]));
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
                    productos.Add(new Producto((string)dr["CodigoArticulo"], dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"], dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"], dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"],
                        dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"], (int)dr["EmpleadoID"], (int)dr["LugarId"], (string)dr["CodFamilia"], (string)dr["CodSubFamilia"],
                        (int)dr["RecogidaId"], dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"], dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"]));
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
            string sql = "INSERT INTO Registro(CodigoArticulo, Descripcion, TallaPesoLitro, Stock, EmpleadoId, RecogidaId, Coste, FechaEntrada, CodFamilia, CodSubFamilia) VALUES (@codArt, @desc, @medida, @stock, @empleadoid, @recogidaid, @coste, @fechaentrada, @codfam, @codsubfam)";

            //faltan los datos de lugar porque no está hecho el form y eso
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();

                foreach (Producto p in productos)
                {
                    cmd.Parameters.AddWithValue("@codArt", p.CodigoArticulo);
                    cmd.Parameters.AddWithValue("@desc", p.Descripcion);
                    cmd.Parameters.AddWithValue("@medida", p.Medida);
                    cmd.Parameters.AddWithValue("@stock", p.Stock);
                    cmd.Parameters.AddWithValue("@empleadoid", p.EmpleadoId);
                    cmd.Parameters.AddWithValue("@recogidaid", p.RecogidaId);
                    cmd.Parameters.AddWithValue("@coste", p.Coste);
                    cmd.Parameters.AddWithValue("@fechaentrada", p.FechaEntrada);
                    cmd.Parameters.AddWithValue("@codfam", p.CodFamilia);
                    cmd.Parameters.AddWithValue("@codsubfam", p.CodSubFamilia);

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

        public void eliminarProducto(Producto producto)
        {
            string sql = "Delete * FROM Registro where registro.CodigoArticulo = @codArt";

            //faltan los datos de lugar porque no está hecho el form y eso
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();

                cmd.Parameters.AddWithValue("@codArt", producto.CodigoArticulo);

                cmd.ExecuteNonQuery();

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

        public string createEmployee(string name, string photo) //Id autonumerico...
        {
            string sql = "INSERT INTO Empleado(Nombre, Foto) VALUES (@name, @photo)";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@photo", photo);
            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();
                return "";

            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return "Database error: " + ex.Message;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void deleteEmployee(int id)
        {
            string sql = "DELETE FROM Empleado WHERE IdEmpledo = @id";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();

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
                    empleados.Add(new Empleado((int)dr["IdEmpleado"], dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : (string)dr["Nombre"], dr.IsDBNull(dr.GetOrdinal("Foto")) ? "" : (string)dr["Foto"]));
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

        public void realizarRecogida(Recogida recogida)
        {
            string sql = "INSERT INTO Recogida(FechaRecogida, EmpleadoId, CantidadProductos, PersonaId) VALUES (@FechaRecogida, @EmpleadoId, @CantProd, @PersonaId)";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();

                cmd.Parameters.AddWithValue("@FechaRecogida", recogida.FechaRecogida);
                cmd.Parameters.AddWithValue("@EmpleadoId", recogida.EmpleadoId);
                cmd.Parameters.AddWithValue("@CantProd", recogida.CantidadProductos);
                cmd.Parameters.AddWithValue("@PersonaId", recogida.PersonaId);

                cmd.ExecuteNonQuery();
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

        public int comprobarPersona(string nombre)
        {
            nombre = nombre.ToLower();
            string sql = "SELECT IdPersona FROM Persona WHERE LCase(Persona.Nombre) = @nombre";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();

                cmd.Parameters.AddWithValue("@nombre", nombre);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    sql = "INSERT INTO Persona(Nombre) VALUES(@nombre)";
                    cmd = new OleDbCommand(sql, conTabla);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.ExecuteNonQuery();

                    sql = "SELECT IdPersona FROM Persona WHERE LCase(Nombre) = @nombre";
                    cmd = new OleDbCommand(sql, conTabla);
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    return (int)cmd.ExecuteScalar();

                }

                dr.Read();
                return (int)dr["IdPersona"];


            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
            }
            finally
            {
                conTabla.Close();
            }

            return -1;
        }

        public int getLastNRecogida()
        {
            string sql = "SELECT MAX(IdRecogida) FROM Recogida";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return 0;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Recogida> getRecogidasSinTodosRegistros()
        {
            List<Recogida> recogidas = new List<Recogida>();
            string sql = "SELECT Recogida.IdRecogida, Recogida.FechaRecogida, Recogida.CantidadProductos, Recogida.EmpleadoId, Recogida.PersonaId FROM Recogida LEFT JOIN Registro ON Recogida.IdRecogida = Registro.RecogidaId GROUP BY Recogida.CantidadProductos, Recogida.IdRecogida, Recogida.FechaRecogida, Recogida.EmpleadoId, Recogida.PersonaId , Registro.RecogidaId HAVING Registro.RecogidaId Is Null OR Recogida.CantidadProductos > (SELECT Count(Registro.CodigoArticulo) FROM Recogida INNER JOIN Registro ON Recogida.IdRecogida = Registro.RecogidaId) ORDER BY Recogida.IdRecogida;";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return recogidas;
                }
                while (dr.Read())
                {
                    recogidas.Add(new Recogida((int)dr["IdRecogida"], dr.IsDBNull(dr.GetOrdinal("FechaRecogida")) ? default(DateTime) : (DateTime)dr["FechaRecogida"], dr.IsDBNull(dr.GetOrdinal("EmpleadoId")) ? -1 : (int)dr["EmpleadoId"], dr.IsDBNull(dr.GetOrdinal("CantidadProductos")) ? 0 : (int)dr["CantidadProductos"], dr.IsDBNull(dr.GetOrdinal("PersonaId")) ? -1 : (int)dr["PersonaId"]));
                }
                return recogidas;
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

        public int getSiguienteIDProd(string codFamilia, string codSubfamilia)
        {
            string producto;
            int num = 0;
            string sql = "SELECT TOP 1 CodigoArticulo FROM Registro WHERE Registro.CodFamilia = @codFamilia AND Registro.CodSubFamilia = @codSubFamilia ORDER BY CodigoArticulo DESC";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codFamilia", codFamilia);
            cmd.Parameters.AddWithValue("@codSubFamilia", codSubfamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return 0; //No hay ids
                }
                dr.Read();
                producto = (string)dr["CodigoArticulo"];
                int.TryParse(producto.Substring(producto.Length - 3, 3), out num);

                return num + 1;
            }
            catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return 0;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void insertVenta(List<Producto> productos, int empleadoID)
        {
            int numVenta;


            string sql = "INSERT INTO Venta(FechaVenta, EmpleadoId, Devolucion) VALUES (@FechaVenta, @EmpleadoId, @Devolucion)";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Now);
            cmd.Parameters.AddWithValue("@EmpleadoId", empleadoID);
            cmd.Parameters.AddWithValue("@Devolucion", false);
            //cmd.Parameters.AddWithValue("@IVA", );
            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();

                sql = "SELECT TOP 1 NumVenta FROM Venta ORDER BY NumVenta DESC";
                cmd = new OleDbCommand(sql, conTabla);
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                numVenta = (int)dr["NumVenta"];

                sql = "INSERT INTO VentaArticulo(CodigoArticulo, NumVenta, Coste) VALUES (@codArt, @numVenta, @coste)";

                //faltan los datos de lugar porque no está hecho el form y eso
                 cmd = new OleDbCommand(sql, conTabla);

                    foreach (Producto p in productos)
                    {
                        cmd.Parameters.AddWithValue("@codArt", p.CodigoArticulo);
                        cmd.Parameters.AddWithValue("@numVenta", numVenta);
                        cmd.Parameters.AddWithValue("@coste", p.Coste);

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
