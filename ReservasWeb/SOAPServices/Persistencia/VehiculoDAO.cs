using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPServices.Persistencia
{
    public class VehiculoDAO
    {
        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Vehiculo fnObtenerVehiculo(string placa)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Vehiculo objVehiculo = new Dominio.Vehiculo();
            objVehiculo.blnResultado = false;
            objVehiculo.strMensaje = "";
            try
            {
                DataSet ds = new DataSet();
                DataTable dtVehiculo = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarVehiculo", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@placa", SqlDbType.VarChar, 6).Value = placa;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtVehiculo = ds.Tables[0];

                if (dtVehiculo.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtVehiculo.Rows)
                    {
                        objVehiculo.placa = (string)(dr["placa"]);
                        objVehiculo.vin = (string)dr["vin"];
                        objVehiculo.codColor = (string)dr["codColor"];
                        objVehiculo.codModelo = (string)dr["codModelo"];
                        objVehiculo.anio = (string)dr["anio"];
                        objVehiculo.motor = (string)dr["motor"];
                        objVehiculo.contacto = (string)dr["contacto"];
                        objVehiculo.usuario = (string)dr["usuario"];
                        objVehiculo.fecha = (DateTime)dr["fecha"];
                        objVehiculo.codCliente = (int)dr["codcliente"];
                        objVehiculo.blnResultado = true;
                    }
                }

            }
            catch (Exception e)
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
                objVehiculo.blnResultado = false;
                objVehiculo.strMensaje = e.Message;
            }
            finally
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
            }
            return objVehiculo;
        }

    }
}