using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    class Shoes : Footwear, IHeelable,ILaceable
    {
        public bool IsHeel { get ; set ; }
        public bool isLace { get ; set; }
    }
}
