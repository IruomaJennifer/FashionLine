using FashionLine.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public Repository()
        {
            helper = new();
            Session = helper.OpenSession();
        }

        public void Add(T entity)
        {
            using var transaction = Session.BeginTransaction();
            Session.Save(entity);
            transaction.Commit();
        }

        public T GetById(int id)
        {
            using var transaction = Session.BeginTransaction();
            var value = Session.Query<T>().Where(x => x.Id == id);
            transaction.Commit();
            return (T)value;
            
        }

        public void Remove(T entity)
        {
            using var transaction = Session.BeginTransaction();
            Session.Delete(entity);
            transaction.Commit();
        }

        public void Update(T entity)
        {
            using var transaction = Session.BeginTransaction();
            Session.Update(entity);
            transaction.Commit();
        }

        private FluentNHibernateHelper helper { get; set; }
        private ISession Session { get; set; }

    }
}
