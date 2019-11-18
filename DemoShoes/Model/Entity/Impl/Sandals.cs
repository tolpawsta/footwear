namespace DemoShoes.Model.Entity.Impl
{
    class Sandals : Footwear, IBarefootable, IClaspable
    {
        public bool isBarefoot { get; set; }
        public bool IsClasp { get; set; }
    }
}
