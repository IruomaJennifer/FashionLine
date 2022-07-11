namespace FashionLine.Domain
{
    public class Order : BaseEntity
    {
        public Order()
        {
           // DeliveryAddress = Owner.Address;
        }
        public virtual PaymentInformation PaymentInfo { get; set; }
        public virtual DateTime InitiationDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual DateTime FinishDate { get; set; }
        public virtual DeliveryStatus Status { get; set; }
        public virtual List<Clothe> Clothes { get; set; }
        public virtual Customer Owner { get; set; }
        public virtual string DeliveryAddress { get; set; }
        public virtual FashionLine FashionLine { get; set; }
    }
}
