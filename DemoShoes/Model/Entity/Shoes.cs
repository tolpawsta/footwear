using DemoShoes.Model.Interface;

namespace DemoShoes.Model.Entity
{
    class Shoes : Footwear, IHeelable, ILaceable
    {
        public bool IsHeel { get; set; }
        public bool isLace { get; set; }
    }
}
