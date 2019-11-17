using DemoShoes.Model.Interface;

namespace DemoShoes.Model.Entity
{
    class Sandals : Footwear, IBarefootable, IClaspable
    {
        public bool isBarefoot { get; set; }
        public bool IsClasp { get; set; }
    }
}
