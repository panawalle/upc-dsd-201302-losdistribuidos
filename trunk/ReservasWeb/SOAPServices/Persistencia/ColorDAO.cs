using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPService.Persistencia
{
    public class ColorDAO
    {
        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Color fnObtenerColor(string codColor)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Color objColor = new Dominio.Color();

            try
            {
                DataSet ds = new DataSet();
                DataTable dtColor = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarColor", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codColor", SqlDbType.Char,4).Value = codColor ;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtColor = ds.Tables[0];

                if (dtColor.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtColor.Rows)
                    {
                        objColor.codColor  = (string)(dr["codColor"]);
                        objColor.descripcion = (string)dr["descripcion"].ToString();
                        objColor.estado = (string)dr["estado"].ToString();
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
            return objColor;
        }

    }
}