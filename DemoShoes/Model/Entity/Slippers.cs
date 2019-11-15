
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    //Тапочки
    class Slippers : Footwear, IFootSoleable
    {
        public bool IsFootSole { get ; set ; }
    }
}
