using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class PayentInformationMap:ClassMap<PaymentInformation>
    {
        public PayentInformationMap()
        {
            Id(paymnt => paymnt.Id);
            Map(paymnt => paymnt.Price);
            Map(paymnt => paymnt.AmountPaid);
            References(paymnt => paymnt.Order).Unique();
        }
    }
}
