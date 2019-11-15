
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    //Кроссовки
    class Sneakers : Footwear, ISportable,IFootSoleable,ILaceable

    {
        public bool ForSport { get; set ; }
        public bool IsFootSole { get; set; }
        public bool isLace { get ; set ; }
    }
}
