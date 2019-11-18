namespace DemoShoes.Model.Entity.Impl
{
    class Boots : Footwear, IHeelable, IHeightable
    {
        public double Height { get; set; }
        public bool IsHeel { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "\n\theight\t" + Height +
                "\n\theel\t" + IsHeel;
        }

    }
}
