using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.Domain
{
    public class FashionLine : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<Order> AllOrdersPlaced { get; set; }
        public virtual Store Store { get; set; }
        
    }

}
