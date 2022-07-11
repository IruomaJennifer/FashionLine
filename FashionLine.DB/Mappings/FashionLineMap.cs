using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class FashionLineMap : ClassMap<Domain.FashionLine>
    {
        public FashionLineMap()
        {
            Id(fashionln => fashionln.Id);
            Map(fashionln => fashionln.Name);
            Map(fashionln => fashionln.Location);
            HasMany(fashionln => fashionln.Employees);
            HasMany(fashionln => fashionln.Customers);
            HasMany(fashln => fashln.AllOrdersPlaced);
            HasOne(fashionln => fashionln.Store).PropertyRef(store => store.FashionLine);
        }
    }
}
