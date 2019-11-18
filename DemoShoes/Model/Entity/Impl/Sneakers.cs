namespace DemoShoes.Model.Entity.Impl
{
    //Кроссовки
    class Sneakers : Footwear, ISportable, IFootSoleable, ILaceable

    {
        public bool ForSport { get; set; }
        public bool IsFootSole { get; set; }
        public bool IsLace { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "\n\tfor sport\t" + this.ForSport +
                "\n\tis foot sole\t" + this.IsFootSole +
                "\n\tis lace\t" + this.IsLace;
        }
    }
}
