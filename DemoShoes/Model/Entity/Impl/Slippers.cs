namespace DemoShoes.Model.Entity.Impl
{
    //Тапочки
    class Slippers : Footwear, IFootSoleable
    {
        public bool IsFootSole { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tis footsole\t" + this.IsFootSole;
        }
    }
}
