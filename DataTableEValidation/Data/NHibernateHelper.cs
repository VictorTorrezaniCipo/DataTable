using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Data
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISession AbrirSessao()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(x => x.FromConnectionStringWithKey("Banco1")))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<NHibernateHelper>()).BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }
    }
}