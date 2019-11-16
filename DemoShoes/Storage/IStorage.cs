using System.Collections.Generic;

namespace DemoShoes
{
    interface IStorage
    {
        List<Footwear> GetAllShoes();
        Footwear GetShoesByVendorCode(int vendorCode);

    }
}
