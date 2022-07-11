using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class MeasurementMap:ClassMap<Measurement>
    {
        public MeasurementMap()
        {
            Id(meas => meas.Id);
            Map(meas => meas.Neck);
            Map(meas => meas.Shoulder);
            Map(meas => meas.Waist);
            Map(meas => meas.Hip);
            References(meas => meas.Owner).Unique();
        }
    }
}
