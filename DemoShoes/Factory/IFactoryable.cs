using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    interface IFactoryable
    {
        Footwear CreateFootwear(int vendor);
        List<Footwear> CreateFootwearKit();
    }
}
