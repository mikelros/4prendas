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
            List<Familia> familias = new List<Familia>();
            string sql = @"SELECT *
                            FROM   Familia f
                            INNER JOIN SubFamilia sf
                             ON sf.FamiliaCod = f.CodFamilia;";
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
                    {
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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void actualizarProducto(Producto producto)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(producto);
            eliminarProducto(producto);
            insertarProductos(productos);
        }

        public Empleado getEmpleado(int numEmpleado)
        {
            Empleado empleado = new Empleado();
            string sql = @"SELECT *
                            FROM   Empleado
                            WHERE  IdEmpleado = @numEmpleado;";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@numEmpleado", numEmpleado);
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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void insertarFamilia(Familia fam)
        {
            string sql = @"INSERT INTO Familia
                                        (CodFamilia,
                                         NombreFamilia,
                                         ImagenFamilia,
                                         NumeroCodigoF)
                            VALUES      (@codFam,
                                         @nombre,
                                         @imagen,
                                         @numCod);";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();


                cmd.Parameters.AddWithValue("@codFam", fam.CodFamilia);
                cmd.Parameters.AddWithValue("@nombre", fam.Nombre);
                cmd.Parameters.AddWithValue("@imagen", fam.Imagen);
                cmd.Parameters.AddWithValue("@numCod", fam.NumCodigo);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void insertarSubFamilia(SubFamilia subFam)
        {
            string sql = @"INSERT INTO SubFamilia
                                        (FamiliaCod,
                                         CodSubFamilia,
                                         Nombre,
                                         Imagen,
                                         IVA,
                                         NumeroCodigoSF)
                            VALUES      (@codFam,
                                         @codSubFam,
                                         @nombre,
                                         @imagen,
                                         @iva,
                                         @numCodSF);";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();


                cmd.Parameters.AddWithValue("@codFam", subFam.CodFamilia);
                cmd.Parameters.AddWithValue("@codSubFam", subFam.CodSubFamilia);
                cmd.Parameters.AddWithValue("@nombre", subFam.Nombre);
                cmd.Parameters.AddWithValue("@imagen", subFam.Imagen);
                cmd.Parameters.AddWithValue("@iva", subFam.Iva);
                cmd.Parameters.AddWithValue("@numCodSF", subFam.NumeroCodigo);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Producto> getProductos(string codFamilia, string codSubfamilia)
        {
            List<Producto> productos = new List<Producto>();
            string sql = @"SELECT *
                            FROM Registro
                            WHERE Registro.CodFamilia = @codFamilia
                                   AND Registro.CodSubFamilia = @codSubFamilia; ";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Producto> getTodosProductos()
        {
            List<Producto> productos = new List<Producto>();
            string sql = @"SELECT *
                            FROM Registro";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Producto> getProductosFamilia(string codFamilia)
        {
            List<Producto> productos = new List<Producto>();
            string sql = @"SELECT *
                            FROM   Registro
                            WHERE  Registro.CodFamilia = @codFamilia;";
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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public Administrador getAdministrador(string usuario, string contrasena)
        {
            string sql = @"SELECT COUNT(*)
                            FROM Administrador
                            WHERE Usuario = @User
                                   AND Contrasena = @Pass; ";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@User", usuario);
            cmd.Parameters.AddWithValue("@Pass", contrasena);
            try
            {
                conTabla.Open();
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    return new Administrador(usuario, contrasena);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            string sql = @"SELECT *
                            FROM   Registro
                            WHERE  Stock <= StockMinimo;";
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
                throw ex;
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
            string sql = @"SELECT *
                            FROM   Registro
                            WHERE  Registro.Descripcion LIKE @desc;";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@desc", "%" + desc + "%");

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Producto> getProdsCodigoBarras(long codigoBarras)
        {
            string resultado, resultado2;
            String codigoArticulo = codigoBarras.ToString();

            if (codigoArticulo.Length == 8)
            {
                resultado = getFamiliaCod(codigoBarras.ToString().Substring(7, 1));
                if (resultado != "")
                {
                    codigoArticulo = codigoBarras.ToString().Substring(0, 7) + resultado;
                }
                else
                {
                    codigoArticulo = "-1";
                }
            }
            else if (codigoArticulo.Length == 9)
            {
                resultado = getFamiliaCod(codigoBarras.ToString().Substring(7, 1));
                resultado2 = getSubFamiliaCod(codigoBarras.ToString().Substring(7, 1), codigoBarras.ToString().Substring(8, 1));
                if (resultado != "" && resultado2 != "")
                {
                    codigoArticulo = codigoBarras.ToString().Substring(0, 7) +
                    resultado + resultado2;
                }
                else
                {
                    codigoArticulo = "-1";
                }

            }
            else if (codigoArticulo.Length == 10)
            {
                resultado = getFamiliaCod(codigoBarras.ToString().Substring(7, 1));
                resultado2 = getSubFamiliaCod(codigoBarras.ToString().Substring(7, 1), codigoBarras.ToString().Substring(8, 1));
                if (resultado != "" && resultado2 != "")
                {
                    codigoArticulo = codigoBarras.ToString().Substring(0, 7) +
                    resultado + resultado2 + codigoBarras.ToString().Substring(9, 1);
                }
                else
                {
                    codigoArticulo = "-1";
                }
            }
            else if (codigoArticulo.Length == 11)
            {
                resultado = getFamiliaCod(codigoBarras.ToString().Substring(7, 1));
                resultado2 = getSubFamiliaCod(codigoBarras.ToString().Substring(7, 1), codigoBarras.ToString().Substring(8, 1));
                if (resultado != "" && resultado2 != "")
                {
                    codigoArticulo = codigoBarras.ToString().Substring(0, 7) +
                    resultado + resultado2 + codigoBarras.ToString().Substring(9, 2);
                }
                else
                {
                    codigoArticulo = "-1";
                }
            }
            else if (codigoArticulo.Length == 12)
            {
                resultado = getFamiliaCod(codigoBarras.ToString().Substring(7, 1));
                resultado2 = getSubFamiliaCod(codigoBarras.ToString().Substring(7, 1), codigoBarras.ToString().Substring(8, 1));
                if (resultado != "" && resultado2 != "")
                {
                    codigoArticulo = codigoBarras.ToString().Substring(0, 7) +
                    resultado + resultado2 + codigoBarras.ToString().Substring(9, 3);
                }
                else
                {
                    codigoArticulo = "-1";
                }
            }

            List<Producto> productos = new List<Producto>();
            Producto prod = null;
            string sql = @"SELECT *
                            FROM Registro WHERE CodigoArticulo LIKE @cod";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", codigoArticulo + "%");
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
                    prod = new Producto();
                    prod.CodigoArticulo = (string)dr["CodigoArticulo"];
                    prod.Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? "" : (string)dr["Descripcion"];
                    prod.Medida = dr.IsDBNull(dr.GetOrdinal("TallaPesoLitros")) ? "" : (string)dr["TallaPesoLitros"];
                    prod.Stock = dr.IsDBNull(dr.GetOrdinal("Stock")) ? -1 : (int)dr["Stock"];
                    prod.StockMinimo = dr.IsDBNull(dr.GetOrdinal("StockMinimo")) ? -1 : (int)dr["StockMinimo"];
                    prod.EmpleadoId = (int)dr["EmpleadoID"];
                    prod.LugarId = (int)dr["LugarId"];
                    prod.CodFamilia = (string)dr["CodFamilia"];
                    prod.CodSubFamilia = (string)dr["CodSubFamilia"];
                    prod.RecogidaId = (int)dr["RecogidaId"];
                    prod.FechaEntrada = dr.IsDBNull(dr.GetOrdinal("FechaEntrada")) ? default(DateTime) : (DateTime)dr["FechaEntrada"];
                    prod.Coste = dr.IsDBNull(dr.GetOrdinal("Coste")) ? -1 : (int)dr["Coste"];
                    productos.Add(prod);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public string getCodigoBarras(string codigoArticulo)
        {
            String codigoB = codigoArticulo.ToString().Substring(0, 7) +
                getFamiliaNumCod(codigoArticulo.ToString().Substring(7, 2)) +
                getSubFamiliaNumCod(codigoArticulo.ToString().Substring(7, 2), codigoArticulo.ToString().Substring(9, 2)) +
                codigoArticulo.ToString().Substring(11, 3);

            return codigoB;
        }

        private int getFamiliaNumCod(string codFamilia)
        {
            Familia fam = null;
            string sql = @"SELECT *
                           FROM Familia WHERE CodFamilia = @cod";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", codFamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return 0; //sale vacía
                }
                while (dr.Read())
                {
                    fam = new Familia((string)dr["CodFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("NombreFamilia")) ? "" : (string)dr["NombreFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("ImagenFamilia")) ? "" : (string)dr["ImagenFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("NumeroCodigoF")) ? -1 : (int)dr["NumeroCodigoF"]);
                }
                return fam.NumCodigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        private int getSubFamiliaNumCod(string codFamilia, string codSubFamilia)
        {
            SubFamilia subfam = null;
            string sql = @"SELECT * FROM SubFamilia WHERE FamiliaCod = @cod AND CodSubFamilia = @sub";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", codFamilia);
            cmd.Parameters.AddWithValue("@sub", codSubFamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return 0; //sale vacía
                }
                while (dr.Read())
                {
                    subfam = new SubFamilia((string)dr["FamiliaCod"],
                        (string)dr["CodSubFamilia"], dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : (string)dr["Nombre"],
                        dr.IsDBNull(dr.GetOrdinal("Imagen")) ? "" : (string)dr["Imagen"],
                        dr.IsDBNull(dr.GetOrdinal("IVA")) ? -1 : (int)dr["IVA"],
                        dr.IsDBNull(dr.GetOrdinal("NumeroCodigoSF")) ? -1 : (int)dr["NumeroCodigoSF"]);
                }
                return subfam.NumeroCodigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }


        private string getFamiliaCod(string numFamilia)
        {
            Familia fam = null;
            string sql = @"SELECT *
                            FROM Familia WHERE NumeroCodigoF = @cod";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", numFamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return ""; //sale vacía
                }
                while (dr.Read())
                {
                    fam = new Familia((string)dr["CodFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("NombreFamilia")) ? "" : (string)dr["NombreFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("ImagenFamilia")) ? "" : (string)dr["ImagenFamilia"],
                        dr.IsDBNull(dr.GetOrdinal("NumeroCodigoF")) ? -1 : (int)dr["NumeroCodigoF"]);
                }
                return fam.CodFamilia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        private string getSubFamiliaCod(string codFamilia, string codSubFamilia)
        {
            SubFamilia subfam = null;
            string sql = @"SELECT *
                            FROM SubFamilia WHERE FamiliaCod = @cod AND NumeroCodigoSF = @sub";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", getFamiliaCod(codFamilia));
            cmd.Parameters.AddWithValue("@sub", codSubFamilia);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return ""; //sale vacía
                }
                while (dr.Read())
                {
                    subfam = new SubFamilia((string)dr["FamiliaCod"],
                        (string)dr["CodSubFamilia"], dr.IsDBNull(dr.GetOrdinal("Nombre")) ? "" : (string)dr["Nombre"],
                        dr.IsDBNull(dr.GetOrdinal("Imagen")) ? "" : (string)dr["Imagen"],
                        dr.IsDBNull(dr.GetOrdinal("IVA")) ? -1 : (int)dr["IVA"],
                        dr.IsDBNull(dr.GetOrdinal("NumeroCodigoSF")) ? -1 : (int)dr["NumeroCodigoSF"]);
                }
                return subfam.CodSubFamilia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Producto> getProdsPorCodigoArticulo(string codigoArticulo)
        {
            List<Producto> productos = new List<Producto>();
            string sql = @"SELECT *
                            FROM   Registro
                            WHERE  Registro.CodigoArticulo LIKE @codigoArticulo; ";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@codigoArticulo", codigoArticulo + "%");
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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void insertarProductos(List<Producto> productos)
        {
            string sql = @"INSERT INTO Registro
                                        (CodigoArticulo,
                                         Descripcion,
                                         TallaPesoLitros,
                                         Stock,
                                         EmpleadoId,
                                         RecogidaId,
                                         Coste,
                                         FechaEntrada,
                                         CodFamilia,
                                         CodSubFamilia,
                                         LugarId)
                            VALUES      (@codArt,
                                         @desc,
                                         @medida,
                                         @stock,
                                         @empleadoid,
                                         @recogidaid,
                                         @coste,
                                         @fechaentrada,
                                         @codfam,
                                         @codsubfam,
                                         @lugarid);";

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
                    cmd.Parameters.AddWithValue("@lugarid", p.LugarId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void eliminarProducto(Producto producto)
        {
            string sql = @"DELETE
                              *
                            FROM Registro
                            WHERE  registro.CodigoArticulo = @codArt;";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public string crearEmpleado(string nombre, string foto) //Id autonumerico...
        {
            string sql = @"INSERT INTO Empleado
                                        (Nombre,
                                         Foto)
                            VALUES      (@name,
                                         @photo);";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@name", nombre);
            cmd.Parameters.AddWithValue("@photo", foto);
            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();
                return "";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void borrarEmpleado(int id)
        {
            string sql = @"DELETE FROM Empleado
                            WHERE  IdEmpleado = @id;";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public bool eliminarFamilia(string cod)
        {
            string sql = "DELETE FROM Familia    WHERE  CodFamilia = @cod;";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", cod);
            try
            {
                conTabla.Open();
                //cmd.ExecuteNonQuery();

                //string sql = @"DELETE FROM SubFamilia WHERE FamiliaCod = @cod";
                //cmd = new OleDbCommand(sql, conTabla);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public bool eliminarSubFamilia(string cod, string subCod)
        {
            string sql = @"DELETE FROM SubFamilia
                            WHERE  FamiliaCod = @cod AND CodSubFamilia = @subCod;";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@subCod", subCod);
            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Empleado> getEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            string sql = @"SELECT *
                            FROM Empleado;";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void realizarRecogida(Recogida recogida)
        {
            string sql = @"INSERT INTO Recogida
                                        (FechaRecogida,
                                         EmpleadoId,
                                         CantidadProductos,
                                         PersonaId)
                            VALUES      (@FechaRecogida,
                                         @EmpleadoId,
                                         @CantProd,
                                         @PersonaId);";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public int comprobarPersona(string nombre)
        {
            nombre = nombre.ToLower();
            string sql = @"SELECT IdPersona
                            FROM Persona
                            WHERE Lcase(Persona.Nombre) = @nombre; ";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();

                cmd.Parameters.AddWithValue("@nombre", nombre);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    sql = @"INSERT INTO Persona
                                        (Nombre)
                            VALUES(@nombre);";
                    cmd = new OleDbCommand(sql, conTabla);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.ExecuteNonQuery();

                    sql = @"SELECT IdPersona
                            FROM   Persona
                            WHERE  Lcase(Nombre) = @nombre;";
                    cmd = new OleDbCommand(sql, conTabla);
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    return (int)cmd.ExecuteScalar();

                }

                dr.Read();
                return (int)dr["IdPersona"];


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }

            return -1;
        }

        public int getUltimoNumRecogida()
        {
            string sql = @"SELECT Max(IdRecogida)
                            FROM Recogida; ";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public List<Recogida> getRecogidasSinTodosRegistros()
        {
            List<Recogida> recogidas = new List<Recogida>();
            string sql = @"SELECT Recogida.IdRecogida,
                                   Recogida.FechaRecogida,
                                   Recogida.CantidadProductos,
                                   Recogida.EmpleadoId,
                                   Recogida.PersonaId
                            FROM   Recogida
                                   LEFT JOIN Registro
                                          ON Recogida.IdRecogida = Registro.RecogidaId
                            GROUP  BY Recogida.CantidadProductos,
                                      Recogida.IdRecogida,
                                      Recogida.FechaRecogida,
                                      Recogida.EmpleadoId,
                                      Recogida.PersonaId,
                                      Registro.RecogidaId
                            HAVING Registro.RecogidaId IS NULL
                                    OR Recogida.CantidadProductos > SUM(Registro.Stock)
                            ORDER  BY Recogida.IdRecogida;";

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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }

        }

        public bool estaRecogidaCompleta(int id)
        {
            string sql = @"SELECT Recogida.CantidadProductos
                            FROM   Recogida
                                   INNER JOIN Registro
                                           ON Recogida.IdRecogida = Registro.RecogidaId
                            WHERE  Recogida.IdRecogida = 2
                            GROUP  BY Recogida.CantidadProductos
                            HAVING Recogida.CantidadProductos = SUM(Registro.Stock); ";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@recogidid", id);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }

        }

        public string getSiguienteIDProd(string codFamilia, string codSubfamilia)
        {
            string producto;
            int num = 0;
            string sql = @"SELECT TOP 1 CodigoArticulo
                            FROM   Registro
                            WHERE  Registro.CodFamilia = @codFamilia
                                   AND Registro.CodSubFamilia = @codSubFamilia
                            ORDER  BY CodigoArticulo DESC;";

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
                    num = 0; //No hay ids
                }
                else
                {
                    dr.Read();
                    producto = (string)dr["CodigoArticulo"];
                    int.TryParse(producto.Substring(producto.Length - 3, 3), out num);
                }
                num++;
                return num.ToString("000");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public void insertarVenta(List<Producto> productos, int empleadoID)
        {
            int numVenta;

            string sql = "INSERT INTO Venta (FechaVenta, EmpleadoId, Devolucion) VALUES (@FechaVenta, @EmpleadoId, @Devolucion);";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@FechaVenta", Util.GetDateWithoutMilliseconds(DateTime.Now));
            cmd.Parameters.AddWithValue("@EmpleadoId", empleadoID);
            cmd.Parameters.AddWithValue("@Devolucion", false);

            try
            {
                conTabla.Open();
                cmd.ExecuteNonQuery();

                sql = @"SELECT TOP 1 NumVenta
                        FROM Venta
                        ORDER BY NumVenta DESC;";
                cmd = new OleDbCommand(sql, conTabla);
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                numVenta = (int)dr["NumVenta"];

                sql = @"INSERT INTO VentaArticulos
                                    (CodigoArticulo,
                                     NumVenta,
                                     Coste)
                        VALUES      (@codArt,
                                     @numVenta,
                                     @coste);";


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
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

        public Lugar getLugar(Lugar lugar)
        {
            Lugar lugarFinal = null;
            string sql = @"SELECT Count(IdLugar)
                            FROM   Lugar
                            WHERE  Estanteria = @estanteria
                                   AND Estante = @estante
                                   AND Altura = @altura;";
            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            cmd.Parameters.AddWithValue("@estanteria", lugar.Estanteria);
            cmd.Parameters.AddWithValue("@estante", lugar.Estante);
            cmd.Parameters.AddWithValue("@altura", lugar.Altura);
            try
            {
                conTabla.Open();
                int result = (int)cmd.ExecuteScalar();
                if (result <= 0)
                {
                    sql = @"INSERT INTO Lugar
                                        (Estanteria,
                                         Estante,
                                         Altura)
                            VALUES     (@estanteria,
                                        @estante,
                                        @altura);";
                    cmd = new OleDbCommand(sql, conTabla);
                    cmd.Parameters.AddWithValue("@estanteria", lugar.Estanteria);
                    cmd.Parameters.AddWithValue("@estante", lugar.Estante);
                    cmd.Parameters.AddWithValue("@altura", lugar.Altura);
                    cmd.ExecuteNonQuery();
                }

                sql = @"SELECT *
                        FROM   Lugar
                                LEFT JOIN Registro
                                        ON Lugar.IdLugar = Registro.LugarId
                        WHERE  Registro.LugarId IS NULL
                                AND Estanteria = @estanteria
                                AND Estante = @estante
                                AND Altura = @altura;";
                cmd = new OleDbCommand(sql, conTabla);
                cmd.Parameters.AddWithValue("@estanteria", lugar.Estanteria);
                cmd.Parameters.AddWithValue("@estante", lugar.Estante);
                cmd.Parameters.AddWithValue("@altura", lugar.Altura);

                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return lugarFinal; //sale vacío
                }
                dr.Read();
                lugarFinal = new Lugar();
                lugarFinal.Id = (int)dr["IdLugar"];
                lugarFinal.Estanteria = dr.IsDBNull(dr.GetOrdinal("Estanteria")) ? "" : (string)dr["Estanteria"];
                lugarFinal.Estante = dr.IsDBNull(dr.GetOrdinal("Estante")) ? 0 : (int)dr["Estante"];
                lugarFinal.Altura = dr.IsDBNull(dr.GetOrdinal("Altura")) ? 0 : (int)dr["Altura"];

                return lugarFinal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conTabla.Close();
            }
        }

    }
}
