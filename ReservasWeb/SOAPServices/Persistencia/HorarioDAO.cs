using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SOAPServices.Persistencia
{
    public class HorarioDAO
    {

        ConexionUtil objConUtil = new ConexionUtil();

        public Dominio.Horario fnObtenerHorario(DateTime fecha)
        {

            SqlConnection objSqlCon = new SqlConnection();
            objSqlCon = objConUtil.fnObtenerConexion();
            objSqlCon.Open();
            Dominio.Horario objHorario = new Dominio.Horario();

            try
            {
                DataSet ds = new DataSet();
                DataTable dtHorarioHeader = new DataTable();
                DataTable dtHorarioBody = new DataTable();

                SqlDataAdapter cmd = new SqlDataAdapter("sp_consultarHorario", objSqlCon);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.Add("@fechaConsulta", SqlDbType.Date).Value = fecha;
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(ds);
                dtHorarioHeader = ds.Tables[0];
                dtHorarioBody = ds.Tables[1];

                if (dtHorarioHeader.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtHorarioHeader.Rows)
                    {
                        objHorario.header = (string)(dr["horario"]);
                        objHorario.dia1  = (string)dr["Dia1"].ToString();
                        objHorario.dia2  = (string)dr["Dia2"].ToString();
                        objHorario.dia3 = (string)dr["Dia3"].ToString();
                        objHorario.dia4 = (string)dr["Dia4"].ToString();
                        objHorario.dia5 = (string)dr["Dia5"].ToString();
                        objHorario.dia6 = (string)dr["Dia6"].ToString();

                        List<Dominio.HorarioBody> objListHorarioBody = new List<Dominio.HorarioBody>();
                        if (dtHorarioBody.Rows.Count > 0) {
                            foreach (DataRow dr2 in dtHorarioBody.Rows)
                            {
                                Dominio.HorarioBody objHorarioBody = new Dominio.HorarioBody();
                                objHorarioBody.header = (string)(dr2["horario"]);
                                objHorarioBody.dia1 = (string)dr2["Dia1"].ToString();
                                objHorarioBody.dia2 = (string)dr2["Dia2"].ToString();
                                objHorarioBody.dia3 = (string)dr2["Dia3"].ToString();
                                objHorarioBody.dia4 = (string)dr2["Dia4"].ToString();
                                objHorarioBody.dia5 = (string)dr2["Dia5"].ToString();
                                objHorarioBody.dia6 = (string)dr2["Dia6"].ToString();
                                objListHorarioBody.Add(objHorarioBody);
                            }
                            objHorario.horarioBody = objListHorarioBody;
                        }


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
            return objHorario;
        }

    }
}