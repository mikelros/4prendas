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
            string sql = "SELECT * FROM Familia f INNER JOIN SubFamilia sf ON f.CodFamilia = sf.FamiliaCod; ";

            OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
            OleDbCommand cmd = new OleDbCommand(sql, conTabla);

            try
            {
                conTabla.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if(!dr.HasRows)
                {
                    return familias; //sale vacía
                }
        
          
                while (dr.Read())
                {
                    Familia familia = new Familia((string)dr["CodFamilia"], (string)dr["Nombre"], (string)dr["Imagen"], (int)dr["NumeroCodigo"]);
                    //List<SubFamilia>(); ME FALTA TERMINAR POR AQUI Y TENGO QUE HACER EL ADMIN

                    //familias.Add()); 
                }

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

        //si la clase familia tiene subfamilias como propiedad getFamilias ya saca las subfamilias

        //public List<Subfamilia> getSubfamilias(string codFamilia)
        //{
        //    List<Subfamilia> subfamilias = new List<Subfamilia>(); // no sé si es arraylist o qué
        //    string sql = "SELECT * FROM Subfamilia WHERE Subfamilia.FamiliaCod = @codfamilia";

        //    OleDbConnection conTabla = new OleDbConnection(cadenaConexion);
        //    OleDbCommand cmd = new OleDbCommand(sql, conTabla);
        //    cmd.Parameters.AddWithValue("@codfamilia", codFamilia);

        //    try
        //    {
        //        conTabla.Open();
        //        OleDbDataReader dr = cmd.ExecuteReader();
        //        if (!dr.HasRows)
        //        {
        //            return subfamilias; //sale vacía
        //        }


        //        while (dr.Read())
        //        {
        //            //subfamilias.Add(new SubFamilia(dr.GetString(0), dr.GetString(1), dr.GetString(2))); // no tengo claro el orden ni los campos (de tener familia necesita join la sql)
        //            //falta constructor y clases

        //        }

        //        return subfamilias;

        //    }
        //    catch (Exception ex)
        //    {
        //        //RaiseEvent errorBaseDatos(Me, New BaseDatosEventArgs("Error de base de datos"))
        //        return null;
        //    }
        //    finally
        //    {
        //        conTabla.Close();
        //    }
        //}

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
                {
                    //subfamilia.Add(new Producto(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetValue(3))); // no tengo claro el orden ni los campos (de tener familia, subfamilia etc necesita join la sql)
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

    }
}
