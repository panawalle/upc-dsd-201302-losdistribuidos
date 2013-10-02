using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPServices.Persistencia
{
    public class ModeloDAO
    {

        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Modelo fnObtenerModelo(string codModelo)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Modelo objModelo = new Dominio.Modelo();

            try
            {
                DataSet ds = new DataSet();
                DataTable dtModelo = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarModelo", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codModelo", SqlDbType.Char,6).Value = codModelo ;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtModelo = ds.Tables[0];

                if (dtModelo.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtModelo.Rows)
                    {
                        objModelo.codModelo  = (string)(dr["codModelo"]);
                        objModelo.codMarca= Convert.ToInt32(dr["codMarca"].ToString());
                        objModelo.descripcion = (string)dr["descripcion"].ToString();
                        objModelo.estado = (string)dr["estado"].ToString();
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
            return objModelo;
        }

    }
}
