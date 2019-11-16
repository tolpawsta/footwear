using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    class Boots : Footwear, IHeelable, IHeightable
    {
        public double Height { get; set; }
        public bool IsHeel { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                " height " + Height+
                "heel "+IsHeel;
        }

    }
}
