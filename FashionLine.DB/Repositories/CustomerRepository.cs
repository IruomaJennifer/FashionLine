using FashionLine.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository() : base()
        {
        }
    }
}
