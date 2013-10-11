using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SOAPServices.Dominio;

namespace SOAPServices.Persistencia
{
    public class ReservaDAO
    {
        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Reserva fnObtenerReserva(int codReserva)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Reserva objReserva = new Dominio.Reserva();
            Dominio.ReservaDetalle objReservaDetalle = new Dominio.ReservaDetalle();
            

            try
            {
                DataSet ds = new DataSet();
                DataTable dtCabecera = new DataTable();
                DataTable dtDetalle = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_buscarReserva", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codReserva", SqlDbType.Int).Value = codReserva;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtCabecera = ds.Tables[0];
                dtDetalle = ds.Tables[1];

                if (dtCabecera.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtCabecera.Rows)
                    {
                        objReserva.codReserva = Convert.ToInt32(dr["codReserva"]);
                        objReserva.nroReserva = dr["nroReserva"].ToString();
                        objReserva.placa = dr["placa"].ToString();
                        objReserva.fecha = Convert.ToDateTime(dr["fecha"]);
                        objReserva.numExpress = Convert.ToInt32(dr["numExpress"]);
                        objReserva.numCodigoAsesor = Convert.ToInt32(dr["numCodigoAsesor"]);
                        objReserva.estado = dr["estado"].ToString();
                        objReserva.hora = dr["hora"].ToString();
                        objReserva.blnResultado = true;
                        objReserva.strMensaje = "La operación se registró exitosamente";
                    }

                    if (dtDetalle.Rows.Count > 0)
                    {
                        List<ReservaDetalle> objListDetalleReserva = new List<ReservaDetalle>();
                        foreach (DataRow dr in dtDetalle.Rows)
                        {
                            objReservaDetalle.codDetalle = Convert.ToInt32(dr["codDetalle"]);
                            objReservaDetalle.codReserva = Convert.ToInt32(dr["codReserva"]);
                            objReservaDetalle.codOper = dr["codOper"].ToString();
                            objReservaDetalle.codOperSer = dr["codOperSer"].ToString();
                            objReservaDetalle.estado = dr["estado"].ToString();
                            objListDetalleReserva.Add(objReservaDetalle);
                        }
                        objReserva.reservaDetalle = objListDetalleReserva;
                    }
                }

            }
            catch (Exception e)
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
                objReserva.blnResultado = false;
                objReserva.strMensaje = e.Message;
            }
            finally
            {

                if (objSqlCon.State == ConnectionState.Open)
                {
                    objSqlCon.Close();
                }
            }
            return objReserva;
        }

        public Dominio.Reserva fnGuardarReserva(Dominio.Reserva objReserva)
        {
            Dominio.Reserva objReservaEncontrada = new Dominio.Reserva();

            try
            {
                SqlConnection objSqlCon = new SqlConnection();
                SqlTransaction objSqlTran;
                objSqlCon = objConUtil.fnObtenerConexion();
                objSqlCon.Open();
                objSqlTran = objSqlCon.BeginTransaction();
                int intCodReserva = 0;


                try
                {

                    SqlCommand cmd;

                    cmd = new SqlCommand("sp_guardarReservaCab", objSqlCon, objSqlTran);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@codReserva", SqlDbType.Int).Value = 0;
                    cmd.Parameters["@codReserva"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nroReserva", SqlDbType.VarChar, 20).Value = objReserva.nroReserva;
                    cmd.Parameters.Add("@placa", SqlDbType.Char, 6).Value = objReserva.placa;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = objReserva.fecha;
                    cmd.Parameters.Add("@numExpress", SqlDbType.Int).Value = objReserva.numExpress;
                    cmd.Parameters.Add("@numCodigoAsesor", SqlDbType.Int).Value = objReserva.numCodigoAsesor;
                    cmd.Parameters.Add("@estado", SqlDbType.Char, 1).Value = "0";
                    cmd.Parameters.Add("@hora", SqlDbType.VarChar, 5).Value = objReserva.hora;
                    cmd.ExecuteNonQuery();

                    intCodReserva = (int)cmd.Parameters["@codReserva"].Value;

                    if (objReserva.reservaDetalle != null)
                    {


                        if (objReserva.reservaDetalle.Count > 0)
                        {
                            cmd = new SqlCommand("sp_guardarReservaDet", objSqlCon, objSqlTran);
                            cmd.CommandType = CommandType.StoredProcedure;

                            foreach (Dominio.ReservaDetalle obj in objReserva.reservaDetalle)
                            {
                                cmd.Parameters.Add("@codDetalle", SqlDbType.Int).Value = 0;
                                cmd.Parameters.Add("@codReserva", SqlDbType.Int).Value = intCodReserva;
                                cmd.Parameters.Add("@codOper", SqlDbType.Char, 2).Value = obj.codOper;
                                cmd.Parameters.Add("@codOperSer", SqlDbType.Char, 5).Value = obj.codOperSer;
                                cmd.Parameters.Add("@estado", SqlDbType.Char, 1).Value = "0";
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                    }
                    cmd.Dispose();
                    objSqlTran.Commit();

                    objReservaEncontrada = (Dominio.Reserva)fnObtenerReserva(intCodReserva);
                }
                catch (Exception e)
                {
                    objSqlTran.Rollback();
                    if (objSqlCon.State == ConnectionState.Open)
                    {
                        objSqlCon.Close();
                    }


                    objReservaEncontrada.blnResultado = false;
                    objReservaEncontrada.strMensaje = e.Message;
                }
                finally
                {

                    if (objSqlCon.State == ConnectionState.Open)
                    {
                        objSqlCon.Close();
                    }
                }
            }
            catch (Exception e)
            {

                objReservaEncontrada.blnResultado = false;
                objReservaEncontrada.strMensaje = e.Message;
            }

            return objReservaEncontrada;
        }

        public List<Dominio.Reserva> fnListarReserva(int codReserva, string nroReserva, string placa, int codestado)
        {
            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            List<Dominio.Reserva> objListReserva = new List<Dominio.Reserva>();
            DataTable objDtReservas = new DataTable();
            DataTable objDtDetalleReservas = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter cmd = new SqlDataAdapter("sp_ListarReservas", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@codReserva", SqlDbType.Int).Value = codReserva;
                cmd.SelectCommand.Parameters.Add("@nroReserva", SqlDbType.VarChar, 20).Value = nroReserva;
                cmd.SelectCommand.Parameters.Add("@placa", SqlDbType.VarChar, 10).Value = placa;
                cmd.SelectCommand.Parameters.Add("@codestado", SqlDbType.Int).Value = codestado;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                objDtReservas = ds.Tables[0];
                objDtDetalleReservas = ds.Tables[1];

                foreach (DataRow dr in objDtReservas.Rows)
                {
                    Dominio.Reserva objReserva = new Dominio.Reserva();
                    objReserva.codReserva = (int)dr["codReserva"];
                    objReserva.nroReserva = (string)dr["nroReserva"];
                    objReserva.placa = (string)dr["placa"];
                    objReserva.fecha = (DateTime)dr["fecha"];
                    objReserva.numExpress = (int)dr["numExpress"];
                    objReserva.numCodigoAsesor = (int)dr["numCodigoAsesor"];
                    objReserva.estado = (string)dr["estado"];
                    objReserva.hora = (string)dr["hora"];
                    objReserva.blnResultado = true;

                    List<Dominio.ReservaDetalle> objListDetalleReserva = new List<Dominio.ReservaDetalle>();

                    foreach (DataRow dr2 in objDtDetalleReservas.Rows)
                    {

                        if ((int)dr2["codReserva"] == objReserva.codReserva)
                        {
                            Dominio.ReservaDetalle objDetalleReserva = new Dominio.ReservaDetalle();
                            objDetalleReserva.codReserva = (int)dr2["codReserva"];
                            objDetalleReserva.codDetalle = (int)dr2["codDetalle"];
                            objDetalleReserva.codOper = (string)dr2["codOper"];
                            objDetalleReserva.codOperSer = (string)dr2["codOperSer"];
                            objDetalleReserva.estado = (string)dr2["estado"];
                            objListDetalleReserva.Add(objDetalleReserva);
                        }
                    }

                    objReserva.reservaDetalle = objListDetalleReserva;
                    objListReserva.Add(objReserva);

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
            return objListReserva;
        }
    }
}
