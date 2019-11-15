using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    interface IStorage
    {
        List<Footwear> GetAllShoes();
        Footwear GetShoesByVendor(int vendor);

    }
}
