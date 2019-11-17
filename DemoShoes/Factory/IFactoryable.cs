using DemoShoes.Model.Entity;
using System.Collections.Generic;

namespace DemoShoes.Factory
{
    interface IFactoryable
    {
        Footwear CreateFootwear(int vendor);
        List<Footwear> CreateFootwearKit();
    }
}
