using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPServices.Persistencia
{
    public class MarcaDAO
    {

        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Marca fnObtenerMarca(int codMarca)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Marca objMarca = new Dominio.Marca();

            try
            {
                DataSet ds = new DataSet();
                DataTable dtMarca = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarMarca", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codMarca", SqlDbType.Int).Value = codMarca ;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtMarca = ds.Tables[0];

                if (dtMarca.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtMarca.Rows)
                    {
                        objMarca.codMarca = Convert.ToInt32(dr["codMarca"]);
                        objMarca.descripcion = (string)dr["descripcion"].ToString();
                        objMarca.estado = (string)dr["estado"].ToString();
                    }
                }

            }
            catch (Exception)
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
                throw;
            }
            finally
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
            }
            return objMarca;
        }

    }
}