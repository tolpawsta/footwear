namespace DemoShoes
{
    abstract class Footwear
    {
        public int Vendor { get; set; }
        public string Name { get; set; }
        public int Size { get; set; } = 0;
        public decimal Cost { get; set; } = 0;
        public MatertialType Material { get; set; }
        public GenderType Gender { get; set; }
        public SeasonType Season { get; set; }
        public virtual string ToString()
        {
            return "articul " + Vendor
                + "name " + Name
                + "gender " + Gender
                + "season " + Season
                + "material " + Material
                + "size " + Size
                + "cost " + Cost;
        }

    }
}
