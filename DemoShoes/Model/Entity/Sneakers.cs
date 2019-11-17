using DemoShoes.Model.Interface;

namespace DemoShoes.Model.Entity
{
    //Кроссовки
    class Sneakers : Footwear, ISportable, IFootSoleable, ILaceable

    {
        public bool ForSport { get; set; }
        public bool IsFootSole { get; set; }
        public bool isLace { get; set; }
    }
}
