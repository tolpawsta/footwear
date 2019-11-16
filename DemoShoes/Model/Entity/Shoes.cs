namespace DemoShoes.Model
{
    class Shoes : Footwear, IHeelable,ILaceable
    {
        public bool IsHeel { get ; set ; }
        public bool isLace { get ; set; }
    }
}
