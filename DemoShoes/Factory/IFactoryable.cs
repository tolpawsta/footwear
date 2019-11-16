using System.Collections.Generic;

namespace DemoShoes
{
    interface IFactoryable
    {
        Footwear CreateFootwear(int vendor);
        List<Footwear> CreateFootwearKit();
    }
}
