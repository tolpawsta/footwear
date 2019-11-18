namespace DemoShoes.Model.Entity
{
    abstract class Footwear
    {
        public int VendorCode { get; set; }
        public string Name { get; set; }
        public int Size { get; set; } = 0;
        public double Cost { get; set; } = 0;
        public MatertialType Material { get; set; }
        public GenderType Gender { get; set; }
        public SeasonType Season { get; set; }
        public virtual string ToString()
        {
            return "articul " + VendorCode
                + "\n\tname\t" + Name
                + "\n\tgender\t" + Gender
                + "\n\tseason\t" + Season
                + "\n\tmaterial\t" + Material
                + "\n\tsize\t" + Size
                + "\n\tcost\t" + Cost;
        }

    }
}
