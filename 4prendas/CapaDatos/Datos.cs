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

        public List<Familia> getFamilias()
        {
            List<Familia> familias = new List<Familia>(); // no sé si es arraylist o qué
            string sql = "SELECT * FROM Familia f INNER JOIN SubFamilia sf ON sf.FamiliaCod = f.CodFamilia";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);

            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if(!dr.Read())
                {
                    return familias; //sale vacía
                }
                bool fin = false;
                do
                {
                    Familia familia = new Familia((string)dr["CodFamilia"], (string)dr["NombreFamilia"], (string)dr["ImagenFamilia"], (int)dr["NumeroCodigoF"]);
                    do
                    { //No esta puesto, porque una familia no puede no tener subfamilia... pero y si si?
                        familia.SubFamilias.Add(new SubFamilia((string)dr["FamiliaCod"], (string)dr["CodSubFamilia"], (string)dr["Nombre"], (string)dr["Imagen"], (int)dr["IVA"], (int)dr["NumeroCodigoSF"]));
                        if (!dr.Read())
                        {
                            fin = true;
                        }
                    } while (!fin && ((string)dr["CodFamilia"]).Equals(familia.CodFamilia));
                    
                    familias.Add(familia);
                } while (!fin);


                return familias;
                               
            } catch (Exception ex)
            {
                //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
                return null;
            } finally
            {
                conTabla.Close();
            }
        }
       

        public List<Producto> getProductos(string codSubfamilia)
        {
            List<Producto> productos = new List<Producto>(); // no sé si es arraylist o qué
            string sql = "SELECT * FROM Productos WHERE Registro.CodSubFamilia = @codSubFamilia";

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
                {//TERMINAR EL PRODUCTOS.ADD
                    //productos.Add(new Producto(dr["CodigoArticulo"], dr["Descripcion"], dr["TallaPesoLitros"], dr["Stock"], dr["StockMinimo"], )); // no tengo claro el orden ni los campos (de tener familia, subfamilia etc necesita join la sql)
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

        public List<Administrador> getAdministradores()
        {
            List<Administrador> administradores = new List<Administrador>(); // no sé si es arraylist o qué
            string sql = "SELECT * FROM Administrador";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);
            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    return administradores; //sale vacía
                }


                while (dr.Read())
                {
                    administradores.Add(new Administrador((string)dr["Usuario"], (string)dr["Contrasena"]));
                }

                return administradores;

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

    }
}
