using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    class Sandals : Footwear, IBarefootable,IClaspable
    {
        public bool isBarefoot { get ; set ; }
        public bool IsClasp { get ; set ; }
    }
}
