namespace DemoShoes.Model.Entity.Impl
{
    class Shoes : Footwear, IHeelable, ILaceable
    {
        public bool IsHeel { get; set; }
        public bool isLace { get; set; }
    }
}
