using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(employee => employee.Id);
            Map(employee => employee.FirstName);
            Map(employee => employee.LastName);
            Map(employee => employee.Address);
            Map(employee => employee.Guarantor);
            Map(employee => employee.EmployeeRole).CustomType<Role>();
            References(employee => employee.FashionLine);
        }
    }
}
