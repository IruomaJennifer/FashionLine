namespace FashionLine.Domain
{
    public class Fabric : BaseEntity
    {
        public virtual FabricType Name { get; set; }
        public virtual float Yards { get; set; }
        public virtual Store Storage { get; set; }
        public virtual List<Clothe> Clothes { get; set; }
    }
}
