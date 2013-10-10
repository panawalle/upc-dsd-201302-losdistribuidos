using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;
using NHibernate.Criterion;
using NHibernate;
using ReservasWeb.Persistencia;

namespace SOAPServices.Persistencia
{
    public class OportunidadVentaDAO : BaseDAO<OportunidadVenta, int>
    {
        public int BuscarxCodServicio(OportunidadVenta oportunidadventa)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(OportunidadVenta)).
                    Add(Expression.Eq("codServicio", oportunidadventa.codServicio)).SetProjection(Projections.RowCount());
                if ((int)busqueda.List()[0] > 0)
                    return 1;
                return 0;
            }
        }
    }
}