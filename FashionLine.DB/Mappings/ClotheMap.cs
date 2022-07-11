using FashionLine.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Mappings
{
    public class ClotheMap:ClassMap<Clothe>
    {
        public ClotheMap()
        {
            Id(clothe => clothe.Id);
            Map(clothe => clothe.ClotheType).CustomType<ClotheType>();
            References(clothe => clothe.Order);
            HasManyToMany(clothe => clothe.Fabrics);
            References(clothe => clothe.Store);
        }
    }
}
