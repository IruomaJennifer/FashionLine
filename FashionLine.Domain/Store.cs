namespace FashionLine.Domain
{
    public class Store : BaseEntity
    {
        public virtual List<Clothe> ClotheInventory { get; set; }
        public virtual List<Fabric> Fabrics { get; set; }
        public virtual FashionLine FashionLine { get; set; }
    }
}
