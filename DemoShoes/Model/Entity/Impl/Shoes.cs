namespace DemoShoes.Model.Entity.Impl
{
    class Shoes : Footwear, IHeelable, ILaceable
    {
        public bool IsHeel { get; set; }
        public bool IsLace { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tis heel\t" + this.IsHeel +
                "\n\tis lace\t" + this.IsLace;
        }
    }
}
