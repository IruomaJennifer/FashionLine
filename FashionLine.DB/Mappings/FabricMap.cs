using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class FabricMap : ClassMap<Fabric>
    {
        public FabricMap()
        {
            Id(fabric => fabric.Id);
            Map(fabric => fabric.Name).CustomType<FabricType>();
            Map(fabric => fabric.Yards);
            References(fabric => fabric.Storage);
            HasManyToMany(fabric => fabric.Clothes);
        }
    }
}
