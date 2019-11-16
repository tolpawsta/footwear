using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    class ShoesStorage : IStorage
    {
        List<Footwear> footwears;
        IFactoryable fabric;
        public ShoesStorage(IFactoryable fabric)
        {
            footwears = new List<Footwear>();
            this.fabric = fabric;
            Initialization();
        }

        private void Initialization()
        {
            this.footwears = fabric.CreateFootwearKit();
        }

        public List<Footwear> GetAllShoes()
        {
            return footwears;
        }

        public Footwear GetShoesByVendor(int vendor)
        {

          return footwears.SingleOrDefault(x => x.Vendor == vendor);
            
            
        }
    }
}
