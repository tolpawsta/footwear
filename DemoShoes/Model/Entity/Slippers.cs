using DemoShoes.Model.Interface;

namespace DemoShoes.Model.Entity
{
    //Тапочки
    class Slippers : Footwear, IFootSoleable
    {
        public bool IsFootSole { get; set; }
    }
}
