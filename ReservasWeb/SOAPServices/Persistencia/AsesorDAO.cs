using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SOAPServices.Dominio;

namespace SOAPServices.Persistencia
{
    public class AsesorDAO
    {

        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Asesor fnObtenerAsesor(int numCodigoAsesor)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Asesor objAsesor = new Dominio.Asesor();
            objAsesor.blnResultado = false;
            objAsesor.strMensaje = "";
            try
            {
                DataSet ds = new DataSet();
                DataTable dtAsesor = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarAsesor", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@numCodigoAsesor", SqlDbType.Int).Value = numCodigoAsesor;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtAsesor  = ds.Tables[0];

                if (dtAsesor.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtAsesor.Rows)
                    {
                        objAsesor.numCodigoAsesor = Convert.ToInt32(dr["numCodigoAsesor"]);
                        objAsesor.nombre = dr["nombre"].ToString();
                        objAsesor.blnResultado = true;
                    }
                }

            }
            catch (Exception e)
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
                objAsesor.blnResultado = false;
                objAsesor.strMensaje = e.Message;
            }
            finally
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
            }
            return objAsesor;
        }

    }
}