using FashionLine.DB.Mappings;
using FashionLine.DB.Repositories;
using FashionLine.Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB
{
    public class FluentNHibernateHelper
    {
        private ISessionFactory _sessionFactory;

        public ISessionFactory SessionFactory => _sessionFactory ??
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (_connectionString))
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMap>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory();

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
            

        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\CypherCresent Software Academy\Assignments\FashionLine\FashionLine\FashionDB1.mdf; Integrated Security=True;Connect Timeout=30";

    }
}
