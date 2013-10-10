using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;
using NHibernate.Criterion;
using NHibernate;

namespace ReservasWeb.Persistencia
{
    public class ClienteDAO : BaseDAO<Cliente,int>
    {
        //public int BuscarxDNI(Cliente usuario)
        //{
        //    using (ISession sesion = NHibernateHelper.ObtenerSesion())
        //    {
        //        ICriteria busqueda = sesion.CreateCriteria(typeof(Cliente)).Add(Expression.Eq("dnicliente", usuario.dnicliente)).SetProjection(Projections.RowCount());
        //        if ((int)busqueda.List()[0] > 0)
        //            return 1;
        //        return 0;
        //    }
        //}
    }
}