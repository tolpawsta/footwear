namespace DemoShoes.Model.Entity.Impl
{
    class Sandals : Footwear, IBarefootable, IClaspable
    {
        public bool isBarefoot { get; set; }
        public bool IsClasp { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tbarefoot\t" + this.isBarefoot +
                "\n\tis clasp\t" + this.IsClasp;
        }
    }
}
