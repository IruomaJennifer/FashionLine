using FashionLine.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Mappings
{
    public class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(cust => cust.Id);
            Map(cust => cust.Name);
            Map(cust => cust.Address);
            HasMany(cust => cust.Orders);
            HasOne(cust => cust.Measurement).PropertyRef(meas => meas.Owner);
            References(cust => cust.FashionLine);
        }
    }
}
