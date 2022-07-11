namespace FashionLine.Domain
{
    public class Clothe : BaseEntity
    {
        public virtual ClotheType ClotheType { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<Fabric> Fabrics { get; set; }
        public virtual Store Store { get; set; }
    }
}
