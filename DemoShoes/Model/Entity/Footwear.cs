using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    abstract class Footwear
    {
       public int Vendor { get; set; } 
      public  string Name { get; set; }
        public int Size { get; set; } = 0;
        public decimal Coast { get; set; } = 0;
       public MatertialType Material { get; set; }
        public GenderType Gender { get; set; }
        public SeasonType Season { get; set; }

    }
}
