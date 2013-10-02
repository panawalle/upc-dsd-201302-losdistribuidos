using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPServices.Persistencia
{
    public class ServicioDAO
    {

        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Servicio fnObtenerServicio(string codOper, string codOperSer)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Servicio objServicio = new Dominio.Servicio();

            try
            {
                DataSet ds = new DataSet();
                DataTable dtServicios = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarServicio", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codOper", SqlDbType.Char, 2).Value = codOper;
                cmd.SelectCommand.Parameters.Add("@codOperSer", SqlDbType.Char, 5).Value = codOperSer;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtServicios = ds.Tables[0];

                if (dtServicios.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtServicios.Rows)
                    {
                        objServicio.codOper = (string)(dr["codOper"]);
                        objServicio.codOperSer = (string)(dr["codOperSer"]);
                        objServicio.descripcion = (string)dr["descripcion"].ToString();
                        objServicio.precio = (Convert.ToDouble(dr["precio"].ToString()));
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
            return objServicio;
        }


    }
}