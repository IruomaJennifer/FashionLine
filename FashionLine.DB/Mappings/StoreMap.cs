using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class StoreMap : ClassMap<Store>
    {
        public StoreMap()
        {
            Id(store=>store.Id);
            HasMany(store => store.ClotheInventory);
            HasMany(store => store.Fabrics);
            References(store => store.FashionLine).Unique();
        }
    }
}
