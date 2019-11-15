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
        IFabricable fabric;
        public ShoesStorage(IFabricable fabric)
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
            try
            {
                footwears.Select(x => x.Vendor == vendor);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }
}
